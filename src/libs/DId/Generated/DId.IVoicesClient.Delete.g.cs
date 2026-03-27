#nullable enable

namespace DId
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete Voice<br/>
        /// Delete clone voice based on voice id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}