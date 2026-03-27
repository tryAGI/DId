
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressiveResponseDtoVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateExpressiveResponseDtoVariant2ObjectJsonConverter))]
        public global::DId.CreateExpressiveResponseDtoVariant2Object Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveResponseDtoVariant2" /> class.
        /// </summary>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressiveResponseDtoVariant2(
            global::DId.CreateExpressiveResponseDtoVariant2Object @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveResponseDtoVariant2" /> class.
        /// </summary>
        public CreateExpressiveResponseDtoVariant2()
        {
        }
    }
}