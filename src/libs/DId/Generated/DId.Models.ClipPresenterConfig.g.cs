
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipPresenterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipPresenterConfigCropVariant1, global::DId.ClipPresenterConfigCropVariant2>))]
        public global::DId.AnyOf<global::DId.ClipPresenterConfigCropVariant1, global::DId.ClipPresenterConfigCropVariant2>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterConfig" /> class.
        /// </summary>
        /// <param name="crop"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipPresenterConfig(
            global::DId.AnyOf<global::DId.ClipPresenterConfigCropVariant1, global::DId.ClipPresenterConfigCropVariant2>? crop)
        {
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterConfig" /> class.
        /// </summary>
        public ClipPresenterConfig()
        {
        }
    }
}