using System.Net;
using System.Text;
using DId;

namespace DId.IntegrationTests;

[TestClass]
public class SharedJsonMetadataTests
{
    [TestMethod]
    public async Task OfflineContracts()
    {
        using var http = new HttpClient(new CreditsHandler());
        using var client = new DIdClient("fixture-user", "fixture-password", httpClient: http);
        var credits = await client.Credits.GetCreditsAsync();
        if (credits.Total != 10 || credits.Remaining != 7 || credits.Credits.Count != 0)
            throw new InvalidOperationException("Credit response metadata changed.");
        var roundtrip = GetCreditsResponse.FromJson(credits.ToJson());
        if (roundtrip?.Remaining != 7) throw new InvalidOperationException("Model helper roundtrip failed.");
        var script = TextScript.FromJson("""{"type":"text","input":"offline","provider":{"type":"elevenlabs","voice_id":"fixture"}}""")!;
        if (script.Input != "offline" || script.Provider?.Value2?.VoiceId != "fixture")
            throw new InvalidOperationException("Nested provider union metadata changed.");
        if (TextScript.FromJson(script.ToJson())?.Provider?.Value2?.VoiceId != "fixture")
            throw new InvalidOperationException("Nested provider union roundtrip failed.");
        var rejected = false;
        try { TextScript.FromJson("""{"type":"text","provider":{"type":"unknown","voice_id":"fixture"}}"""); }
        catch (System.Text.Json.JsonException) { rejected = true; }
        if (!rejected) throw new InvalidOperationException("Unknown provider literal accepted.");
    }

    private sealed class CreditsHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.RequestUri?.AbsolutePath != "/credits" || request.Method != HttpMethod.Get ||
                request.Headers.Authorization?.Scheme != "Basic" ||
                request.Headers.Authorization.Parameter != Convert.ToBase64String(Encoding.UTF8.GetBytes("fixture-user:fixture-password")))
                throw new InvalidOperationException("Offline Basic request contract changed.");
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""{"credits":[],"remaining":7,"total":10}""", Encoding.UTF8, "application/json"),
            });
        }
    }
}
