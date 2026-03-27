
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranslationsResponseTranslationTranscription2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersion2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.GetTranslationsResponseTranslationTranscriptionVersion2 Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected")]
        public bool? Selected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationsResponseTranslationTranscription2" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="selected"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTranslationsResponseTranslationTranscription2(
            string url,
            global::DId.GetTranslationsResponseTranslationTranscriptionVersion2 version,
            bool? selected)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Version = version;
            this.Selected = selected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationsResponseTranslationTranscription2" /> class.
        /// </summary>
        public GetTranslationsResponseTranslationTranscription2()
        {
        }
    }
}