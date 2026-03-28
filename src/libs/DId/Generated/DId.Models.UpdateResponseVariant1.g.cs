
#nullable enable

namespace DId
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class UpdateResponseVariant1
    {
        /// <summary>
        /// Id of agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Description of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_description")]
        public string? PreviewDescription { get; set; }

        /// <summary>
        /// Presenter who will show in the chat with the user<br/>
        /// Types of presenters below, you could choose 1 option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>))]
        public global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>? Presenter { get; set; }

        /// <summary>
        /// Configuration for the Large Language Model used by the Agent to generate responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>))]
        public global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>? Llm { get; set; }

        /// <summary>
        /// The provider of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.UpdateResponseVariant1ProviderJsonConverter))]
        public global::DId.UpdateResponseVariant1Provider? Provider { get; set; }

        /// <summary>
        /// Knowledge documents base where the agent will look for answers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        public global::DId.UpdateResponseVariant1Knowledge? Knowledge { get; set; }

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_message")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Greeting messages for the agent<br/>
        /// One greeting is randomly displayed at the start of the chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greetings")]
        public global::System.Collections.Generic.IList<string>? Greetings { get; set; }

        /// <summary>
        /// Error object in case of errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::DId.UpdateResponseVariant1Error? Error { get; set; }

        /// <summary>
        /// Trigger configurations for this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::DId.UpdateResponseVariant1Triggers? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of agent
        /// </param>
        /// <param name="previewDescription">
        /// Description of the agent
        /// </param>
        /// <param name="presenter">
        /// Presenter who will show in the chat with the user<br/>
        /// Types of presenters below, you could choose 1 option
        /// </param>
        /// <param name="llm">
        /// Configuration for the Large Language Model used by the Agent to generate responses.
        /// </param>
        /// <param name="provider">
        /// The provider of the agent
        /// </param>
        /// <param name="knowledge">
        /// Knowledge documents base where the agent will look for answers
        /// </param>
        /// <param name="starterMessage">
        /// List of messages to be showen as chat starter questions for the user to ask
        /// </param>
        /// <param name="greetings">
        /// Greeting messages for the agent<br/>
        /// One greeting is randomly displayed at the start of the chat
        /// </param>
        /// <param name="error">
        /// Error object in case of errors
        /// </param>
        /// <param name="triggers">
        /// Trigger configurations for this agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResponseVariant1(
            string id,
            string? previewDescription,
            global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>? presenter,
            global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>? llm,
            global::DId.UpdateResponseVariant1Provider? provider,
            global::DId.UpdateResponseVariant1Knowledge? knowledge,
            global::System.Collections.Generic.IList<string>? starterMessage,
            global::System.Collections.Generic.IList<string>? greetings,
            global::DId.UpdateResponseVariant1Error? error,
            global::DId.UpdateResponseVariant1Triggers? triggers)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PreviewDescription = previewDescription;
            this.Presenter = presenter;
            this.Llm = llm;
            this.Provider = provider;
            this.Knowledge = knowledge;
            this.StarterMessage = starterMessage;
            this.Greetings = greetings;
            this.Error = error;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1" /> class.
        /// </summary>
        public UpdateResponseVariant1()
        {
        }
    }
}