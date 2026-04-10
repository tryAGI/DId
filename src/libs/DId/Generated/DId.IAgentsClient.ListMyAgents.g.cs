#nullable enable

namespace DId
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Returns a list of all Agents.
        /// </summary>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.ListMyAgentsResponse> ListMyAgentsAsync(
            global::DId.ListMyAgentsSortBy? sortBy = default,
            global::DId.ListMyAgentsOrder? order = default,
            double? limit = default,
            string? token = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}