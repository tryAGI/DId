
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatars1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>> Avatars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatars1Response" /> class.
        /// </summary>
        /// <param name="avatars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatars1Response(
            global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>> avatars)
        {
            this.Avatars = avatars ?? throw new global::System.ArgumentNullException(nameof(avatars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatars1Response" /> class.
        /// </summary>
        public GetAvatars1Response()
        {
        }
    }
}