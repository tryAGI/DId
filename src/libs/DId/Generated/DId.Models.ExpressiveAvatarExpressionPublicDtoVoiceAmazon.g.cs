
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressiveAvatarExpressionPublicDtoVoiceAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceAmazonTypeJsonConverter))]
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId VoiceId { get; set; }

        /// <summary>
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAvatarExpressionPublicDtoVoiceAmazon" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpressiveAvatarExpressionPublicDtoVoiceAmazon(
            global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId voiceId,
            global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonType type,
            string? language)
        {
            this.VoiceId = voiceId;
            this.Type = type;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAvatarExpressionPublicDtoVoiceAmazon" /> class.
        /// </summary>
        public ExpressiveAvatarExpressionPublicDtoVoiceAmazon()
        {
        }
    }
}