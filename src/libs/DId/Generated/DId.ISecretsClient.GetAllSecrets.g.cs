#nullable enable

namespace DId
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// List Secrets<br/>
        /// Retrieve all secrets for the authenticated user.<br/>
        /// Returns a list of secrets with sanitized (masked) secret values.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DId.GetAllSecretsResponseItem>> GetAllSecretsAsync(
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}