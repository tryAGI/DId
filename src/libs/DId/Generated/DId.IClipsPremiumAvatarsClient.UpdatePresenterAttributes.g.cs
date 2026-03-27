#nullable enable

namespace DId
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Update a specific presenter attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdatePresenterAttributesAsync(
            string id,

            global::DId.AllOf<global::DId.UpdatePresenterAttributesRequestVariant1, global::DId.UpdatePresenterAttributesRequestVariant2, global::DId.UpdatePresenterAttributesRequestVariant3> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a specific presenter attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdatePresenterAttributesAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}