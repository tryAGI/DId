#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClipAgentPresenterVoiceElevenLabsAccessNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ClipAgentPresenterVoiceElevenLabsAccess?>
    {
        /// <inheritdoc />
        public override global::DId.ClipAgentPresenterVoiceElevenLabsAccess? Read(
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
                        return global::DId.ClipAgentPresenterVoiceElevenLabsAccessExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ClipAgentPresenterVoiceElevenLabsAccess)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ClipAgentPresenterVoiceElevenLabsAccess?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ClipAgentPresenterVoiceElevenLabsAccess? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.ClipAgentPresenterVoiceElevenLabsAccessExtensions.ToValueString(value.Value));
            }
        }
    }
}
