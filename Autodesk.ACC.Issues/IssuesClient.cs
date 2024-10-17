using Autodesk.ACC.Issues.Helpers;

namespace Autodesk.ACC.Issues;

public class IssuesClient
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IssuesClient"/> class.
    /// </summary>
    /// <param name="getAccessToken">Function for getting the access token used for the following calls</param>
    /// <param name="httpClient">Optional: Override the default HttpClient used for performing API calls</param>
    public IssuesClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseIssuesClient(adapter);
        Helper = new IssuesClientHelper(Api);
    }

    /// <summary>
    /// ACC Issues API client base path 'https://aps.autodesk.com/en/docs/acc/v1/reference/http/issues-users-me-GET/'
    /// </summary>
    public BaseIssuesClient Api { get; protected set; }

    /// <summary>
    /// High-level order functions supporting common operations
    /// </summary>
    public IssuesClientHelper Helper { get; protected set; }

}
