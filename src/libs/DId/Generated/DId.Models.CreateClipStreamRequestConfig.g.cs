
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateClipStreamRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestConfigLogo, bool?>))]
        public global::DId.AnyOf<global::DId.CreateClipStreamRequestConfigLogo, bool?>? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateClipStreamRequestConfigResultFormatJsonConverter))]
        public global::DId.CreateClipStreamRequestConfigResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestConfig" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="resultFormat">
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipStreamRequestConfig(
            global::DId.AnyOf<global::DId.CreateClipStreamRequestConfigLogo, bool?>? logo,
            global::DId.CreateClipStreamRequestConfigResultFormat? resultFormat)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestConfig" /> class.
        /// </summary>
        public CreateClipStreamRequestConfig()
        {
        }
    }
}