#nullable enable

namespace DId
{
    public partial interface IChatsExportClient
    {
        /// <summary>
        /// Get chat logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DId.GetChatLogsResponse> GetChatLogsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}