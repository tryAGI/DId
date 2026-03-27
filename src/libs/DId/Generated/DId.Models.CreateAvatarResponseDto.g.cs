
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAvatarResponseDto
    {
        /// <summary>
        /// The ID of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateAvatarResponseDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.CreateAvatarResponseDtoStatus Status { get; set; }

        /// <summary>
        /// An identifier of this avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateAvatarResponseDtoObjectJsonConverter))]
        public global::DId.CreateAvatarResponseDtoObject Object { get; set; }

        /// <summary>
        /// Avatar creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the avatar
        /// </param>
        /// <param name="status">
        /// The status of the avatar
        /// </param>
        /// <param name="object">
        /// An identifier of this avatar
        /// </param>
        /// <param name="createdAt">
        /// Avatar creation time as iso-8601 string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarResponseDto(
            string id,
            global::DId.CreateAvatarResponseDtoStatus status,
            string createdAt,
            global::DId.CreateAvatarResponseDtoObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarResponseDto" /> class.
        /// </summary>
        public CreateAvatarResponseDto()
        {
        }
    }
}