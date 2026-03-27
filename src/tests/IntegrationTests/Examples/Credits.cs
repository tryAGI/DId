/*
order: 10
title: Credits
slug: credits

Get the account's credit balance information.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Credits()
    {
        //// Retrieve the current credit balance for your D-ID account.
        //// The response includes the total credits allocated and remaining credits.
        using var client = GetAuthenticatedClient();

        var response = await client.Credits.GetCreditsAsync();

        response.Should().NotBeNull();
        response.Credits.Should().NotBeNull();
        response.Total.Should().BeGreaterThanOrEqualTo(0);
        response.Remaining.Should().BeGreaterThanOrEqualTo(0);
        response.Remaining.Should().BeLessThanOrEqualTo(response.Total);
    }
}
