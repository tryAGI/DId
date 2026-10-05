namespace DId.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static async Task<string> GetAgentIdAsync(DIdClient client)
    {
        if (Environment.GetEnvironmentVariable("DID_AGENT_ID") is { Length: > 0 } configuredAgentId)
        {
            return configuredAgentId;
        }

        var response = await client.Agents.ListMyAgentsAsync(limit: 10);
        if (response.Agents.Count == 0 || response.Agents[0].Value1 is not { } agent)
        {
            throw new AssertInconclusiveException("DID_AGENT_ID is required when the account has no agents.");
        }

        return agent.Id;
    }

    private static DIdClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DID_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DID_API_KEY environment variable is not found.");

        var client = new DIdClient(apiKey);
        
        return client;
    }
}
