#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateExpressiveRequestDtoScriptVariant1ProviderOpenAITypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType?>
    {
        /// <inheritdoc />
        public override global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType? Read(
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
                        return global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAITypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAITypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
