/*
order: 80
title: Realtime Avatar Client
slug: realtime-avatar-client

Test the IRealtimeAvatarClient adapter for D-ID realtime sessions.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Avatar")]
    public async Task DIdRealtimeAvatarClient_Implements_IRealtimeAvatarClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DID_API_KEY") is { Length: > 0 } key
                ? key
                : throw new AssertInconclusiveException("DID_API_KEY environment variable is not found.");

        var agentId =
            Environment.GetEnvironmentVariable("DID_AGENT_ID") is { Length: > 0 } id
                ? id
                : throw new AssertInconclusiveException("DID_AGENT_ID environment variable is not found.");

        var client = new DIdClient(apiKey);

        //// Create and connect via the unified interface
        await using var avatar = await DIdRealtimeAvatarClient.ConnectAsync(
            client, agentId);

        //// Verify the adapter implements IRealtimeAvatarClient
        tryAGI.RealtimeAvatar.IRealtimeAvatarClient realtimeClient = avatar;
        realtimeClient.Should().NotBeNull();

        //// SendAudioAsync should throw NotSupportedException (D-ID is text-only)
        Func<Task> sendAudio = () => avatar.SendAudioAsync(ReadOnlyMemory<byte>.Empty);
        await sendAudio.Should().ThrowAsync<NotSupportedException>();

        //// Send text and receive at least one video frame
        await avatar.SendTextAsync("Hello, this is a test.");

        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var receivedVideo = false;
        var receivedAudio = false;

        var videoTask = Task.Run(async () =>
        {
            await foreach (var frame in avatar.ReceiveVideoFramesAsync(cts.Token))
            {
                frame.Data.Should().NotBeNull();
                frame.Data.Length.Should().BeGreaterThan(0);
                frame.Codec.Should().NotBeNullOrEmpty();
                receivedVideo = true;
                break; // Just verify we get at least one frame
            }
        }, cts.Token);

        var audioTask = Task.Run(async () =>
        {
            await foreach (var frame in avatar.ReceiveAudioFramesAsync(cts.Token))
            {
                frame.Data.Should().NotBeNull();
                frame.Data.Length.Should().BeGreaterThan(0);
                receivedAudio = true;
                break;
            }
        }, cts.Token);

        try
        {
            await Task.WhenAny(videoTask, audioTask, Task.Delay(TimeSpan.FromSeconds(30), cts.Token));
        }
        catch (OperationCanceledException) { }

        //// At least one type of frame should be received
        (receivedVideo || receivedAudio).Should().BeTrue(
            "Expected to receive at least one video or audio frame from D-ID avatar.");
    }
}
