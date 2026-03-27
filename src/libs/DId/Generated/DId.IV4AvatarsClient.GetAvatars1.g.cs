#nullable enable

namespace DId
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// List all of the expressive avatars
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetAvatars1Response> GetAvatars1Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}