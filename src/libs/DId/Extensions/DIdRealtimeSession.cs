#pragma warning disable CS3001 // Argument type is not CLS-compliant
#pragma warning disable CS3002 // Return type is not CLS-compliant
#pragma warning disable CS3003 // Type is not CLS-compliant
#pragma warning disable CA1819 // Properties should not return arrays
#pragma warning disable CA1031 // Do not catch general exception types

using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using SIPSorcery.Net;
using SIPSorceryMedia.Abstractions;

namespace DId;

/// <summary>
/// Represents a received video frame from the D-ID avatar stream.
/// </summary>
/// <param name="Timestamp">The RTP timestamp of the frame.</param>
/// <param name="EncodedData">The encoded video frame payload (H.264 or VP8).</param>
/// <param name="Format">The video format/codec of the frame.</param>
public sealed record VideoFrame(uint Timestamp, byte[] EncodedData, VideoFormat Format);

/// <summary>
/// Represents a received audio frame from the D-ID avatar stream.
/// </summary>
/// <param name="EncodedData">The encoded audio payload.</param>
/// <param name="Format">The audio format/codec of the frame.</param>
/// <param name="DurationMs">Duration of the audio frame in milliseconds.</param>
public sealed record AudioFrame(byte[] EncodedData, AudioFormat Format, uint DurationMs);

/// <summary>
/// Represents a realtime WebRTC session with a D-ID agent.
/// Handles SDP/ICE negotiation using SIPSorcery and the D-ID REST signaling endpoints.
/// </summary>
public sealed class DIdRealtimeSession : IAsyncDisposable
{
    private readonly DIdClient _client;
    private readonly RTCPeerConnection _peerConnection;
    private readonly string _agentId;
    private readonly string _streamId;
    private readonly string? _sessionId;
    private readonly Channel<VideoFrame> _videoFrames = Channel.CreateBounded<VideoFrame>(
        new BoundedChannelOptions(capacity: 128)
        {
            FullMode = BoundedChannelFullMode.DropOldest,
            SingleReader = true,
            SingleWriter = true,
        });
    private readonly Channel<AudioFrame> _audioFrames = Channel.CreateBounded<AudioFrame>(
        new BoundedChannelOptions(capacity: 256)
        {
            FullMode = BoundedChannelFullMode.DropOldest,
            SingleReader = true,
            SingleWriter = true,
        });
    private readonly Channel<string> _dataMessages = Channel.CreateBounded<string>(
        new BoundedChannelOptions(capacity: 64)
        {
            FullMode = BoundedChannelFullMode.DropOldest,
            SingleReader = true,
            SingleWriter = true,
        });
    private RTCDataChannel? _dataChannel;
    private bool _disposed;

    private DIdRealtimeSession(
        DIdClient client,
        RTCPeerConnection peerConnection,
        string agentId,
        string streamId,
        string? sessionId)
    {
        _client = client;
        _peerConnection = peerConnection;
        _agentId = agentId;
        _streamId = streamId;
        _sessionId = sessionId;
    }

    /// <summary>
    /// Gets the stream ID for this session.
    /// </summary>
    public string StreamId => _streamId;

    /// <summary>
    /// Gets the session ID for this session.
    /// </summary>
    public string? SessionId => _sessionId;

    /// <summary>
    /// Gets the current ICE connection state.
    /// </summary>
    public RTCIceConnectionState IceConnectionState => _peerConnection.iceConnectionState;

    /// <summary>
    /// Creates and connects a realtime WebRTC session with a D-ID agent.
    /// </summary>
    /// <param name="client">The authenticated D-ID client.</param>
    /// <param name="agentId">The agent ID to stream with.</param>
    /// <param name="compatibilityMode">VP8 (on) or H264 (off) codec selection.</param>
    /// <param name="streamWarmup">Whether to stream warmup video on connection.</param>
    /// <param name="sessionTimeout">Maximum seconds between messages before timeout.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A connected <see cref="DIdRealtimeSession"/>.</returns>
    public static async Task<DIdRealtimeSession> ConnectAsync(
        DIdClient client,
        string agentId,
        CreateStreamRequestCompatibilityMode? compatibilityMode = null,
        bool? streamWarmup = null,
        double? sessionTimeout = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(agentId);

        // 1. Create stream — get SDP offer + ICE servers from D-ID
        var createResponse = await client.AgentsStreams.CreateStreamAsync(
            agentId: agentId,
            compatibilityMode: compatibilityMode,
            streamWarmup: streamWarmup,
            sessionTimeout: sessionTimeout,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var streamId = createResponse.Id;
        var sessionId = createResponse.SessionId;

        // 2. Configure ICE servers from D-ID response
        var iceServers = new List<RTCIceServer>();
        foreach (var server in createResponse.IceServers)
        {
            var urls = server.Urls.Value1 is { Count: > 0 }
                ? server.Urls.Value1.ToArray()
                : server.Urls.Value2 is { Length: > 0 }
                    ? [server.Urls.Value2]
                    : Array.Empty<string>();

            if (urls.Length > 0)
            {
                iceServers.Add(new RTCIceServer
                {
                    urls = string.Join(",", urls),
                    username = server.Username,
                    credential = server.Credential,
                });
            }
        }

        // 3. Create SIPSorcery peer connection
        var config = new RTCConfiguration
        {
            iceServers = iceServers,
        };
        var pc = new RTCPeerConnection(config);

        var session = new DIdRealtimeSession(client, pc, agentId, streamId, sessionId);

        // 4. Wire up reconstructed video frame receiver
        pc.OnVideoFrameReceived += (IPEndPoint _, uint timestamp, byte[] encodedData, VideoFormat format) =>
        {
            session._videoFrames.Writer.TryWrite(new VideoFrame(timestamp, encodedData, format));
        };

        // 5. Wire up reconstructed audio frame receiver
        pc.OnAudioFrameReceived += (EncodedAudioFrame frame) =>
        {
            session._audioFrames.Writer.TryWrite(new AudioFrame(
                frame.EncodedAudio, frame.AudioFormat, frame.DurationMilliSeconds));
        };

        // 6. Wire up data channel
        pc.ondatachannel += dc =>
        {
            session._dataChannel = dc;
            dc.onmessage += (_, _, data) =>
            {
                var msg = System.Text.Encoding.UTF8.GetString(data);
                session._dataMessages.Writer.TryWrite(msg);
            };
        };

        // 7. Set remote SDP offer from D-ID
        var remoteOffer = new RTCSessionDescriptionInit
        {
            type = RTCSdpType.offer,
            sdp = createResponse.Jsep.Sdp,
        };
        pc.setRemoteDescription(remoteOffer);

        // 8. Create SDP answer
        var answer = pc.createAnswer();
        await pc.setLocalDescription(answer).ConfigureAwait(false);

        // 9. Send SDP answer back to D-ID
        await client.AgentsStreams.StartConnectionAsync(
            agentId: agentId,
            streamId: streamId,
            answer: new StartConnectionRequestAnswer
            {
                Type = StartConnectionRequestAnswerType.Answer,
                Sdp = answer.sdp,
            },
            sessionId: sessionId,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        // 10. Send ICE candidates as they are gathered
        pc.onicecandidate += async candidate =>
        {
            try
            {
                var iceRequest = new AllOf<AnyOf<AddIceCandidateRequestVariant12, object>?, AddIceCandidateRequest2>
                {
                    Value1 = new AnyOf<AddIceCandidateRequestVariant12, object>?
                    (
                        new AnyOf<AddIceCandidateRequestVariant12, object>(
                            new AddIceCandidateRequestVariant12
                            {
                                Candidate = candidate.ToString() ?? string.Empty,
                                SdpMid = candidate.sdpMid ?? "0",
                                SdpMLineIndex = candidate.sdpMLineIndex,
                            })
                    ),
                    Value2 = new AddIceCandidateRequest2
                    {
                        SessionId = sessionId,
                    },
                };

                await client.AgentsStreams.AddIceCandidateAsync(
                    agentId: agentId,
                    streamId: streamId,
                    request: iceRequest).ConfigureAwait(false);
            }
            catch
            {
                // ICE candidate submission failures are non-fatal
            }
        };

        return session;
    }

    /// <summary>
    /// Sends a chat message to the D-ID agent during the stream.
    /// The agent will respond with avatar video/audio via the WebRTC stream.
    /// </summary>
    /// <param name="text">The message text to send.</param>
    /// <param name="chatId">The chat/conversation ID. Defaults to the stream ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async Task<ChatResponse2> SendMessageAsync(
        string text,
        string? chatId = null,
        CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        return await _client.AgentsStreams.ChatAsync(
            agentId: _agentId,
            chatId: chatId ?? _streamId,
            messages:
            [
                new ChatRequestMessage
                {
                    Role = ChatRequestMessageRole.User,
                    Content = text,
                    CreatedAt = DateTimeOffset.UtcNow.ToString("o"),
                },
            ],
            streamId: _streamId,
            sessionId: _sessionId,
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Receives reconstructed video frames from the avatar stream.
    /// Frames contain encoded H.264 or VP8 data depending on compatibility mode.
    /// </summary>
    public async IAsyncEnumerable<VideoFrame> ReceiveVideoFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        await foreach (var frame in _videoFrames.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return frame;
        }
    }

    /// <summary>
    /// Receives encoded audio frames from the avatar stream.
    /// </summary>
    public async IAsyncEnumerable<AudioFrame> ReceiveAudioFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        await foreach (var frame in _audioFrames.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return frame;
        }
    }

    /// <summary>
    /// Receives data channel messages from the avatar stream (e.g., "stream/ready").
    /// </summary>
    public async IAsyncEnumerable<string> ReceiveDataMessagesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        await foreach (var msg in _dataMessages.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return msg;
        }
    }

    /// <summary>
    /// Closes the WebRTC connection and releases resources.
    /// </summary>
    public async ValueTask DisposeAsync()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        _peerConnection.close();
        _peerConnection.Dispose();

        _videoFrames.Writer.TryComplete();
        _audioFrames.Writer.TryComplete();
        _dataMessages.Writer.TryComplete();

        await Task.CompletedTask.ConfigureAwait(false);
    }
}
