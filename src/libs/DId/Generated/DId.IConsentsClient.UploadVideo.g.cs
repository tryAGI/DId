#nullable enable

namespace DId
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// Upload video for consent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.UploadVideoResponse> UploadVideoAsync(
            string id,

            global::DId.UploadVideoRequest request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload video for consent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="name"></param>
        /// <param name="webhook"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.UploadVideoResponse> UploadVideoAsync(
            string id,
            string sourceUrl,
            string name,
            string? webhook = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}