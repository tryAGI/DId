#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExpressiveAvatarExpressionPublicDtoVoiceOpenAITypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType?>
    {
        /// <inheritdoc />
        public override global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType? Read(
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
                        return global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAITypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAITypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
