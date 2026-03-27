#nullable enable

namespace DId
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get an Agent<br/>
        /// Returns details for a specific Agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}