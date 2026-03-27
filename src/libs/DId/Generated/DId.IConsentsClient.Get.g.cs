#nullable enable

namespace DId
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// Get a consent by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetResponse7> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}