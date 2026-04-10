#nullable enable

namespace DId
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Get face detection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetFaceDetectionResponse> GetFaceDetectionAsync(

            global::DId.GetFaceDetectionRequest request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get face detection
        /// </summary>
        /// <param name="sourceUrl"></param>
        /// <param name="shouldSkipDetection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetFaceDetectionResponse> GetFaceDetectionAsync(
            string sourceUrl,
            bool? shouldSkipDetection = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}