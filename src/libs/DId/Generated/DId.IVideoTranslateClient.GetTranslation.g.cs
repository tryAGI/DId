#nullable enable

namespace DId
{
    public partial interface IVideoTranslateClient
    {
        /// <summary>
        /// Get a specific Video Translate
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetTranslationResponse2> GetTranslationAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}