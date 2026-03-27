#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleLLMCreateDtoProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GoogleLLMCreateDtoProvider?>
    {
        /// <inheritdoc />
        public override global::DId.GoogleLLMCreateDtoProvider? Read(
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
                        return global::DId.GoogleLLMCreateDtoProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.GoogleLLMCreateDtoProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.GoogleLLMCreateDtoProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GoogleLLMCreateDtoProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.GoogleLLMCreateDtoProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
