
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialExpressiveAgentPresenter
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterTypeJsonConverter))]
        public global::DId.PartialExpressiveAgentPresenterType? Type { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::DId.PartialExpressiveAgentPresenterBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExpressiveAgentPresenter" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="presenterId">
        /// Id of avatar that will be shown for user
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
        public PartialExpressiveAgentPresenter(
            global::DId.PartialExpressiveAgentPresenterType? type,
            string? presenterId,
            global::DId.PartialExpressiveAgentPresenterBackground? background,
            global::DId.AnyOf<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.PresenterId = presenterId;
            this.Background = background;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExpressiveAgentPresenter" /> class.
        /// </summary>
        public PartialExpressiveAgentPresenter()
        {
        }
    }
}