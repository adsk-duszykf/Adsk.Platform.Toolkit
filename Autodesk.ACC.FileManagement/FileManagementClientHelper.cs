using Autodesk.ACC.FileManagement.Models;
using Autodesk.ACC.FileManagement.Projects.Item.Versions.Item.CustomAttributesBatchUpdate;
using CommonUtils;


namespace Autodesk.ACC.FileManagement.Helpers;

public class FileManagementClientHelper
{
    public BaseFileManagementClient Api { get; init; }
    internal FileManagementClientHelper(BaseFileManagementClient api)
    {
        Api = api;
    }

    /// <summary>
    /// Update custom attributes for a file version
    /// </summary>
    /// <param name="projectId">Id of the ACC/BIM360 project storing the file version to update. Example: 'c0337487-5b66-422b-a284-c273b424af54' </param>
    /// <param name="folderId">Id of the folder containing the file version to update.</param>
    /// <param name="fileVersionId">Id of the file version to update. Example: 'urn:adsk.wipprod:fs.file:vf.C_U3fVV_RMi4o9W-ve4LwQ?version=2'</param>
    /// <param name="attributes">New attributes values. Only pass attributes that must be updated. Pass null for clearing an attribute</param>
    public async Task<List<AttributeUpdateError>> UpdateCustomAttributesAsync(string projectId, string folderId, string fileVersionId, List<(string Name, string Value)> attributes)
    {

        var ACC_Attributes = await GetAllCustomAttributeDefinitionAsync(projectId, folderId);

        var attributesToUpdate = new List<CustomAttributesBatchUpdate>();

        var errors = new List<AttributeUpdateError>();

        //Include in the payload only attributes that exists
        foreach (var attr in attributes)
        {
            var ACC_Attribute = FindMatchingACC_Attribute(ACC_Attributes, attr);

            if (ACC_Attribute is null)
            {
                errors.Add(new AttributeUpdateError(attr, "Not found"));
                continue;
            }

            var (newAttributeValue, errorMsg) = GetFormatedAttributeValue(ACC_Attribute, attr.Value);

            if (errorMsg != string.Empty)
            {
                errors.Add(new AttributeUpdateError(attr, errorMsg));
                continue;
            }

            attributesToUpdate.Add(new CustomAttributesBatchUpdate
            {
                Id = ACC_Attribute?.Id,
                Value = newAttributeValue
            });
        }

        //No attribute to update
        if (attributesToUpdate.Count == 0)
        {
            return errors;
        }

        await Api.Projects[projectId].Versions[fileVersionId].CustomAttributesBatchUpdate.PostAsync(attributesToUpdate);

        return errors;
    }

    public record AttributeUpdateError((string Name, string Value) attribute, string error);

    /// <summary>
    /// Get all custom attribute definitions for an ACC/BIM360 folder
    /// </summary>
    /// <param name="projectId">ACC/BIM360 project id</param>
    /// <param name="folderId">Folder Id containing the file</param>
    /// <returns>List of Id, Name and type of the attribute</returns>
    /// <remarks>Handles the pagination of the underlying api</remarks>
    public async Task<List<CustomAttributeDefinitions_results>> GetAllCustomAttributeDefinitionAsync(string projectId, string folderId)
    {
        return await GetCustomAttributeDefinitionAsync(projectId, folderId).GetAll();
    }

    /// <summary>
    /// Get all custom attribute definitions for an ACC/BIM360 folder
    /// </summary>
    /// <param name="projectId">ACC/BIM360 project id</param>
    /// <param name="folderId">Folder Id containing the file</param>
    /// <returns>Stream of Id, Name and type of the attribute</returns>
    /// <remarks>Handles the pagination of the underlying api</remarks>
    public async IAsyncEnumerable<CustomAttributeDefinitions_results> GetCustomAttributeDefinitionAsync(string projectId, string folderId)
    {
        var allCustomAttributes = new List<CustomAttributeDefinitions_results>();

        var isLastPage = false;
        var offset = 0;

        while (isLastPage == false)
        {
            var customAttributes = (await Api.Projects[projectId].Folders[folderId].CustomAttributeDefinitions.GetAsync((req) =>
            {
                req.QueryParameters.Limit = 200;
                req.QueryParameters.Offset = offset;
            }));

            foreach (var attr in customAttributes?.Results ?? [])
            {
                yield return attr;
            }

            offset++;
            isLastPage = string.IsNullOrEmpty(customAttributes?.Pagination?.NextUrl);

        }

    }
    static CustomAttributeDefinitions_results? FindMatchingACC_Attribute(List<CustomAttributeDefinitions_results> ACC_Attributes, (string Name, string Value) searchedAttribute)
    {
        var existingAttribute = ACC_Attributes.FirstOrDefault(a => string.Equals(a.Name, searchedAttribute.Name, StringComparison.InvariantCultureIgnoreCase));


        return existingAttribute;
    }
    static (string formatedValue, string error) GetFormatedAttributeValue(CustomAttributeDefinitions_results? ACC_Attribute, string newValue)
    {
        var errorMsg = string.Empty;
        switch (ACC_Attribute?.Type)
        {
            case CustomAttributeDefinitions_results_type.String:
                if (newValue.Length > 255) errorMsg = "For text field (string) attributes, the max length is 255";
                break;
            case CustomAttributeDefinitions_results_type.Date:
                if (DateTime.TryParse(newValue, out var date))
                {
                    newValue = date.ToString();
                }
                else
                {
                    errorMsg = "Date attributes need to be compliant with ISO8601 like '2023-05-24T14:25:00'";
                }
                break;
            case CustomAttributeDefinitions_results_type.Array:
                var matchingDropDownLitValue = ACC_Attribute.ArrayValues?.FirstOrDefault(v => string.Equals(v, newValue, StringComparison.InvariantCultureIgnoreCase));
                if (matchingDropDownLitValue is null)
                {
                    errorMsg = $"Possible values are '{string.Join("; ", ACC_Attribute.ArrayValues ?? [])}'";
                }
                else
                {
                    newValue = matchingDropDownLitValue;
                }
                break;
            default:
                break;
        }

        return (newValue, errorMsg);
    }

}