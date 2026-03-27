#nullable enable

namespace DId
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Delete image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteImageAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}