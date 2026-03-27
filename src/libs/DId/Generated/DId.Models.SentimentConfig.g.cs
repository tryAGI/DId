
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.SentimentConfigVoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.SentimentConfigVoiceType VoiceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentConfig" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="voiceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentConfig(
            string voiceId,
            global::DId.SentimentConfigVoiceType voiceType)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceType = voiceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentConfig" /> class.
        /// </summary>
        public SentimentConfig()
        {
        }
    }
}