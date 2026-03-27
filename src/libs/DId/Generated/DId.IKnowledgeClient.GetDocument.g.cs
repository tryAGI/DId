#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get a Document<br/>
        /// Get document by id from knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetDocumentResponse> GetDocumentAsync(
            string knowledgeId,
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}