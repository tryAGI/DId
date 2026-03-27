#nullable enable

namespace DId
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get credits<br/>
        /// Get the user's credits items each credit item contains the remaining and total credits for the user<br/>
        /// With the time expiration of the credits
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetCreditsResponse> GetCreditsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}