#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId Read(
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
                        return global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
