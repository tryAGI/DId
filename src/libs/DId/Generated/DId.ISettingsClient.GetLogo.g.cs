#nullable enable

namespace DId
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Get logo
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetLogoResponse2> GetLogoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}