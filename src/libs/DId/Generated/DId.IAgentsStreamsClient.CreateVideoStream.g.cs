#nullable enable

namespace DId
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Create a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>> CreateVideoStreamAsync(
            string agentId,
            string streamId,

            global::DId.CreateVideoStreamRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video stream
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="streamId"></param>
        /// <param name="sessionId"></param>
        /// <param name="script"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>> CreateVideoStreamAsync(
            string agentId,
            string streamId,
            global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptText2, global::DId.CreateVideoStreamRequestScriptAudio2> script,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}