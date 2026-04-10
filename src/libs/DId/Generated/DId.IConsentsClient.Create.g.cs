#nullable enable

namespace DId
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// Create a consent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CreateResponse8> CreateAsync(

            global::DId.CreateRequest3 request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a consent
        /// </summary>
        /// <param name="language">
        /// The language of the consent.<br/>
        /// Supported languages: Dutch, Turkish, Swedish, Indonesian, Filipino, Czech, Romanian, Danish, Malay, Slovak, Croatian, English, Polish, German, Spanish, French, Italian, Portuguese<br/>
        /// Example: english
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CreateResponse8> CreateAsync(
            string language,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}