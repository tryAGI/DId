# CLAUDE.md — D-ID SDK

## Overview

Auto-generated C# SDK for [D-ID](https://www.d-id.com/) — talking avatar video generation, AI agents, real-time streaming conversations, animations, voice listing, knowledge bases, and credit management.
**No stable public OpenAPI spec exists** — `openapi.json` was extracted from Readme.io embedded docs and assembled from 4 merged specs (videos, realtime, resources, legacy). Schema names were normalized (42 names with dots/hyphens fixed).

## Build & Test

```bash
dotnet build DId.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (Base64-encoded API key):

```csharp
var client = new DIdClient(apiKey); // DID_API_KEY env var
```

## Key Files

- `src/libs/DId/openapi.json` — **Locally maintained** merged OpenAPI spec (no stable public URL)
- `src/libs/DId/generate.sh` — Fixes auth (injects bearer securityScheme, removes per-operation security), runs autosdk
- `src/libs/DId/Generated/` — **Never edit** — auto-generated code (~8k files)
- `src/libs/DId/Extensions/DIdClient.Tools.cs` — MEAI `AIFunction` tools (CreateTalk, GetTalk, ListTalks, ListAgents, GetCredits, ListVoices)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- **No stable public OpenAPI spec** — extracted from `docs.d-id.com/reference` embedded data
- 4 specs merged into one: videos, realtime, resources, legacy
- 42 schema names normalized (dots/hyphens replaced)
- `generate.sh` injects `bearer` security scheme and removes per-operation `security` blocks (top-level bearer covers all endpoints)
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

D-ID API has tagged operations generating sub-clients:
- `client.Agents.*` — AI agent management (CRUD, webhooks)
- `client.AgentsStreams.*` — Real-time streaming (WebRTC ICE, streams, video streams, chat)
- `client.TalksStandardAvatars.*` — Create/get/list/delete talking avatar videos
- `client.ClipsPremiumAvatars.*` — Premium avatar clip creation
- `client.ScenesExpressAvatars.*` — Express avatar scene creation
- `client.V4Avatars.*` — V4 expressive avatar endpoints
- `client.Knowledge.*` — Knowledge base management for agents
- `client.Voices.*` — List available TTS voices
- `client.Images.*` — Source image upload and management
- `client.Audios.*` — Audio resource management
- `client.Credits.*` — Credit balance and usage
- `client.VideoTranslate.*` — Video translation
- `client.Settings.*` — Account settings
- `client.Secrets.*` — Secret management
- `client.Consents.*` — Consent management
- `client.ClientKeys.*` — Client key management
- `client.ChatsExport.*` — Chat export
- `client.Ratings.*` — Conversation ratings

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCreateTalkTool(sourceUrl?)` — Create a talking avatar video from text
- `AsGetTalkTool()` — Get talk status and result URL by ID
- `AsListTalksTool(limit)` — List recent talking avatar videos
- `AsListAgentsTool(limit)` — List AI agents
- `AsGetCreditsTool()` — Get credit balance
- `AsListVoicesTool()` — List available TTS voices
