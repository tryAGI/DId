namespace DId.IntegrationTests;

[TestClass]
public partial class Tests
{
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
