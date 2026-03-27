
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteResponseVariant1PresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarTypeJsonConverter))]
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

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
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1PresenterVideoAvatar" /> class.
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
        public DeleteResponseVariant1PresenterVideoAvatar(
            string presenterId,
            global::DId.DeleteResponseVariant1PresenterVideoAvatarType type,
            global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>? voice,
            global::DId.DeleteResponseVariant1PresenterVideoAvatarBackground? background)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Type = type;
            this.Voice = voice;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1PresenterVideoAvatar" /> class.
        /// </summary>
        public DeleteResponseVariant1PresenterVideoAvatar()
        {
        }
    }
}