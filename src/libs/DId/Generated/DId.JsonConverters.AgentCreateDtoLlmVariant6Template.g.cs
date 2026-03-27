#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentCreateDtoLlmVariant6TemplateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentCreateDtoLlmVariant6Template>
    {
        /// <inheritdoc />
        public override global::DId.AgentCreateDtoLlmVariant6Template Read(
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
                        return global::DId.AgentCreateDtoLlmVariant6TemplateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AgentCreateDtoLlmVariant6Template)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AgentCreateDtoLlmVariant6Template);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentCreateDtoLlmVariant6Template value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.AgentCreateDtoLlmVariant6TemplateExtensions.ToValueString(value));
        }
    }
}
