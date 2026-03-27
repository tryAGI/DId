#nullable enable

namespace DId
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Get presenter drivers by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetPresenterDriversByIdResponse> GetPresenterDriversByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}