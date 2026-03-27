
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMyAgentsResponseAgentVariant1PresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarTypeJsonConverter))]
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1PresenterVideoAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        /// <param name="presenterId">
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMyAgentsResponseAgentVariant1PresenterVideoAvatar(
            string presenterId,
            global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType type,
            global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>? voice,
            global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarBackground? background)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Type = type;
            this.Voice = voice;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1PresenterVideoAvatar" /> class.
        /// </summary>
        public ListMyAgentsResponseAgentVariant1PresenterVideoAvatar()
        {
        }
    }
}