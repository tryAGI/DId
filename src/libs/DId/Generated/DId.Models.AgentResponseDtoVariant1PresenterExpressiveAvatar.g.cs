
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponseDtoVariant1PresenterExpressiveAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarTypeJsonConverter))]
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>? Voice { get; set; }

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
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        /// <param name="presenterId">
        /// Id of avatar that will be shown for user
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentResponseDtoVariant1PresenterExpressiveAvatar(
            string presenterId,
            global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarType type,
            global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>? voice,
            global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarBackground? background)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Type = type;
            this.Voice = voice;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        public AgentResponseDtoVariant1PresenterExpressiveAvatar()
        {
        }
    }
}