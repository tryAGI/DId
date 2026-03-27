#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceId Read(
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
                        return global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
