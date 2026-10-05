#pragma warning disable CS3001 // Argument type is not CLS-compliant
#pragma warning disable CS3002 // Return type is not CLS-compliant
#pragma warning disable CS3003 // Type is not CLS-compliant
#pragma warning disable CA1819 // Properties should not return arrays
#pragma warning disable CA1031 // Do not catch general exception types
#pragma warning disable CA2000 // Peer ownership is transferred to the returned session

using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using tryAGI.WebRTC;

namespace DId;

/// <summary>
/// Represents a received video frame from the D-ID avatar stream.
/// </summary>
/// <param name="Timestamp">The RTP timestamp of the frame.</param>
/// <param name="EncodedData">The encoded video frame payload (H.264 or VP8).</param>
/// <param name="Format">The video format/codec of the frame.</param>
public sealed record VideoFrame(uint Timestamp, byte[] EncodedData, string Format);

/// <summary>
/// Represents a received audio frame from the D-ID avatar stream.
/// </summary>
/// <param name="EncodedData">The encoded audio payload.</param>
/// <param name="Format">The audio format/codec of the frame.</param>
/// <param name="DurationMs">Duration of the audio frame in milliseconds.</param>
public sealed record AudioFrame(byte[] EncodedData, string Format, uint DurationMs);

/// <summary>
/// Represents a realtime WebRTC session with a D-ID agent.
/// Handles SDP/ICE negotiation using tryAGI.WebRTC and the D-ID REST signaling endpoints.
/// </summary>
public sealed class DIdRealtimeSession : IAsyncDisposable
{
    private readonly DIdClient _client;
    private readonly PeerConnection _peerConnection;
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
    private readonly CancellationTokenSource _lifetime = new();
    private bool _disposed;

    private DIdRealtimeSession(
        DIdClient client,
        PeerConnection peerConnection,
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
    public PeerConnectionState ConnectionState => _peerConnection.State;

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
            compatibilityMode: compatibilityMode ?? CreateStreamRequestCompatibilityMode.Off,
            streamWarmup: streamWarmup,
            sessionTimeout: sessionTimeout,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var streamId = createResponse.Id;
        var sessionId = createResponse.SessionId;

        // 2. Create an answerer on the interface used for Internet traffic.
        using var routeProbe = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        routeProbe.Connect(new IPEndPoint(IPAddress.Parse("1.1.1.1"), 53));
        var localAddress = ((IPEndPoint)routeProbe.LocalEndPoint!).Address;
        var pc = new PeerConnection(new PeerConnectionOptions
        {
            LocalEndPoint = new IPEndPoint(localAddress, 0),
            AudioDirection = SdpDirection.ReceiveOnly,
            VideoDirection = SdpDirection.ReceiveOnly,
            VideoCodecs =
            [
                new()
                {
                    Codec = VideoCodec.H264,
                    PayloadType = 102,
                    // D-ID omits H264 fmtp in its offer, which means RFC6184 defaults:
                    // Baseline Level 1, packetization-mode 0, no level asymmetry.
                    H264ProfileLevelId = "42000a",
                    H264PacketizationMode = 0,
                    H264LevelAsymmetryAllowed = false,
                },
            ],
        });

        var session = new DIdRealtimeSession(client, pc, agentId, streamId, sessionId);

        _ = PumpMediaAsync(session, pc, session._lifetime.Token);
        _ = PumpDataChannelsAsync(session, pc, session._lifetime.Token);

        // 3. Accept D-ID's offer. H264 is requested explicitly for deterministic output.
        _ = pc.CreateAnswer(createResponse.Offer.Sdp);

        // 4. Publish the initial answer before gathering, matching browser trickle ICE flow.
        await client.AgentsStreams.StartConnectionAsync(
            agentId: agentId,
            streamId: streamId,
            answer: new StartConnectionRequestAnswer
            {
                Type = StartConnectionRequestAnswerType.Answer,
                Sdp = pc.LocalDescription!,
            },
            sessionId: sessionId,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var resolution = new IceServerResolutionOptions
        {
            EndpointFilter = endpoint => IsAllowedIceEndpoint(endpoint.Address),
            MaximumAddresses = 2,
            ResolveTimeout = TimeSpan.FromSeconds(2),
            GatherTimeout = TimeSpan.FromSeconds(5),
        };
        foreach (var server in createResponse.IceServers)
        {
            var urls = server.Urls.Value1 is { Count: > 0 }
                ? server.Urls.Value1
                : server.Urls.Value2 is { Length: > 0 }
                    ? [server.Urls.Value2]
                    : [];

            foreach (var url in urls)
            {
                if (pc.GetLocalCandidates().Count >= 4)
                {
                    break;
                }

                try
                {
                    var iceServer = IceServerUri.Parse(url);
                    if (iceServer.IsTurn)
                    {
                        if (iceServer.Transport != TurnServerTransport.Udp ||
                            string.IsNullOrWhiteSpace(server.Username) || string.IsNullOrWhiteSpace(server.Credential))
                        {
                            continue;
                        }

                        await pc.GatherRelayCandidateAsync(
                            iceServer,
                            new TurnCredentials(server.Username, server.Credential),
                            resolution,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        await pc.GatherServerReflexiveCandidateAsync(
                            iceServer,
                            resolution,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (Exception) when (!cancellationToken.IsCancellationRequested)
                {
                    // D-ID can return redundant ICE servers; continue with another admitted path.
                }
            }
        }
        pc.CompleteGathering();

        // 5. Mirror the complete local candidate set through D-ID's trickle endpoint.
        foreach (var candidate in pc.GetLocalCandidates())
        {
            await SubmitIceCandidateAsync(
                client, agentId, streamId, sessionId, candidate, cancellationToken).ConfigureAwait(false);
        }

        try
        {
            // ConnectAsync returns only after the negotiated secure transports are ready.
            await pc.ConnectAsync(cancellationToken).ConfigureAwait(false);
            return session;
        }
        catch
        {
            await session.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    private static async Task SubmitIceCandidateAsync(
        DIdClient client,
        string agentId,
        string streamId,
        string? sessionId,
        tryAGI.WebRTC.IceCandidate candidate,
        CancellationToken cancellationToken)
    {
        var iceRequest = new AllOf<AnyOf<AddIceCandidateRequestVariant12, object>?, AddIceCandidateRequest2>
        {
            Value1 = new AnyOf<AddIceCandidateRequestVariant12, object>?
            (
                new AnyOf<AddIceCandidateRequestVariant12, object>(
                    new AddIceCandidateRequestVariant12
                    {
                        Candidate = "candidate:" + candidate.ToSdpAttribute(),
                        SdpMid = "0",
                        SdpMLineIndex = 0,
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
            request: iceRequest,
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    private static async Task PumpMediaAsync(
        DIdRealtimeSession session,
        PeerConnection peer,
        CancellationToken cancellationToken)
    {
        var audio = Task.Run(async () =>
        {
            await foreach (var packet in peer.ReceiveAudioAsync(cancellationToken).ConfigureAwait(false))
            {
                session._audioFrames.Writer.TryWrite(new AudioFrame(packet.Payload, "OPUS", 20));
            }
        }, cancellationToken);
        var video = Task.Run(async () =>
        {
            await foreach (var frame in peer.ReceiveVideoAsync(cancellationToken).ConfigureAwait(false))
            {
                session._videoFrames.Writer.TryWrite(new VideoFrame(
                    frame.Timestamp, frame.Payload, frame.Codec.ToString().ToUpperInvariant()));
            }
        }, cancellationToken);
        await Task.WhenAll(audio, video).ConfigureAwait(false);
    }

    private static async Task PumpDataChannelsAsync(
        DIdRealtimeSession session,
        PeerConnection peer,
        CancellationToken cancellationToken)
    {
        await foreach (var channel in peer.AcceptDataChannelsAsync(cancellationToken).ConfigureAwait(false))
        {
            await using (channel.ConfigureAwait(false))
            {
                await foreach (var message in channel.ReceiveMessagesAsync(cancellationToken).ConfigureAwait(false))
                {
                    if (message.Kind == DataChannelMessageKind.Text)
                    {
                        session._dataMessages.Writer.TryWrite(message.GetText());
                    }
                }
            }
        }
    }

    private static bool IsAllowedIceEndpoint(IPAddress address)
    {
        if (IPAddress.IsLoopback(address) || address.Equals(IPAddress.Any) || address.Equals(IPAddress.IPv6Any) ||
            address.IsIPv6LinkLocal || address.IsIPv6Multicast || address.IsIPv6SiteLocal)
        {
            return false;
        }

        if (address.AddressFamily != AddressFamily.InterNetwork)
        {
            return true;
        }

        var bytes = address.GetAddressBytes();
        return bytes[0] is not (0 or 10 or 127) &&
            !(bytes[0] == 169 && bytes[1] == 254) &&
            !(bytes[0] == 172 && bytes[1] is >= 16 and <= 31) &&
            !(bytes[0] == 192 && bytes[1] == 168) &&
            bytes[0] < 224;
    }

    /// <summary>
    /// Streams the supplied text verbatim through the agent presenter.
    /// </summary>
    public async Task SpeakAsync(string text, CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        await _client.AgentsStreams.CreateVideoStreamAsync(
            agentId: _agentId,
            streamId: _streamId,
            script: new CreateVideoStreamRequestScriptText2
            {
                Type = CreateVideoStreamRequestScriptTextType2.Text,
                Input = text,
            },
            sessionId: _sessionId,
            cancellationToken: cancellationToken).ConfigureAwait(false);
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

        await _lifetime.CancelAsync().ConfigureAwait(false);
        await _peerConnection.DisposeAsync().ConfigureAwait(false);
        _lifetime.Dispose();

        _videoFrames.Writer.TryComplete();
        _audioFrames.Writer.TryComplete();
        _dataMessages.Writer.TryComplete();

    }
}
