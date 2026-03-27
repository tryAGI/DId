#nullable enable

namespace DId
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// Get avatar by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>> GetAvatarByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}