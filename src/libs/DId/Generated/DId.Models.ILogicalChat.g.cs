
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ILogicalChat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DId.IMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_mode")]
        public string? ChatMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        public double? MessageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist_messages")]
        public bool? PersistMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.ILogicalChatPlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.ILogicalChatPlan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_minutes")]
        public double? DurationMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details_url")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::DId.ILogicalChatAgent? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insights")]
        public global::DId.ILogicalChatInsights? Insights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_session_id")]
        public string? LivekitSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ILogicalChat" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="agentId"></param>
        /// <param name="externalId"></param>
        /// <param name="origin"></param>
        /// <param name="chatMode"></param>
        /// <param name="messageCount"></param>
        /// <param name="persistMessages"></param>
        /// <param name="plan"></param>
        /// <param name="durationMinutes"></param>
        /// <param name="detailsUrl"></param>
        /// <param name="agent"></param>
        /// <param name="insights"></param>
        /// <param name="region"></param>
        /// <param name="livekitSessionId"></param>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ILogicalChat(
            global::System.Collections.Generic.IList<global::DId.IMessage> messages,
            string agentId,
            string externalId,
            global::DId.ILogicalChatPlan plan,
            string id,
            string ownerId,
            string createdAt,
            string modifiedAt,
            string? origin,
            string? chatMode,
            double? messageCount,
            bool? persistMessages,
            double? durationMinutes,
            string? detailsUrl,
            global::DId.ILogicalChatAgent? agent,
            global::DId.ILogicalChatInsights? insights,
            string? region,
            string? livekitSessionId)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.Plan = plan;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Origin = origin;
            this.ChatMode = chatMode;
            this.MessageCount = messageCount;
            this.PersistMessages = persistMessages;
            this.DurationMinutes = durationMinutes;
            this.DetailsUrl = detailsUrl;
            this.Agent = agent;
            this.Insights = insights;
            this.Region = region;
            this.LivekitSessionId = livekitSessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ILogicalChat" /> class.
        /// </summary>
        public ILogicalChat()
        {
        }
    }
}