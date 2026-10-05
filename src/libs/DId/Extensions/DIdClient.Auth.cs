using System.Text;

namespace DId;

public partial class DIdClient
{
    /// <summary>
    /// Creates an authenticated D-ID client from an API key in API_USERNAME:API_PASSWORD format.
    /// </summary>
    public DIdClient(string apiKey)
        : this(
            authorizations:
            [
                new EndPointAuthorization
                {
                    Type = "Http",
                    SchemeId = "HttpBasic",
                    Location = "Header",
                    Name = "Basic",
                    Value = Convert.ToBase64String(Encoding.UTF8.GetBytes(
                        apiKey ?? throw new ArgumentNullException(nameof(apiKey)))),
                },
            ])
    {
    }
}
