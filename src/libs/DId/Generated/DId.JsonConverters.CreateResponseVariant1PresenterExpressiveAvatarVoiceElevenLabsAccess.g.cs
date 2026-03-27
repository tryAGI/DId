#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess>
    {
        /// <inheritdoc />
        public override global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess Read(
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
                        return global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessExtensions.ToValueString(value));
        }
    }
}
