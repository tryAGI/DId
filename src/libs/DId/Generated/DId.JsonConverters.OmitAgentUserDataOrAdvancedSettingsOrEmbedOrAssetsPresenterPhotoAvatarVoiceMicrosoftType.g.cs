#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType>
    {
        /// <inheritdoc />
        public override global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType Read(
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
                        return global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeExtensions.ToValueString(value));
        }
    }
}
