#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get Documents<br/>
        /// Get all documents from knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DId.GetDocumentsResponseItem>> GetDocumentsAsync(
            string knowledgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}