#nullable enable

namespace DId
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Delete Agent Client Key<br/>
        /// Delete a client key scoped to a specific agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="clientKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteResourceClientKeyAsync(
            string agentId,
            string clientKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}