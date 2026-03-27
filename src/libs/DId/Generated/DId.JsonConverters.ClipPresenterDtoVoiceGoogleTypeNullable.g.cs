#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClipPresenterDtoVoiceGoogleTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ClipPresenterDtoVoiceGoogleType?>
    {
        /// <inheritdoc />
        public override global::DId.ClipPresenterDtoVoiceGoogleType? Read(
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
                        return global::DId.ClipPresenterDtoVoiceGoogleTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ClipPresenterDtoVoiceGoogleType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ClipPresenterDtoVoiceGoogleType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ClipPresenterDtoVoiceGoogleType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.ClipPresenterDtoVoiceGoogleTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
