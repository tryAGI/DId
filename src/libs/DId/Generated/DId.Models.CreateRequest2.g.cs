
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest2
    {
        /// <summary>
        /// Agent name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_name")]
        public string? PreviewName { get; set; }

        /// <summary>
        /// Description of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_description")]
        public string? PreviewDescription { get; set; }

        /// <summary>
        /// Defines the Agent’s avatar, including its visual appearance and voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar> Presenter { get; set; }

        /// <summary>
        /// Configuration for the Large Language Model used by the Agent to generate responses.<br/>
        /// D-ID and Google providers are only supported with Expressive Avatar presenters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>))]
        public global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>? Llm { get; set; }

        /// <summary>
        /// Knowledge Base used by the Agent to retrieve answers (RAG).<br/>
        /// Use the ID returned by the Create Knowledge endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        public global::DId.CreateRequestKnowledge? Knowledge { get; set; }

        /// <summary>
        /// List of suggested questions shown to the user at the start of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_message")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Greeting messages used when the chat starts.<br/>
        /// One greeting is selected at random.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greetings")]
        public global::System.Collections.Generic.IList<string>? Greetings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// Enables the Agent for use with the SDK or website embedding via D-ID Studio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        public bool? Embed { get; set; }

        /// <summary>
        /// Event-based trigger configuration for the Agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::DId.CreateRequestTriggers? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest2" /> class.
        /// </summary>
        /// <param name="previewName">
        /// Agent name
        /// </param>
        /// <param name="previewDescription">
        /// Description of the agent
        /// </param>
        /// <param name="presenter">
        /// Defines the Agent’s avatar, including its visual appearance and voice.
        /// </param>
        /// <param name="llm">
        /// Configuration for the Large Language Model used by the Agent to generate responses.<br/>
        /// D-ID and Google providers are only supported with Expressive Avatar presenters.
        /// </param>
        /// <param name="knowledge">
        /// Knowledge Base used by the Agent to retrieve answers (RAG).<br/>
        /// Use the ID returned by the Create Knowledge endpoint.
        /// </param>
        /// <param name="starterMessage">
        /// List of suggested questions shown to the user at the start of the chat.
        /// </param>
        /// <param name="greetings">
        /// Greeting messages used when the chat starts.<br/>
        /// One greeting is selected at random.
        /// </param>
        /// <param name="userData"></param>
        /// <param name="embed">
        /// Enables the Agent for use with the SDK or website embedding via D-ID Studio.
        /// </param>
        /// <param name="triggers">
        /// Event-based trigger configuration for the Agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest2(
            global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar> presenter,
            string? previewName,
            string? previewDescription,
            global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>? llm,
            global::DId.CreateRequestKnowledge? knowledge,
            global::System.Collections.Generic.IList<string>? starterMessage,
            global::System.Collections.Generic.IList<string>? greetings,
            string? userData,
            bool? embed,
            global::DId.CreateRequestTriggers? triggers)
        {
            this.Presenter = presenter;
            this.PreviewName = previewName;
            this.PreviewDescription = previewDescription;
            this.Llm = llm;
            this.Knowledge = knowledge;
            this.StarterMessage = starterMessage;
            this.Greetings = greetings;
            this.UserData = userData;
            this.Embed = embed;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest2" /> class.
        /// </summary>
        public CreateRequest2()
        {
        }
    }
}