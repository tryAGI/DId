#nullable enable

namespace DId
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Delete a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.DeleteStreamResponse> DeleteStreamAsync(
            string agentId,
            string streamId,

            global::DId.DeleteStreamRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.DeleteStreamResponse> DeleteStreamAsync(
            string agentId,
            string streamId,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}