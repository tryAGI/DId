/*
order: 70
title: Realtime Session
slug: realtime-session

Connect to a D-ID agent via a realtime WebRTC session.
*/

namespace DId.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RealtimeSession()
    {
        //// Connect to a D-ID agent using a realtime WebRTC session.
        //// This creates a live streaming connection via SIPSorcery's RTCPeerConnection
        //// and the D-ID REST signaling endpoints (CreateStream, StartConnection, AddIceCandidate).
        using var client = GetAuthenticatedClient();

        var agentId =
            Environment.GetEnvironmentVariable("DID_AGENT_ID") is { Length: > 0 } agentIdValue
                ? agentIdValue
                : throw new AssertInconclusiveException("DID_AGENT_ID environment variable is not found.");

        //// Create a realtime session with the agent. The ConnectAsync method handles
        //// the full SDP/ICE negotiation — creating a stream, exchanging SDP offer/answer,
        //// and forwarding ICE candidates.
        await using var session = await DIdRealtimeSession.ConnectAsync(
            client: client,
            agentId: agentId);

        //// Verify the session was established with valid identifiers.
        session.StreamId.Should().NotBeNullOrEmpty();
        session.SessionId.Should().NotBeNull();
    }
}
