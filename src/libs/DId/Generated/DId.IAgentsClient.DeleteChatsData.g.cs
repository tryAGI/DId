#nullable enable

namespace DId
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete chats<br/>
        /// Delete all chats for an agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DId.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteChatsDataAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}