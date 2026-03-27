#nullable enable

namespace DId
{
    public partial interface IVideoTranslateClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetGroupResponse2> GetGroupAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}