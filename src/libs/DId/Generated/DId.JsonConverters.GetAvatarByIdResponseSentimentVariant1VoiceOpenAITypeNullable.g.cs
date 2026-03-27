#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType?>
    {
        /// <inheritdoc />
        public override global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType? Read(
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
                        return global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
