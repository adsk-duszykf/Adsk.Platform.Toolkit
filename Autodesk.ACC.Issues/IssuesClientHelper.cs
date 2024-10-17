namespace Autodesk.ACC.Issues.Helpers;

public class IssuesClientHelper
{
    public BaseIssuesClient Api { get; init; }
    internal IssuesClientHelper(BaseIssuesClient api)
    {
        Api = api;
    }

}