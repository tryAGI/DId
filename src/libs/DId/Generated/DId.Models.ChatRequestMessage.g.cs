
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequestMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ChatRequestMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.ChatRequestMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="ChatRequestMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestMessage(
            global::DId.ChatRequestMessageRole role,
            string content,
            string createdAt)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestMessage" /> class.
        /// </summary>
        public ChatRequestMessage()
        {
        }
    }
}