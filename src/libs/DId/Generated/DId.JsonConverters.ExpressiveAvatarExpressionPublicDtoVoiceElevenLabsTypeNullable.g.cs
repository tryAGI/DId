#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType?>
    {
        /// <inheritdoc />
        public override global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType? Read(
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
                        return global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
