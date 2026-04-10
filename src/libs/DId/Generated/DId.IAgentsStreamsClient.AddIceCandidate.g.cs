#nullable enable

namespace DId
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Submit network information<br/>
        /// Updates the server with a WebRTC ICE candidate. If the candidate parameter is missing or a value of null is given the added ICE candidate is an "end-of-candidates" indicator.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AddIceCandidateResponse> AddIceCandidateAsync(
            string agentId,
            string streamId,

            global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2> request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit network information<br/>
        /// Updates the server with a WebRTC ICE candidate. If the candidate parameter is missing or a value of null is given the added ICE candidate is an "end-of-candidates" indicator.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AddIceCandidateResponse> AddIceCandidateAsync(
            string agentId,
            string streamId,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}