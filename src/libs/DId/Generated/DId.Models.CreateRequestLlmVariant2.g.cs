
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequestLlmVariant2
    {
        /// <summary>
        /// Large Language Model provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateRequestLlmVariant2ProviderJsonConverter))]
        public global::DId.CreateRequestLlmVariant2Provider Provider { get; set; }

        /// <summary>
        /// Defines what the Agent does and how it should behave.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// How the Agent uses knowledge when generating responses.<br/>
        /// - RAG-Grounded: Uses only provided knowledge<br/>
        /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
        /// - Assistant: Uses general model knowledge only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.CreateRequestLlmVariant2TemplateJsonConverter))]
        public global::DId.CreateRequestLlmVariant2Template? Template { get; set; }

        /// <summary>
        /// Advanced configuration for the language model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_customization")]
        public global::DId.CreateRequestLlmVariant2PromptCustomization? PromptCustomization { get; set; }

        /// <summary>
        /// Controls how predictable or creative the Agent’s responses are.<br/>
        /// Default values by template:<br/>
        /// RAG-Grounded: 0.1<br/>
        /// RAG-Ungrounded: 0.5<br/>
        /// Assistant: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Custom/External LLM authentication configurations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>))]
        public global::DId.AnyOf<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestLlmVariant2" /> class.
        /// </summary>
        /// <param name="provider">
        /// Large Language Model provider.
        /// </param>
        /// <param name="instructions">
        /// Defines what the Agent does and how it should behave.
        /// </param>
        /// <param name="template">
        /// How the Agent uses knowledge when generating responses.<br/>
        /// - RAG-Grounded: Uses only provided knowledge<br/>
        /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
        /// - Assistant: Uses general model knowledge only
        /// </param>
        /// <param name="promptCustomization">
        /// Advanced configuration for the language model.
        /// </param>
        /// <param name="temperature">
        /// Controls how predictable or creative the Agent’s responses are.<br/>
        /// Default values by template:<br/>
        /// RAG-Grounded: 0.1<br/>
        /// RAG-Ungrounded: 0.5<br/>
        /// Assistant: 0.5
        /// </param>
        /// <param name="custom">
        /// Custom/External LLM authentication configurations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequestLlmVariant2(
            global::DId.CreateRequestLlmVariant2Provider provider,
            string? instructions,
            global::DId.CreateRequestLlmVariant2Template? template,
            global::DId.CreateRequestLlmVariant2PromptCustomization? promptCustomization,
            double? temperature,
            global::DId.AnyOf<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>? custom)
        {
            this.Provider = provider;
            this.Instructions = instructions;
            this.Template = template;
            this.PromptCustomization = promptCustomization;
            this.Temperature = temperature;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestLlmVariant2" /> class.
        /// </summary>
        public CreateRequestLlmVariant2()
        {
        }
    }
}