#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Create a Knowledge<br/>
        /// Knowledge used to provide information for agent, that search by this info and return in chat with user.<br/>
        /// Each Knowledge could store up to 5 documents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Create1Response5> Create1Async(

            global::DId.Create1Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Knowledge<br/>
        /// Knowledge used to provide information for agent, that search by this info and return in chat with user.<br/>
        /// Each Knowledge could store up to 5 documents
        /// </summary>
        /// <param name="description">
        /// Description of knowledge
        /// </param>
        /// <param name="name">
        /// Name of knowledge
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Create1Response5> Create1Async(
            string description,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}