
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipRequestScriptVariant1ProviderAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonTypeJsonConverter))]
        public global::DId.CreateClipRequestScriptVariant1ProviderAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.CreateClipRequestScriptVariant1ProviderAmazonVoiceId VoiceId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateClipRequestScriptVariant1ProviderAmazon" /> class.
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
        public CreateClipRequestScriptVariant1ProviderAmazon(
            global::DId.CreateClipRequestScriptVariant1ProviderAmazonVoiceId voiceId,
            global::DId.CreateClipRequestScriptVariant1ProviderAmazonType type,
            string? language)
        {
            this.VoiceId = voiceId;
            this.Type = type;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestScriptVariant1ProviderAmazon" /> class.
        /// </summary>
        public CreateClipRequestScriptVariant1ProviderAmazon()
        {
        }
    }
}