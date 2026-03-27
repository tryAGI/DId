#nullable enable

namespace DId
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Clone Voice<br/>
        /// Add a new voice to your collection of voices. Upload audio or video file to clone the voice from.<br/>
        /// For optimal voice cloning results, you should provide at least 30 seconds of diverse high-quality audio samples.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CloneVoiceResponse> CloneVoiceAsync(

            global::DId.CloneVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Voice<br/>
        /// Add a new voice to your collection of voices. Upload audio or video file to clone the voice from.<br/>
        /// For optimal voice cloning results, you should provide at least 30 seconds of diverse high-quality audio samples.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="language"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CloneVoiceResponse> CloneVoiceAsync(
            string name,
            string language,
            byte[]? file = default,
            string? filename = default,
            string? sourceUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}