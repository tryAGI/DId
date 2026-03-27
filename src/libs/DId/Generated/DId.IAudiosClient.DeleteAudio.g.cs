#nullable enable

namespace DId
{
    public partial interface IAudiosClient
    {
        /// <summary>
        /// Delete an audio file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAudioAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}