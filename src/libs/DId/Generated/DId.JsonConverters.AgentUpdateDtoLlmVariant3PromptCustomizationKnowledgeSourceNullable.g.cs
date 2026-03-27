#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource?>
    {
        /// <inheritdoc />
        public override global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource? Read(
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
                        return global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
