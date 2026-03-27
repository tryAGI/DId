/*
order: 20
title: Voices
slug: voices

List available text-to-speech voices.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Voices()
    {
        //// List all available TTS voices for generating talking avatar videos.
        //// Each voice includes metadata such as provider, gender, language, and access level.
        using var client = GetAuthenticatedClient();

        var voices = await client.Voices.VoicesAsync();

        voices.Should().NotBeNull();
        voices.Should().NotBeEmpty();

        var first = voices[0];
        first.Id.Should().NotBeNullOrEmpty();
        first.Name.Should().NotBeNullOrEmpty();
        first.Gender.Should().NotBeNullOrEmpty();
        first.Languages.Should().NotBeNull();
    }
}
