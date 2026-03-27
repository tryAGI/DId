/*
order: 40
title: Presenters
slug: presenters

List available avatar presenters.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Presenters()
    {
        //// List all available presenters (avatar source images) for generating clips.
        //// Presenters represent the visual faces used in premium avatar videos.
        using var client = GetAuthenticatedClient();

        var response = await client.ClipsPremiumAvatars.GetPresentersAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Presenters.Should().NotBeNull();
    }
}
