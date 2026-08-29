#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public class AgentResponseDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentResponseDto>
    {
        /// <inheritdoc />
        public override global::DId.AgentResponseDto Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::DId.AgentResponseDtoVariant1? agentResponseDtoVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.AgentResponseDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.AgentResponseDtoVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.AgentResponseDtoVariant1).Name}");
                agentResponseDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::DId.AgentResponseDtoVariant2? agentResponseDtoVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.AgentResponseDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.AgentResponseDtoVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.AgentResponseDtoVariant2).Name}");
                agentResponseDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::DId.AgentResponseDto(
                agentResponseDtoVariant1,

                agentResponseDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentResponseDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsAgentResponseDtoVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.AgentResponseDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.AgentResponseDtoVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.AgentResponseDtoVariant1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.AgentResponseDtoVariant1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsAgentResponseDtoVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.AgentResponseDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.AgentResponseDtoVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.AgentResponseDtoVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.AgentResponseDtoVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}