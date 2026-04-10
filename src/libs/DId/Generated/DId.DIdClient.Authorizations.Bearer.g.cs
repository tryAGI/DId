
#nullable enable

namespace DId
{
    public sealed partial class DIdClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "Http" &&
                    __authorization.Name == "Bearer")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::DId.EndPointAuthorization
            {
                Type = "Http",
                SchemeId = "HttpBearer",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}