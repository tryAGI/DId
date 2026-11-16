#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained, extracted from https://docs.d-id.com/reference/ (multiple specs merged)
if [[ -n "${AUTOSDK_EXECUTABLE:-}" ]]; then
  autosdk() { "$AUTOSDK_EXECUTABLE" "$@"; }
else
  install_autosdk_cli
fi
rm -rf Generated

# D-ID uses multiple API specs (realtime, videos, resources, legacy) that are
# merged into a single openapi.json file stored locally in this directory.
# The specs are extracted from https://docs.d-id.com/reference/ embedded data.

# The upstream extraction deduplicates by appending an index, so the merged document declares the
# same shape several times: JsonError through JsonError4, plus TextScript3 and AudioScript3. These
# are not AutoSDK name collisions - the names genuinely differ, so nothing merges them and the SDK
# ships five identical error types.
#
# All six are orphans: measured on the document, not one of them is the target of a $ref anywhere.
# AutoSDK emits a type per component regardless of reachability, so collapsing them removes dead
# public types and changes no operation's wire contract. The repointing below is therefore a
# safeguard for a future document that does reference them, not something today's spec needs.
#
# The groups are listed by name on purpose. Merging components merely because they share a shape is
# unsafe in general: measured across the workspace, 3506 component pairs share a shape and almost
# all are deliberately distinct (Anthropic's APIError and BetaAPIError, two surfaces meant to
# diverge). So each group below is verified identical before anything is removed, and a spec refresh
# that makes them differ fails here instead of silently merging two different schemas.
python3 -c "
import json, sys

GROUPS = [
    ('JsonError', ['JsonError1', 'JsonError2', 'JsonError3', 'JsonError4']),
    ('TextScript', ['TextScript3']),
    ('AudioScript', ['AudioScript3']),
]

def comparable(schema):
    # x-readme-ref-name is ReadMe's own bookkeeping: it records the name ReadMe assigned, so the
    # copies differ in it by construction and it is the very thing that proves they are one schema
    # ReadMe numbered. AutoSDK does not read it. 'title' is dropped too because only the survivors
    # carry one (TextScript has title 'Text', TextScript3 has none), so the survivor is the richer
    # of the two. Everything else must match exactly.
    return json.dumps(
        {k: v for k, v in schema.items() if k not in ('x-readme-ref-name', 'title')},
        sort_keys=True,
    )

with open('openapi.json') as f:
    spec = json.load(f)

schemas = spec.get('components', {}).get('schemas', {})
removed = []
for survivor, duplicates in GROUPS:
    if survivor not in schemas:
        continue
    for name in duplicates:
        if name not in schemas:
            continue  # already collapsed; this step is idempotent
        if comparable(schemas[name]) != comparable(schemas[survivor]):
            sys.exit(f'{name} is no longer identical to {survivor}; review before collapsing')
        del schemas[name]
        removed.append((name, survivor))

renames = {f'#/components/schemas/{old}': f'#/components/schemas/{new}' for old, new in removed}

def repoint(node):
    if isinstance(node, dict):
        ref = node.get('\$ref')
        if isinstance(ref, str) and ref in renames:
            node['\$ref'] = renames[ref]
        for value in node.values():
            repoint(value)
    elif isinstance(node, list):
        for value in node:
            repoint(value)

repoint(spec)

with open('openapi.json', 'w') as f:
    json.dump(spec, f, indent=2)

print(f'Collapsed {len(removed)} duplicate component declarations.')
"

# Auth: D-ID API keys are API_USERNAME:API_PASSWORD credentials sent via HTTP Basic.
autosdk generate openapi.json \
  --shared-json-metadata \
  --validate-any-ofs \
  --namespace DId \
  --clientClassName DIdClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Basic
