/*
order: 70
title: MEAI Tools
slug: meai-tools

Shows how to use D-ID as AIFunction tools with any IChatClient.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsCreateTalkTool()
    {
        //// Create a tool that generates talking avatar videos from text input.
        //// This tool can be added to any IChatClient's ChatOptions.Tools collection.
        using var client = GetAuthenticatedClient();

        var tool = client.AsCreateTalkTool();
        tool.Name.Should().Be("CreateTalkingAvatarVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetTalkTool()
    {
        //// Create a tool that retrieves the status and result URL of a talk.
        //// Use this to poll for completion after creating a talk.
        using var client = GetAuthenticatedClient();

        var tool = client.AsGetTalkTool();
        tool.Name.Should().Be("GetTalkStatus");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListTalksTool()
    {
        //// Create a tool that lists recent talking avatar videos.
        using var client = GetAuthenticatedClient();

        var tool = client.AsListTalksTool(limit: 5);
        tool.Name.Should().Be("ListTalkingAvatarVideos");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListAgentsTool()
    {
        //// Create a tool that lists AI agents configured in your D-ID account.
        using var client = GetAuthenticatedClient();

        var tool = client.AsListAgentsTool();
        tool.Name.Should().Be("ListAgents");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetCreditsTool()
    {
        //// Create a tool that retrieves the current credit balance.
        using var client = GetAuthenticatedClient();

        var tool = client.AsGetCreditsTool();
        tool.Name.Should().Be("GetCreditsBalance");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListVoicesTool()
    {
        //// Create a tool that lists available TTS voices for creating talks.
        //// Use this to find a voice ID before creating a talking avatar video.
        using var client = GetAuthenticatedClient();

        var tool = client.AsListVoicesTool();
        tool.Name.Should().Be("ListVoices");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
