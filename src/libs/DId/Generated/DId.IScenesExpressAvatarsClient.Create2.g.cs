#nullable enable

namespace DId
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Create a Scene
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Create2Response> Create2Async(

            global::DId.Create2Request request,
            string? xApiKeyExternal = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Scene
        /// </summary>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="avatarId">
        /// The avatar that will be used to create the scene.
        /// </param>
        /// <param name="script"></param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including scene details.<br/>
        /// In a case of empty value, the webhook will not be triggered.<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the scene
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the scene, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="background">
        /// Background color of the scene result, can only be used for avatars with green screen background
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.Create2Response> Create2Async(
            string avatarId,
            global::DId.AnyOf<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio> script,
            string? xApiKeyExternal = default,
            string? webhook = default,
            string? userData = default,
            string? name = default,
            string? resultUrl = default,
            global::DId.Create2RequestConfig? config = default,
            global::DId.Create2RequestBackground? background = default,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}