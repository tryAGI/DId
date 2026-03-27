
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPresenterExpressiveAvatar2
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarType2JsonConverter))]
        public global::DId.AgentPresenterExpressiveAvatarType2 Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>))]
        public global::DId.AnyOf<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>? Voice { get; set; }

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
        public global::DId.AgentPresenterExpressiveAvatarBackground2? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterExpressiveAvatar2" /> class.
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
        public AgentPresenterExpressiveAvatar2(
            string presenterId,
            global::DId.AgentPresenterExpressiveAvatarType2 type,
            global::DId.AnyOf<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>? voice,
            global::DId.AgentPresenterExpressiveAvatarBackground2? background)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Type = type;
            this.Voice = voice;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterExpressiveAvatar2" /> class.
        /// </summary>
        public AgentPresenterExpressiveAvatar2()
        {
        }
    }
}