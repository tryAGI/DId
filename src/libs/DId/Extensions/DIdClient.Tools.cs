#pragma warning disable CS3002 // Return type is not CLS-compliant
#pragma warning disable CA1054 // URI-like parameters should not be strings

using Microsoft.Extensions.AI;

namespace DId;

/// <summary>
/// Extensions for using DIdClient as MEAI tools with any IChatClient.
/// </summary>
public static class DIdToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps D-ID talk creation,
    /// suitable for use as a tool with any IChatClient.
    /// Creates a talking avatar video from text input using a source image.
    /// </summary>
    /// <param name="client">The D-ID client to use.</param>
    /// <param name="sourceUrl">
    /// The URL of the source image to animate (default: D-ID's sample avatar).
    /// Must be a .jpg or .png image URL.
    /// </param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateTalkTool(
        this DIdClient client,
        string? sourceUrl = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                var script = new CreateTalkRequestScriptVariant12
                {
                    Type = CreateTalkRequestScriptVariant1Type2.Text,
                    Input = text,
                };

                var response = await client.TalksStandardAvatars.CreateTalkAsync(
                    script: script,
                    sourceUrl: sourceUrl,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTalkResponse(response);
            },
            name: "CreateTalkingAvatarVideo",
            description: "Creates a talking avatar video from text. The avatar will speak the provided text. Returns the talk ID and status for polling.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps D-ID talk retrieval,
    /// suitable for use as a tool with any IChatClient.
    /// Gets the status and result URL of a previously created talk.
    /// </summary>
    /// <param name="client">The D-ID client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetTalkTool(this DIdClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string talkId, CancellationToken cancellationToken) =>
            {
                var response = await client.TalksStandardAvatars.GetTalkAsync(
                    id: talkId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatGetTalkResponse(response);
            },
            name: "GetTalkStatus",
            description: "Gets the status and result URL of a D-ID talking avatar video by its ID. Use this to check if a previously created talk has completed processing and to retrieve the video URL.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps D-ID talk listing,
    /// suitable for use as a tool with any IChatClient.
    /// Lists recent talking avatar videos.
    /// </summary>
    /// <param name="client">The D-ID client to use.</param>
    /// <param name="limit">Maximum number of talks to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListTalksTool(
        this DIdClient client,
        int limit = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.TalksStandardAvatars.GetTalksAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListTalksResponse(response);
            },
            name: "ListTalkingAvatarVideos",
            description: "Lists recent D-ID talking avatar videos with their IDs, statuses, and result URLs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps D-ID agent listing,
    /// suitable for use as a tool with any IChatClient.
    /// Lists AI agents configured in the account.
    /// </summary>
    /// <param name="client">The D-ID client to use.</param>
    /// <param name="limit">Maximum number of agents to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListAgentsTool(
        this DIdClient client,
        int limit = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Agents.ListMyAgentsAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListAgentsResponse(response);
            },
            name: "ListAgents",
            description: "Lists D-ID AI agents configured in the account. Agents are interactive avatars powered by LLMs that can hold conversations.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps D-ID credits retrieval,
    /// suitable for use as a tool with any IChatClient.
    /// Gets the current credit balance.
    /// </summary>
    /// <param name="client">The D-ID client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetCreditsTool(this DIdClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Credits.GetCreditsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreditsResponse(response);
            },
            name: "GetCreditsBalance",
            description: "Gets the current D-ID account credit balance including remaining and total credits.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps D-ID voice listing,
    /// suitable for use as a tool with any IChatClient.
    /// Lists available text-to-speech voices.
    /// </summary>
    /// <param name="client">The D-ID client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListVoicesTool(this DIdClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Voices.VoicesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVoicesResponse(response);
            },
            name: "ListVoices",
            description: "Lists available D-ID text-to-speech voices with their IDs, names, genders, providers, and supported languages. Use this to find a voice ID for creating talking avatar videos.");
    }

    private static string FormatCreateTalkResponse(CreateTalkResponse response)
    {
        var parts = new List<string>
        {
            $"Talk ID: {response.Id}",
            $"Status: {response.Status.ToValueString()}",
            $"Created At: {response.CreatedAt}",
        };

        return string.Join("\n", parts);
    }

    private static string FormatGetTalkResponse(GetTalkResponse response)
    {
        var parts = new List<string>
        {
            $"Talk ID: {response.Id}",
            $"Status: {response.Status.ToValueString()}",
            $"Created At: {response.CreatedAt}",
        };

        if (!string.IsNullOrWhiteSpace(response.ResultUrl))
        {
            parts.Add($"Result URL: {response.ResultUrl}");
        }

        if (!string.IsNullOrWhiteSpace(response.AudioUrl))
        {
            parts.Add($"Audio URL: {response.AudioUrl}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatListTalksResponse(GetTalksResponse response)
    {
        var parts = new List<string>();

        if (response.Talks is { Count: > 0 })
        {
            parts.Add("Talks:");
            foreach (var talk in response.Talks)
            {
                var entry = $"- [{talk.Id}] Status: {talk.Status.ToValueString()}, Created: {talk.CreatedAt}";
                if (!string.IsNullOrWhiteSpace(talk.ResultUrl))
                {
                    entry += $", URL: {talk.ResultUrl}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No talks found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatListAgentsResponse(ListMyAgentsResponse response)
    {
        var parts = new List<string>();

        if (response.Agents is { Count: > 0 })
        {
            parts.Add("Agents:");
            foreach (var agent in response.Agents)
            {
                var id = agent.Value1?.Id;
                var description = agent.Value1?.PreviewDescription;

                var entry = $"- [{id}]";
                if (!string.IsNullOrWhiteSpace(description))
                {
                    entry += $": {description}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No agents found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatCreditsResponse(GetCreditsResponse response)
    {
        var parts = new List<string>
        {
            $"Remaining: {response.Remaining}",
            $"Total: {response.Total}",
        };

        if (response.Credits is { Count: > 0 })
        {
            parts.Add("Credit items:");
            foreach (var credit in response.Credits)
            {
                parts.Add($"- Remaining: {credit.Remaining}, Total: {credit.Total}, Expires: {credit.ExpireAt}");
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatVoicesResponse(IList<VoicesResponseItem> voices)
    {
        var parts = new List<string>();

        if (voices is { Count: > 0 })
        {
            parts.Add("Voices:");
            foreach (var voice in voices)
            {
                var languages = voice.Languages is { Count: > 0 }
                    ? string.Join(", ", voice.Languages.Select(l => l.Locale ?? string.Empty).Where(l => l.Length > 0))
                    : string.Empty;

                var entry = $"- {voice.Name} (ID: {voice.Id}, Gender: {voice.Gender}, Provider: {voice.Provider.ToValueString()})";
                if (!string.IsNullOrWhiteSpace(languages))
                {
                    entry += $" [Languages: {languages}]";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No voices found.");
        }

        return string.Join("\n", parts);
    }
}
