# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The D-ID SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models the ability to create talking avatar videos, manage agents, check credits, and browse voices.

## Installation

```bash
dotnet add package DId
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsCreateTalkTool(sourceUrl)` | `CreateTalkingAvatarVideo` | Creates a talking avatar video from text |
| `AsGetTalkTool()` | `GetTalkStatus` | Gets the status and result URL of a talk |
| `AsListTalksTool(limit)` | `ListTalkingAvatarVideos` | Lists recent talking avatar videos |
| `AsListAgentsTool(limit)` | `ListAgents` | Lists AI agents in the account |
| `AsGetCreditsTool()` | `GetCreditsBalance` | Gets the current credit balance |
| `AsListVoicesTool()` | `ListVoices` | Lists available TTS voices |

## Usage

```csharp
using DId;
using Microsoft.Extensions.AI;

var did = new DIdClient(apiKey: Environment.GetEnvironmentVariable("DID_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        did.AsCreateTalkTool(),
        did.AsGetTalkTool(),
        did.AsListVoicesTool(),
        did.AsGetCreditsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Create a talking avatar video that says 'Hello from D-ID!'"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

### AsCreateTalkTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `sourceUrl` | `string?` | `null` | URL of the source image to animate. If null, uses D-ID's default avatar. |

The tool accepts a `text` parameter from the AI model containing the text the avatar should speak.

### AsGetTalkTool

No configurable parameters. The AI model provides the `talkId` to look up.

### AsListTalksTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `limit` | `int` | `10` | Maximum number of talks to return |

### AsListAgentsTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `limit` | `int` | `10` | Maximum number of agents to return |

### AsGetCreditsTool

No configurable parameters. Returns remaining and total credits.

### AsListVoicesTool

No configurable parameters. Returns all available voices with IDs, names, genders, providers, and languages.
