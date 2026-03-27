
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialClipAgentPresenter
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.PartialClipAgentPresenterTypeJsonConverter))]
        public global::DId.PartialClipAgentPresenterType? Type { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::DId.PartialClipAgentPresenterBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialClipAgentPresenter" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="presenterId">
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialClipAgentPresenter(
            global::DId.PartialClipAgentPresenterType? type,
            string? presenterId,
            global::DId.PartialClipAgentPresenterBackground? background,
            global::DId.AnyOf<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.PresenterId = presenterId;
            this.Background = background;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialClipAgentPresenter" /> class.
        /// </summary>
        public PartialClipAgentPresenter()
        {
        }
    }
}