
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressiveAgentPresenter
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ExpressiveAgentPresenterTypeJsonConverter))]
        public global::DId.ExpressiveAgentPresenterType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAgentPresenterVoiceMicrosoft, global::DId.ExpressiveAgentPresenterVoiceElevenLabs, global::DId.ExpressiveAgentPresenterVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.ExpressiveAgentPresenterVoiceMicrosoft, global::DId.ExpressiveAgentPresenterVoiceElevenLabs, global::DId.ExpressiveAgentPresenterVoiceOpenAI>? Voice { get; set; }

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
        public global::DId.ExpressiveAgentPresenterBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAgentPresenter" /> class.
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
        public ExpressiveAgentPresenter(
            string presenterId,
            global::DId.ExpressiveAgentPresenterType type,
            global::DId.AnyOf<global::DId.ExpressiveAgentPresenterVoiceMicrosoft, global::DId.ExpressiveAgentPresenterVoiceElevenLabs, global::DId.ExpressiveAgentPresenterVoiceOpenAI>? voice,
            global::DId.ExpressiveAgentPresenterBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAgentPresenter" /> class.
        /// </summary>
        public ExpressiveAgentPresenter()
        {
        }
    }
}