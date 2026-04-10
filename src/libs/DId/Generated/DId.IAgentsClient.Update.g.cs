#nullable enable

namespace DId
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an Agent<br/>
        /// Updates an existing Agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>> UpdateAsync(
            string id,

            global::DId.UpdateRequest request,
            string? xApiKeyExternal = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent<br/>
        /// Updates an existing Agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>> UpdateAsync(
            string id,
            string? xApiKeyExternal = default,
            string? previewName = default,
            string? previewDescription = default,
            global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>? presenter = default,
            global::DId.AnyOf<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>? llm = default,
            global::DId.UpdateRequestKnowledge? knowledge = default,
            global::System.Collections.Generic.IList<string>? starterMessage = default,
            global::System.Collections.Generic.IList<string>? greetings = default,
            string? userData = default,
            bool? embed = default,
            global::DId.UpdateRequestTriggers? triggers = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}