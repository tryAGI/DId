
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainClipRequest
    {
        /// <summary>
        /// The source URL of the clip video to train, the video must be longer than 3 minutes and have a resolution higher than 0.5 megapixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceUrl { get; set; }

        /// <summary>
        /// A name for the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The gender of the presenter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.TrainClipRequestGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.TrainClipRequestGender Gender { get; set; }

        /// <summary>
        /// Id of the related consent for the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent_id")]
        public string? ConsentId { get; set; }

        /// <summary>
        /// The webhook to call when the training is done
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Configuration options for the clip training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::DId.TrainClipRequestConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainClipRequest" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// The source URL of the clip video to train, the video must be longer than 3 minutes and have a resolution higher than 0.5 megapixels.
        /// </param>
        /// <param name="name">
        /// A name for the avatar
        /// </param>
        /// <param name="gender">
        /// The gender of the presenter
        /// </param>
        /// <param name="consentId">
        /// Id of the related consent for the clip
        /// </param>
        /// <param name="webhook">
        /// The webhook to call when the training is done
        /// </param>
        /// <param name="config">
        /// Configuration options for the clip training
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainClipRequest(
            string sourceUrl,
            global::DId.TrainClipRequestGender gender,
            string? name,
            string? consentId,
            string? webhook,
            global::DId.TrainClipRequestConfig? config)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Gender = gender;
            this.Name = name;
            this.ConsentId = consentId;
            this.Webhook = webhook;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainClipRequest" /> class.
        /// </summary>
        public TrainClipRequest()
        {
        }
    }
}