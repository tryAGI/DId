#nullable enable

namespace DId
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Get Secret by ID<br/>
        /// Retrieve a specific secret by its ID.<br/>
        /// Returns the secret with a sanitized (masked) secret value.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetSecretByIdResponse> GetSecretByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}