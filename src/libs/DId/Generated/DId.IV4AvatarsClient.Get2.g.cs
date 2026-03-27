#nullable enable

namespace DId
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// Get Video by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Get2Response> Get2Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}