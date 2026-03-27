
#nullable enable

namespace DId
{
    /// <summary>
    /// Jsep answer object used to create a peer connection
    /// </summary>
    public sealed partial class StartConnectionRequestAnswer2
    {
        /// <summary>
        /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
        /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.StartConnectionRequestAnswerType2JsonConverter))]
        public global::DId.StartConnectionRequestAnswerType2 Type { get; set; }

        /// <summary>
        /// Describe the media communication sessions to accept the session the is being negotiated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sdp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnectionRequestAnswer2" /> class.
        /// </summary>
        /// <param name="type">
        /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
        /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
        /// </param>
        /// <param name="sdp">
        /// Describe the media communication sessions to accept the session the is being negotiated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartConnectionRequestAnswer2(
            string sdp,
            global::DId.StartConnectionRequestAnswerType2 type)
        {
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnectionRequestAnswer2" /> class.
        /// </summary>
        public StartConnectionRequestAnswer2()
        {
        }
    }
}