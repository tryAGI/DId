#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource>
    {
        /// <inheritdoc />
        public override global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource Read(
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
                        return global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSourceExtensions.ToValueString(value));
        }
    }
}
