
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeJsonConverter))]
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: en-US-JennyNeural
        /// </summary>
        /// <example>en-US-JennyNeural</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Voice customization options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_config")]
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftVoiceConfig? VoiceConfig { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: en-US-JennyNeural
        /// </param>
        /// <param name="voiceConfig">
        /// Voice customization options
        /// </param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft(
            string voiceId,
            global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType type,
            global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftVoiceConfig? voiceConfig,
            string? language)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Type = type;
            this.VoiceConfig = voiceConfig;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft" /> class.
        /// </summary>
        public CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft()
        {
        }
    }
}