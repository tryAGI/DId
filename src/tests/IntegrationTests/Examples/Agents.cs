/*
order: 30
title: Agents
slug: agents

List AI agents configured for your account.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Agents()
    {
        //// List all AI agents associated with your account.
        //// Agents are interactive avatars powered by LLMs that can hold conversations.
        using var client = GetAuthenticatedClient();

        var response = await client.Agents.ListMyAgentsAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Agents.Should().NotBeNull();
    }
}
