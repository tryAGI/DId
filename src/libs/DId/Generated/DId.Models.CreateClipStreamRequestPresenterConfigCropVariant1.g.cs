
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipStreamRequestPresenterConfigCropVariant1
    {
        /// <summary>
        /// The type of the crop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant1TypeJsonConverter))]
        public global::DId.CreateClipStreamRequestPresenterConfigCropVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfigCropVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipStreamRequestPresenterConfigCropVariant1(
            global::DId.CreateClipStreamRequestPresenterConfigCropVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfigCropVariant1" /> class.
        /// </summary>
        public CreateClipStreamRequestPresenterConfigCropVariant1()
        {
        }
    }
}