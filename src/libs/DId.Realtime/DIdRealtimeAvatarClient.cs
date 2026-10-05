#pragma warning disable CS3001 // Argument type is not CLS-compliant
#pragma warning disable CA1819 // Properties should not return arrays
#pragma warning disable CA2000 // Dispose objects before losing scope — ownership is transferred to the adapter

using System.Runtime.CompilerServices;
using tryAGI.RealtimeAvatar;
using tryAGI.WebRTC;

namespace DId;

/// <summary>
/// Adapter that wraps <see cref="DIdRealtimeSession"/> to implement <see cref="IRealtimeAvatarClient"/>.
/// D-ID provides full WebRTC streaming with video and audio frames from the avatar,
/// driven by text input rendered directly through the presenter's TTS + lip-synced video.
/// </summary>
public sealed class DIdRealtimeAvatarClient : IRealtimeAvatarClient
{
    private readonly DIdRealtimeSession _session;

    /// <summary>
    /// Creates a new adapter wrapping an existing <see cref="DIdRealtimeSession"/>.
    /// </summary>
    /// <param name="session">A connected D-ID realtime session.</param>
    public DIdRealtimeAvatarClient(DIdRealtimeSession session)
    {
        ArgumentNullException.ThrowIfNull(session);
        _session = session;
    }

    /// <summary>
    /// Creates and connects a new D-ID realtime session, returning it wrapped as an <see cref="IRealtimeAvatarClient"/>.
    /// </summary>
    /// <param name="client">The authenticated D-ID client.</param>
    /// <param name="agentId">The agent ID to stream with.</param>
    /// <param name="compatibilityMode">VP8 (on) or H264 (off) codec selection.</param>
    /// <param name="streamWarmup">Whether to stream warmup video on connection.</param>
    /// <param name="sessionTimeout">Maximum seconds between messages before timeout.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A connected <see cref="DIdRealtimeAvatarClient"/>.</returns>
    public static async Task<DIdRealtimeAvatarClient> ConnectAsync(
        DIdClient client,
        string agentId,
        CreateStreamRequestCompatibilityMode? compatibilityMode = null,
        bool? streamWarmup = null,
        double? sessionTimeout = null,
        CancellationToken cancellationToken = default)
    {
        var session = await DIdRealtimeSession.ConnectAsync(
            client, agentId, compatibilityMode, streamWarmup, sessionTimeout, cancellationToken)
            .ConfigureAwait(false);

        try
        {
            return new DIdRealtimeAvatarClient(session);
        }
        catch
        {
            await session.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    /// <inheritdoc />
    public bool IsConnected => _session.ConnectionState == PeerConnectionState.Connected;

    /// <inheritdoc />
    public async Task SendTextAsync(string text, CancellationToken cancellationToken = default)
    {
        await _session.SpeakAsync(text, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public Task SendAudioAsync(ReadOnlyMemory<byte> pcm16Audio, CancellationToken cancellationToken = default)
    {
        // D-ID realtime sessions are text-driven: the agent uses built-in TTS to generate speech.
        // Direct audio input is not supported by the D-ID streaming API.
        throw new NotSupportedException(
            "D-ID realtime sessions use text input only. Use SendTextAsync instead.");
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<AvatarVideoFrame> ReceiveVideoFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        await foreach (var frame in _session.ReceiveVideoFramesAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return new AvatarVideoFrame(
                Data: frame.EncodedData,
                Codec: frame.Format,
                Timestamp: frame.Timestamp);
        }
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<AvatarAudioFrame> ReceiveAudioFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        await foreach (var frame in _session.ReceiveAudioFramesAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return new AvatarAudioFrame(
                Data: frame.EncodedData,
                Codec: frame.Format,
                DurationMs: frame.DurationMs);
        }
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        await _session.DisposeAsync().ConfigureAwait(false);
    }
}
