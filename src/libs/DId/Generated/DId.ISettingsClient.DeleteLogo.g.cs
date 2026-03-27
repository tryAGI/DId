#nullable enable

namespace DId
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Delete logo
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLogoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}