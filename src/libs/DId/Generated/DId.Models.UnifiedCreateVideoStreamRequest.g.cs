
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnifiedCreateVideoStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio> Script { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedCreateVideoStreamRequest" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="script"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedCreateVideoStreamRequest(
            global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio> script,
            string? sessionId)
        {
            this.Script = script;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedCreateVideoStreamRequest" /> class.
        /// </summary>
        public UnifiedCreateVideoStreamRequest()
        {
        }
    }
}