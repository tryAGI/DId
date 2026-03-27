
#nullable enable

namespace DId
{
    /// <summary>
    /// Custom crop
    /// </summary>
    public sealed partial class RectangleCrop
    {
        /// <summary>
        /// The type of the crop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.RectangleCropTypeJsonConverter))]
        public global::DId.RectangleCropType Type { get; set; }

        /// <summary>
        /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
        /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
        /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rectangle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.RectangleCropRectangle Rectangle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCrop" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
        /// <param name="rectangle">
        /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
        /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
        /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RectangleCrop(
            global::DId.RectangleCropRectangle rectangle,
            global::DId.RectangleCropType type)
        {
            this.Rectangle = rectangle ?? throw new global::System.ArgumentNullException(nameof(rectangle));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCrop" /> class.
        /// </summary>
        public RectangleCrop()
        {
        }
    }
}