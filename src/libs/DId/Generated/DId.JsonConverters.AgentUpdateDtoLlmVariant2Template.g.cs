#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentUpdateDtoLlmVariant2TemplateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentUpdateDtoLlmVariant2Template>
    {
        /// <inheritdoc />
        public override global::DId.AgentUpdateDtoLlmVariant2Template Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DId.AgentUpdateDtoLlmVariant2TemplateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AgentUpdateDtoLlmVariant2Template)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AgentUpdateDtoLlmVariant2Template);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentUpdateDtoLlmVariant2Template value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.AgentUpdateDtoLlmVariant2TemplateExtensions.ToValueString(value));
        }
    }
}
