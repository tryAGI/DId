#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentUpdateDtoPresenterVideoAvatarVoiceOpenAITypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType>
    {
        /// <inheritdoc />
        public override global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType Read(
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
                        return global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAITypeExtensions.ToValueString(value));
        }
    }
}
