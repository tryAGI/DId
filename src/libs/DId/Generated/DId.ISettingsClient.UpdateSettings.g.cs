#nullable enable

namespace DId
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Update settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.UpdateSettingsResponse> UpdateSettingsAsync(

            global::DId.UpdateSettingsRequest request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update settings
        /// </summary>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="logo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.UpdateSettingsResponse> UpdateSettingsAsync(
            bool? agentsInsightsIsEnabled = default,
            global::DId.UpdateSettingsRequestLogo? logo = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}