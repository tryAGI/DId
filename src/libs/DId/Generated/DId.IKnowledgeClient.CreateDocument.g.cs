#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Create a Document<br/>
        /// Add document to knowledge base<br/>
        /// Here you could add any document of supported type to become knowledge for your agent.<br/>
        /// Agent will use this documents to answer for user questions.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CreateDocumentResponse> CreateDocumentAsync(
            string knowledgeId,

            global::DId.AllOf<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2> request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Document<br/>
        /// Add document to knowledge base<br/>
        /// Here you could add any document of supported type to become knowledge for your agent.<br/>
        /// Agent will use this documents to answer for user questions.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CreateDocumentResponse> CreateDocumentAsync(
            string knowledgeId,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}