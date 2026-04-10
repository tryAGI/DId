#nullable enable

namespace DId
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Create a Premium+ Avatar
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.TrainClipResponse> TrainClipAsync(

            global::DId.TrainClipRequest request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Premium+ Avatar
        /// </summary>
        /// <param name="sourceUrl">
        /// The source URL of the clip video to train, the video must be longer than 3 minutes and have a resolution higher than 0.5 megapixels.
        /// </param>
        /// <param name="name">
        /// A name for the avatar
        /// </param>
        /// <param name="gender">
        /// The gender of the presenter
        /// </param>
        /// <param name="consentId">
        /// Id of the related consent for the clip
        /// </param>
        /// <param name="webhook">
        /// The webhook to call when the training is done
        /// </param>
        /// <param name="config">
        /// Configuration options for the clip training
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.TrainClipResponse> TrainClipAsync(
            string sourceUrl,
            global::DId.TrainClipRequestGender gender,
            string? name = default,
            string? consentId = default,
            string? webhook = default,
            global::DId.TrainClipRequestConfig? config = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}