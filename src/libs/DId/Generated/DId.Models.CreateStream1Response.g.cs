
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStream1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Id of the stream - should be returned as *path parameter* in all streaming request to the same stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Jsep offer object used to create a peer connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsep")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.CreateStream1ResponseJsep Jsep { get; set; }

        /// <summary>
        /// ICE servers used to create a peer connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ice_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DId.CreateStream1ResponseIceServer> IceServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStream1Response" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="id">
        /// Id of the stream - should be returned as *path parameter* in all streaming request to the same stream
        /// </param>
        /// <param name="jsep">
        /// Jsep offer object used to create a peer connection
        /// </param>
        /// <param name="iceServers">
        /// ICE servers used to create a peer connection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStream1Response(
            string id,
            global::DId.CreateStream1ResponseJsep jsep,
            global::System.Collections.Generic.IList<global::DId.CreateStream1ResponseIceServer> iceServers,
            string? sessionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Jsep = jsep ?? throw new global::System.ArgumentNullException(nameof(jsep));
            this.IceServers = iceServers ?? throw new global::System.ArgumentNullException(nameof(iceServers));
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStream1Response" /> class.
        /// </summary>
        public CreateStream1Response()
        {
        }
    }
}