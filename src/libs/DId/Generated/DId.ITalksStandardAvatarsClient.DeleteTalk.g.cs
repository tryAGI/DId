#nullable enable

namespace DId
{
    public partial interface ITalksStandardAvatarsClient
    {
        /// <summary>
        /// Delete a specific talk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.DeleteTalkResponse> DeleteTalkAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}