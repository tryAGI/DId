/*
order: 60
title: Clips
slug: clips

List clips (premium avatar videos).
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Clips()
    {
        //// List all clips (premium avatar videos) created in your account.
        //// Clips use premium presenters with higher-quality rendering compared to standard talks.
        using var client = GetAuthenticatedClient();

        var response = await client.ClipsPremiumAvatars.GetClipsAsync(
            limit: 10);

        response.Should().NotBeNull();
    }
}
