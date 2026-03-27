#nullable enable

namespace DId
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Create a Secret
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CreateSecretResponse> CreateSecretAsync(

            global::DId.AnyOf<global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secret
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.CreateSecretResponse> CreateSecretAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}