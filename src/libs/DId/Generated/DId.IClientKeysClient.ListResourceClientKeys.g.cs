#nullable enable

namespace DId
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// List Agent Client Keys<br/>
        /// List all client keys scoped to a specific agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DId.ListResourceClientKeysResponseItem>> ListResourceClientKeysAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}