#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?>
    {
        /// <inheritdoc />
        public override global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? Read(
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
                        return global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
