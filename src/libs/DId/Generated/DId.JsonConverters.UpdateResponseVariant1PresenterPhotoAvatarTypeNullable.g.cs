#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatarType?>
    {
        /// <inheritdoc />
        public override global::DId.UpdateResponseVariant1PresenterPhotoAvatarType? Read(
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
                        return global::DId.UpdateResponseVariant1PresenterPhotoAvatarTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.UpdateResponseVariant1PresenterPhotoAvatarType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.UpdateResponseVariant1PresenterPhotoAvatarType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.UpdateResponseVariant1PresenterPhotoAvatarTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
