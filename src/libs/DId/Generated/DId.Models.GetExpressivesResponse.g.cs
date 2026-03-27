
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressivesResponse
    {
        /// <summary>
        /// The pagination token for the next page of expressives
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressives")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseExpressive> Expressives { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressivesResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The pagination token for the next page of expressives
        /// </param>
        /// <param name="expressives"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExpressivesResponse(
            global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseExpressive> expressives,
            string? token)
        {
            this.Expressives = expressives ?? throw new global::System.ArgumentNullException(nameof(expressives));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressivesResponse" /> class.
        /// </summary>
        public GetExpressivesResponse()
        {
        }
    }
}