#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Update a Knowledge<br/>
        /// If you need to change some of knowledge field
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Update1Response> Update1Async(
            string knowledgeId,

            global::DId.Update1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Knowledge<br/>
        /// If you need to change some of knowledge field
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="description">
        /// Description of knowledge
        /// </param>
        /// <param name="name">
        /// Name of knowledge
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Update1Response> Update1Async(
            string knowledgeId,
            string? description = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}