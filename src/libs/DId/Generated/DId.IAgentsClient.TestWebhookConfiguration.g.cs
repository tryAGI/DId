#nullable enable

namespace DId
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Test Webhook<br/>
        /// Test a webhook configuration by sending a mock event payload<br/>
        /// This endpoint allows users to validate their webhook URL and authentication<br/>
        /// before configuring it on an agent trigger
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.TestWebhookResponseDto> TestWebhookConfigurationAsync(

            global::DId.TestWebhookConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook<br/>
        /// Test a webhook configuration by sending a mock event payload<br/>
        /// This endpoint allows users to validate their webhook URL and authentication<br/>
        /// before configuring it on an agent trigger
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="url">
        /// a valid url that starts with http or https with regex<br/>
        /// Example: https://example.com
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for tools and webhooks (processed/stored)
        /// </param>
        /// <param name="headers"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DId.TestWebhookResponseDto> TestWebhookConfigurationAsync(
            string url,
            global::DId.TestWebhookConfigurationRequestEventType eventType = default,
            global::DId.TestWebhookConfigurationRequestAuth? auth = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}