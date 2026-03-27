
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFaceDetectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faceCrops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DId.GetFaceDetectionResponseFaceCrop> FaceCrops { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.GetFaceDetectionResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFaceDetectionResponse" /> class.
        /// </summary>
        /// <param name="faceCrops"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFaceDetectionResponse(
            global::System.Collections.Generic.IList<global::DId.GetFaceDetectionResponseFaceCrop> faceCrops,
            global::DId.GetFaceDetectionResponseMetadata metadata)
        {
            this.FaceCrops = faceCrops ?? throw new global::System.ArgumentNullException(nameof(faceCrops));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFaceDetectionResponse" /> class.
        /// </summary>
        public GetFaceDetectionResponse()
        {
        }
    }
}