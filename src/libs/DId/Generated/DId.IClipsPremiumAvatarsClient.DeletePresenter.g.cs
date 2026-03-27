#nullable enable

namespace DId
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Delete a presenter by its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePresenterAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}