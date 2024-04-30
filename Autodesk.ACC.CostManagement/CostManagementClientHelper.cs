namespace Autodesk.ACC.CostManagement.Helpers;

public class CostManagementClientHelper
{
    public BaseCostManagementClient Api { get; init; }
    internal CostManagementClientHelper(BaseCostManagementClient api)
    {
        Api = api;
    }
}