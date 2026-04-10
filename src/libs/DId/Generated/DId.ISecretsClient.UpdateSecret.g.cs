#nullable enable

namespace DId
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Update a Secret<br/>
        /// Update an existing secret.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.UpdateSecretResponse> UpdateSecretAsync(
            string id,

            global::DId.AnyOf<global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?> request,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Secret<br/>
        /// Update an existing secret.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.UpdateSecretResponse> UpdateSecretAsync(
            string id,
            global::DId.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}