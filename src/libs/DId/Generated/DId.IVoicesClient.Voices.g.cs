#nullable enable

namespace DId
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voices
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DId.VoicesResponseItem>> VoicesAsync(
            global::DId.VoicesProvider? provider = default,
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}