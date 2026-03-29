
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarTypeJsonConverter))]
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        /// <param name="presenterId">
        /// Id of avatar that will be shown for user
        /// </param>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar(
            string presenterId,
            global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType type,
            global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>? voice,
            global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        public ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar()
        {
        }
    }
}