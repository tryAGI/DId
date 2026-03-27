#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClipAgentPresenterVoiceOpenAITypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ClipAgentPresenterVoiceOpenAIType>
    {
        /// <inheritdoc />
        public override global::DId.ClipAgentPresenterVoiceOpenAIType Read(
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
                        return global::DId.ClipAgentPresenterVoiceOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ClipAgentPresenterVoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ClipAgentPresenterVoiceOpenAIType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ClipAgentPresenterVoiceOpenAIType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.ClipAgentPresenterVoiceOpenAITypeExtensions.ToValueString(value));
        }
    }
}
