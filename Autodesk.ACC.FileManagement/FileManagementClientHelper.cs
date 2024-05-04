using System.Net;
using Autodesk.ACC.FileManagement.Models;
using Autodesk.ACC.FileManagement.Projects.Item.Versions.Item.CustomAttributesBatchUpdate;


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
    /// <param name="fileVersionId">Id of the file version to update. Example: 'urn:adsk.wipprod:fs.file:vf.Efx_JwkDQkuOHB21T2v30w?version=1'</param>
    /// <param name="attributes">New attributes values. Only pass attributes that must be updated. Pass null for clearing an attribute</param>
    public async Task UpdateCustomAttributesAsync(string projectId, string folderId, string fileVersionId, List<(string Name, string Value)> attributes)
    {

        var existingAttributes = await GetAllCustomAttributeDefinitionAsync(projectId, folderId);

        var reqBody = new List<CustomAttributesBatchUpdate>();

        foreach (var attr in attributes)
        {
            var attributeId = existingAttributes.FirstOrDefault(a => string.Equals(a.Name, attr.Name, StringComparison.InvariantCultureIgnoreCase))?.Id;
            if (attributeId is null)
            {
                continue;
            }

            reqBody.Add(new CustomAttributesBatchUpdate
            {
                Id = attributeId,
                Value = attr.Value
            });
        }

        fileVersionId = WebUtility.UrlEncode(fileVersionId);

        await Api.Projects[projectId].Versions[fileVersionId].CustomAttributesBatchUpdate.PostAsync(reqBody);
    }


    /// <summary>
    /// Get all custom attribute definitions for an ACC/BIM360 folder
    /// </summary>
    /// <param name="projectId">ACC/BIM360 project id</param>
    /// <param name="folderId">Folder Id containing the file</param>
    /// <returns>List of Id, Name and type of the attribute</returns>
    /// <remarks>Handles the pagination of the underlying api</remarks>
    public async Task<List<CustomAttributeDefinitions_results>> GetAllCustomAttributeDefinitionAsync(string projectId, string folderId)
    {
        var allCustomAttributes = new List<CustomAttributeDefinitions_results>();

        var isLastPage = false;
        var offset = 0;

        while (isLastPage == false)
        {
            var customAttributes = await Api.Projects[projectId].Folders[folderId].CustomAttributeDefinitions.GetAsync((req) =>
            {
                req.QueryParameters.Limit = 200;
                req.QueryParameters.Offset = offset;
            });

            allCustomAttributes.AddRange(customAttributes?.Results ?? []);

            offset++;
            isLastPage = string.IsNullOrEmpty(customAttributes?.Pagination?.NextUrl);

        }

        return allCustomAttributes;

    }
}