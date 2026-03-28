#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained, extracted from https://docs.d-id.com/reference/ (multiple specs merged)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# D-ID uses multiple API specs (realtime, videos, resources, legacy) that are
# merged into a single openapi.json file stored locally in this directory.
# The specs are extracted from https://docs.d-id.com/reference/ embedded data.

# Auth: --security-scheme overrides the spec's per-operation security with top-level HTTP bearer.
autosdk generate openapi.json \
  --namespace DId \
  --clientClassName DIdClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
