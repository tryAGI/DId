#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get Knowledges<br/>
        /// Get all user knowledge bases
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DId.Get1ResponseItem>> Get1Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}