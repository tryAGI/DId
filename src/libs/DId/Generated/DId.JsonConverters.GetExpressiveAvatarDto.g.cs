#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public class GetExpressiveAvatarDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GetExpressiveAvatarDto>
    {
        /// <inheritdoc />
        public override global::DId.GetExpressiveAvatarDto Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("sentiments")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>? getExpressiveAvatarDtoVariant1 = default;
            global::DId.GetExpressiveAvatarDtoVariant2? getExpressiveAvatarDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        getExpressiveAvatarDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        getExpressiveAvatarDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.GetExpressiveAvatarDtoVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (getExpressiveAvatarDtoVariant1 == null && getExpressiveAvatarDtoVariant2 == null)
            {
                try
                {
                    getExpressiveAvatarDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    getExpressiveAvatarDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.GetExpressiveAvatarDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::DId.GetExpressiveAvatarDto(
                getExpressiveAvatarDtoVariant1,

                getExpressiveAvatarDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GetExpressiveAvatarDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsGetExpressiveAvatarDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetExpressiveAvatarDtoVariant1, typeof(global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>), options);
            }
            else if (value.IsGetExpressiveAvatarDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetExpressiveAvatarDtoVariant2, typeof(global::DId.GetExpressiveAvatarDtoVariant2), options);
            }
        }
    }
}