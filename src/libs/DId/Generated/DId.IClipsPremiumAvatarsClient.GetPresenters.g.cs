#nullable enable

namespace DId
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Get a list of the presenters
        /// </summary>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetPresentersResponse> GetPresentersAsync(
            double? limit = default,
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}