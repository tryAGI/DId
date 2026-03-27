# Authentication

The D-ID API uses Bearer token authentication. Your API key must be Base64-encoded
and passed as a Bearer token in the `Authorization` header.

## Getting an API Key

1. Sign up at [studio.d-id.com](https://studio.d-id.com/)
2. Navigate to **Settings** > **API Keys**
3. Create a new API key

## Using the SDK

Pass your API key directly to the `DIdClient` constructor. The SDK handles
the Bearer token header automatically:

```csharp
using DId;

var client = new DIdClient(apiKey: "your-api-key");
```

## Environment Variable Pattern

For production use, store your API key in an environment variable:

```csharp
using DId;

var apiKey =
    Environment.GetEnvironmentVariable("DID_API_KEY") is { Length: > 0 } value
        ? value
        : throw new InvalidOperationException("DID_API_KEY environment variable is not set.");

var client = new DIdClient(apiKey: apiKey);
```

## Base64 Encoding

D-ID expects the API key to be Base64-encoded in the `Authorization` header.
If your key is not already Base64-encoded, encode it before passing it to the client:

```csharp
using System;
using DId;

var rawKey = "your-raw-api-key";
var base64Key = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(rawKey));

var client = new DIdClient(apiKey: base64Key);
```

## Basic Authentication (Alternative)

D-ID also supports HTTP Basic authentication for some endpoints. The SDK is
configured with Bearer authentication by default, which is the recommended approach.
