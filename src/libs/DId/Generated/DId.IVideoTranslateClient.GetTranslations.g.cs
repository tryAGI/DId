#nullable enable

namespace DId
{
    public partial interface IVideoTranslateClient
    {
        /// <summary>
        /// Get Video Translates
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetTranslationsResponse2> GetTranslationsAsync(
            string? groupId = default,
            double? limit = default,
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}