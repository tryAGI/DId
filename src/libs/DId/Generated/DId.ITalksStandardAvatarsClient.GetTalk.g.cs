#nullable enable

namespace DId
{
    public partial interface ITalksStandardAvatarsClient
    {
        /// <summary>
        /// Get a specific talk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetTalkResponse> GetTalkAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}