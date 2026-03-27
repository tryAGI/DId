#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureOpenAIExternalLLMPromptCustomizationKnowledgeSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource?>
    {
        /// <inheritdoc />
        public override global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource? Read(
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
                        return global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
