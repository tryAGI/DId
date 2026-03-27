#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class LLMConfigCreateDtoVariant5TemplateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.LLMConfigCreateDtoVariant5Template>
    {
        /// <inheritdoc />
        public override global::DId.LLMConfigCreateDtoVariant5Template Read(
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
                        return global::DId.LLMConfigCreateDtoVariant5TemplateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.LLMConfigCreateDtoVariant5Template)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.LLMConfigCreateDtoVariant5Template);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.LLMConfigCreateDtoVariant5Template value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.LLMConfigCreateDtoVariant5TemplateExtensions.ToValueString(value));
        }
    }
}
