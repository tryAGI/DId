#nullable enable

namespace DId
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete an Agent<br/>
        /// Deletes an existing Agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>> DeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}