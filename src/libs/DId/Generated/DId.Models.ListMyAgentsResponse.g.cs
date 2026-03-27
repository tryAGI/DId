
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMyAgentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponse" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMyAgentsResponse(
            global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>> agents,
            string? token)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponse" /> class.
        /// </summary>
        public ListMyAgentsResponse()
        {
        }
    }
}