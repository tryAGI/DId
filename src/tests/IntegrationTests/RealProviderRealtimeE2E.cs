namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Avatar")]
    public async Task DIdRealtimeAvatarClient_RealProvider_WarmupMedia()
    {
        using var client = GetAuthenticatedClient();
        const string sourceUrl = "https://create-images-results.d-id.com/DefaultPresenters/Noelle_f/image.png";

        var created = await client.Agents.CreateAsync(new CreateRequest2
        {
            PreviewName = "tryAGI SDK realtime E2E",
            Presenter = new CreateRequestPresenterPhotoAvatar
            {
                Type = CreateRequestPresenterPhotoAvatarType.Talk,
                SourceUrl = sourceUrl,
                Thumbnail = sourceUrl,
                Voice = new CreateRequestPresenterPhotoAvatarVoiceMicrosoft
                {
                    Type = CreateRequestPresenterPhotoAvatarVoiceMicrosoftType.Microsoft,
                    VoiceId = "en-US-JennyNeural",
                },
            },
        });
        var agentId = created.Value1?.Id
            ?? throw new InvalidOperationException("D-ID did not return the temporary agent ID.");

        try
        {
            await using var avatar = await DIdRealtimeAvatarClient.ConnectAsync(
                client,
                agentId,
                streamWarmup: true);
            avatar.IsConnected.Should().BeTrue();

            using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            var video = await avatar.ReceiveVideoFramesAsync(timeout.Token).FirstAsync(timeout.Token);
            video.Data.Should().NotBeEmpty();
            video.Codec.Should().Be("H264");

            var audio = await avatar.ReceiveAudioFramesAsync(timeout.Token).FirstAsync(timeout.Token);
            audio.Data.Should().NotBeEmpty();
            audio.Codec.Should().Be("OPUS");
        }
        finally
        {
            await client.Agents.DeleteAsync(agentId);
        }
    }
}
