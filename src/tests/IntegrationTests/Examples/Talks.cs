/*
order: 50
title: Talks
slug: talks

List talks (standard avatar videos).
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Talks()
    {
        //// List all talks (standard avatar videos) created in your account.
        //// Talks are generated videos where a photo-based avatar speaks provided text or audio.
        using var client = GetAuthenticatedClient();

        var response = await client.TalksStandardAvatars.GetTalksAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Talks.Should().NotBeNull();
    }
}
