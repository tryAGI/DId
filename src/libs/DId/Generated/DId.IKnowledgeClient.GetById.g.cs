#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get a Knowledge<br/>
        /// Get specific knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetByIdResponse> GetByIdAsync(
            string knowledgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}