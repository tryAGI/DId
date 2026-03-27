#nullable enable

namespace DId
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Get an avatar by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetResponse> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}