
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartConnectionRequest
    {
        /// <summary>
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Jsep answer object used to create a peer connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.StartConnectionRequestAnswer Answer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnectionRequest" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </param>
        /// <param name="answer">
        /// Jsep answer object used to create a peer connection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartConnectionRequest(
            global::DId.StartConnectionRequestAnswer answer,
            string? sessionId)
        {
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnectionRequest" /> class.
        /// </summary>
        public StartConnectionRequest()
        {
        }
    }
}