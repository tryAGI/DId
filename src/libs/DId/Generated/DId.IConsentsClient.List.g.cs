#nullable enable

namespace DId
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// list all consents for the user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.ListResponse> ListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}