#nullable enable

namespace DId
{
    public partial interface ITalksStandardAvatarsClient
    {
        /// <summary>
        /// Delete a specific talk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.DeleteTalkResponse> DeleteTalkAsync(
            string id,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}