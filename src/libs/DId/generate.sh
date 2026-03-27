dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# D-ID uses multiple API specs (realtime, videos, resources, legacy) that are
# merged into a single openapi.json file stored locally in this directory.
# The specs are extracted from https://docs.d-id.com/reference/ embedded data.

# Fix auth: ensure bearer security scheme is defined and set as top-level security
cat openapi.json | \
  jq '
    .components.securitySchemes = {
      "bearer": { "type": "http", "scheme": "bearer" }
    } |
    .security = [{"bearer": []}] |
    # Remove operation-level security (top-level bearer covers everything)
    walk(if type == "object" and has("security") and has("operationId") then del(.security) else . end)
  ' > openapi.fixed.json

autosdk generate openapi.fixed.json \
  --namespace DId \
  --clientClassName DIdClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

rm -f openapi.fixed.json
