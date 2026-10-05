
#nullable enable

namespace DId
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Authorize using basic authentication.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>

        public void AuthorizeUsingBasic(
            string username,
            string password);
    }
}