
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1TypeJsonConverter))]
        public global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1Type Type { get; set; }

        /// <summary>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value">
        /// Example: #47ffff
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1(
            string value,
            global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1Type type)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1" /> class.
        /// </summary>
        public FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1()
        {
        }
    }
}