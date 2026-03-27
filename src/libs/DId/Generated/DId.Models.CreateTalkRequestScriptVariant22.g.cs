
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkRequestScriptVariant22
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant2Type2JsonConverter))]
        public global::DId.CreateTalkRequestScriptVariant2Type2 Type { get; set; }

        /// <summary>
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        public bool? Subtitles { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limited to 15MB.<br/>
        /// Audio length is limited 5 minutes for clips and 10 minutes for talks.<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestScriptVariant22" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the script.
        /// </param>
        /// <param name="subtitles">
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limited to 15MB.<br/>
        /// Audio length is limited 5 minutes for clips and 10 minutes for talks.<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTalkRequestScriptVariant22(
            string audioUrl,
            global::DId.CreateTalkRequestScriptVariant2Type2 type,
            bool? subtitles)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Type = type;
            this.Subtitles = subtitles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestScriptVariant22" /> class.
        /// </summary>
        public CreateTalkRequestScriptVariant22()
        {
        }
    }
}