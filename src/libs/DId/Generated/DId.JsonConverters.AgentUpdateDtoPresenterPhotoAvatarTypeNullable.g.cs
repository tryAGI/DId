#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentUpdateDtoPresenterPhotoAvatarTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.AgentUpdateDtoPresenterPhotoAvatarType?>
    {
        /// <inheritdoc />
        public override global::DId.AgentUpdateDtoPresenterPhotoAvatarType? Read(
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
                        return global::DId.AgentUpdateDtoPresenterPhotoAvatarTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.AgentUpdateDtoPresenterPhotoAvatarType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.AgentUpdateDtoPresenterPhotoAvatarType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.AgentUpdateDtoPresenterPhotoAvatarType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.AgentUpdateDtoPresenterPhotoAvatarTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
