#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetClipsPresentersResponsePresenterVoiceGoogleTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType?>
    {
        /// <inheritdoc />
        public override global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType? Read(
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
                        return global::DId.GetClipsPresentersResponsePresenterVoiceGoogleTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.GetClipsPresentersResponsePresenterVoiceGoogleTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
