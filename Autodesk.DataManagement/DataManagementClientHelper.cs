using Autodesk.DataManagement.Data.V1;
using Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Contents;
using Autodesk.DataManagement.Helpers.Models;
using Autodesk.DataManagement.OSS;
using Autodesk.DataManagement.OSS.Models;
using Autodesk.DataManagement.OSS.Oss.V2;
using Microsoft.Kiota.Abstractions;
using SDKmodels = Autodesk.DataManagement.Models;

namespace Autodesk.DataManagement.Helpers;

public class DataManagementClientHelper
{
    private readonly HttpClient httpClient = new();
    private readonly V1RequestBuilder _dataMgtClient;
    private readonly V2RequestBuilder _ossClient;
    private static readonly char[] separator = ['\\', '/'];

    public BaseDataManagementClient DataMgtApi { get; init; }
    public BaseOSSClient OssApi { get; init; }
    internal DataManagementClientHelper(BaseDataManagementClient dataMgtApi, BaseOSSClient ossApi)
    {
        DataMgtApi = dataMgtApi;
        OssApi = ossApi;
        _dataMgtClient = dataMgtApi.Data.V1;
        _ossClient = ossApi.Oss.V2;
    }
    /// <summary>
    /// Download file version from ACC/BIM360
    /// </summary>
    /// <param name="projectId">Id of the project. The prefix 'b.' is handled automatically</param>
    /// <param name="fileVersionUrn">Id of the file version</param>
    /// <returns>File content</returns>
    public async Task<Stream> DownloadFileVersionAsync(string projectId, string fileVersionUrn)
    {
        projectId = FixProjectId(projectId);

        var fileVersion = await _dataMgtClient.Projects[projectId].Versions[fileVersionUrn].GetAsync();

        var storageUrl = (fileVersion?.Data?.Relationships?.Storage?.Meta?.Link?.Href)
                            ?? throw new InvalidOperationException("Storage url is null");

        return await DownloadFromStorageAsync(storageUrl);
    }

    /// <summary>
    /// Download file version from ACC/BIM360
    /// </summary>
    /// <param name="projectId">Id of the project. The prefix 'b.' is handled automatically</param>
    /// <param name="itemUrn">Id of the file item</param>
    /// <param name="version">Version number starting at 1</param>
    /// <returns>File content</returns>
    public async Task<Stream> DownloadFileVersionAsync(string projectId, string itemUrn, int version)
    {
        projectId = FixProjectId(projectId);

        var item = await _dataMgtClient.Projects[projectId].Items[itemUrn].GetAsync();

        var fileVersion = await _dataMgtClient.Projects[projectId].Items[itemUrn].Versions
                                    .GetAsync(r => { r.QueryParameters.FilterversionNumber = [version]; });

        var storageUrl = (fileVersion?.Data?.FirstOrDefault()?.Relationships?.Storage?.Meta?.Link?.Href)
                            ?? throw new InvalidOperationException("Storage url is null");

        return await DownloadFromStorageAsync(storageUrl);
    }

    /// <summary>
    /// Download the latest file version from ACC/BIM360
    /// </summary>
    /// <param name="projectId">Id of the project. The prefix 'b.' is handled automatically</param>
    /// <param name="itemUrn">Id of the file item</param>
    /// <returns>File content</returns>
    public async Task<Stream> DownloadLatestFileVersionAsync(string projectId, string itemUrn)
    {
        projectId = FixProjectId(projectId);

        var item = await _dataMgtClient.Projects[projectId].Items[itemUrn].GetAsync();

        var storageUrl = (item?.Included?.FirstOrDefault()?.Relationships?.Storage?.Meta?.Link?.Href)
                            ?? throw new InvalidOperationException("Storage url is null");

        return await DownloadFromStorageAsync(storageUrl);
    }

    /// <summary>
    /// Download file from storage url
    /// </summary>
    /// <param name="storageUrl"></param>
    /// <returns>File content</returns>
    public async Task<Stream> DownloadFromStorageAsync(string storageUrl)
    {
        var storageUrlAsUri = new Uri(storageUrl);
        var bucketKey = storageUrlAsUri.Segments[4].TrimEnd('/');
        var objectKey = storageUrlAsUri.Segments[6];

        var signedUrlInfo = await _ossClient.Buckets[bucketKey].Objects[objectKey].Signeds3download.GetAsync();

        var signedUrl = signedUrlInfo?.Url ?? throw new InvalidOperationException();

        return await httpClient.GetStreamAsync(signedUrl);
    }

    public async Task<IdNameMap> GetFileItemByPathAsync(string filePath)
    {
        string[] folders = filePath.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        var subFolderPath = string.Join(separator.First(), folders.SkipLast(1).ToArray());

        var folder = await GetFolderByPathAsync(subFolderPath);

        //Search for the file
        var fileName = folders.Last();
        var projectId = FixProjectId(folder.Project.Id);
        var parentFolderId = folder.Folders.Last().Id;

        var fileVersions = await GetFileItemIdsByFolderIdAsync(projectId, parentFolderId);

        var file = fileVersions.FirstOrDefault(f => string.Equals(f.Name, fileName, StringComparison.InvariantCultureIgnoreCase));

        return file is null ? throw new InvalidOperationException($"File '{fileName}' not found in folder '{folder.Folders.Last().Name}'") : file;
    }

    /// <summary>
    /// Return the ids of all elemeents in the path
    /// </summary>
    /// <param name="folderPath"></param>
    /// <returns>The ids of all elemeents in the path </returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<FolderPath> GetFolderByPathAsync(string folderPath)
    {
        var subFolderList = new SubFolderList();

        string[] folders = folderPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        if (folders.Length < 3)
            throw new InvalidOperationException("Invalid file path. Path must be like '{AccountName}\\{ProjectName}\\{FolderNames}\\{FileName}'");

        //Get the hub and project
        var hubName = folders[0];
        var projectName = folders[1];

        var projectIdsByName = (await GetProjectIdsByNameAsync(hubName, projectName));

        var hubId = projectIdsByName.hubId;

        var projects = projectIdsByName.projects;

        if (projects.Count == 0)
            throw new InvalidOperationException($"Project '{projectName}' not found in hub '{hubName}'");

        if (projects.Count > 1)
            throw new InvalidOperationException($"'{projects.Count}' found with the name '{projectName}' in hub '{hubName}'. This method assumes the 'projectName' is unique");

        var projectId = FixProjectId(projects[0].projectId);

        //Get the top folder
        var topFolderName = folders[2];
        var topFolders = await DataMgtApi.Project.V1.Hubs[hubId].Projects[projectId].TopFolders.GetAsync();

        var topFolder = topFolders?.Data?.FirstOrDefault(f => string.Equals(f?.Attributes?.Name, topFolderName, StringComparison.InvariantCultureIgnoreCase));

        if (topFolder is null)
            throw new InvalidOperationException($"Folder '{topFolderName}' not found in project '{projectName}'");

        var folderIds = new List<IdNameMap>() { new() { Name = topFolderName, Id = topFolder.Id ?? "" } };

        //Go through the sub folders
        var firstSubFolderPathPosition = 3;

        for (int i = firstSubFolderPathPosition; i < folders.Length; i++)
        {
            var subFolders = await GetAllSubFoldersAsync(projectId, folderIds.Last().Id);

            var subFolderName = folders[i];

            var folder = subFolders.FirstOrDefault(f => string.Equals(f.Name, subFolderName, StringComparison.InvariantCultureIgnoreCase));

            if (folder?.Id is null)
                throw new InvalidOperationException($"Folder '{subFolderName}' not found in folder '{folders[^(i - 1)]}'");

            folderIds.Add(folder);
        }

        //Format result
        var hub = new IdNameMap { Name = hubName, Id = hubId };
        var project = new IdNameMap { Name = projectName, Id = projectId };

        return new FolderPath
        {
            Hub = hub,
            Project = project,
            Folders = folderIds,
        };
    }

    /// <summary>
    /// Return the ids of all sub folders 
    /// </summary>
    /// <param name="folderPath"></param>
    /// <returns>Sub folders name and their id</returns>
    /// <remarks>Not recursive</remarks>
    public async Task<(FolderPath Folder, List<IdNameMap> SubFolders)> GetAllSubFoldersByPathAsync(string folderPath)
    {
        (FolderPath Folder, List<IdNameMap> SubFolders) result = (new FolderPath(), new List<IdNameMap>());
        result.Folder = await GetFolderByPathAsync(folderPath);

        result.SubFolders = await GetAllSubFoldersAsync(result.Folder.Project.Id, result.Folder.Folders.Last().Id);

        return result;
    }

    /// <summary>
    /// Return the ids of the files in a folder
    /// </summary>
    /// <param name="folderPath"></param>
    /// <returns></returns>
    public async Task<(FolderPath Folder, List<IdNameMap> Files)> GetAllFilesByFolderPathAsync(string folderPath)
    {

        var folder = await GetFolderByPathAsync(folderPath);

        var files = await GetFileItemIdsByFolderIdAsync(folder.Project.Id, folder.Folders.Last().Id);

        return (folder, files.ToList());
    }

    /// <summary>
    /// Return the ids of all sub folders
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="parentFolderId"></param>
    /// <returns>List of folder path and their ids</returns>
    /// <remarks>Not recursive</remarks>
    public async Task<List<IdNameMap>> GetAllSubFoldersAsync(string projectId, string parentFolderId)
    {
        projectId = FixProjectId(projectId);

        var isLastPage = false;

        var subFolders = new List<IdNameMap>();

        var pageNumber = 0;

        while (isLastPage == false)
        {
            subFolders.AddRange(await GetSubFolderByPage(pageNumber));

            pageNumber++;
        }

        return subFolders;

        async Task<List<IdNameMap>> GetSubFolderByPage(int pageNumber)
        {
            var subFolders = await _dataMgtClient.Projects[projectId].Folders[parentFolderId].Contents
                                        .GetAsync(r =>
                                        {
                                            r.QueryParameters.FilterextensionType = ["folders"];
                                            r.QueryParameters.Pagenumber = pageNumber;
                                        });

            isLastPage = subFolders?.Links?.Next is null;

            return subFolders?.Data?.Select(f => new IdNameMap { Id = f.Id ?? "", Name = f?.Attributes?.Name ?? "" }).ToList() ?? [];
        }

    }

    /// <summary>
    /// Return the hub ids
    /// </summary>
    /// <param name="hubName">Name of the hub</param>
    /// <returns>Hub Id</returns>
    public async Task<List<string>> GetHubIdByNameAsync(string hubName)
    {
        var hubs = await DataMgtApi.Project.V1.Hubs.GetAsync(r => { r.QueryParameters.FilterattributesName = hubName; });

        return hubs?.Data?.Select(h => h.Id ?? "")?.ToList() ?? [];

    }

    /// <summary>
    /// Return the ids of all projects with the same name in a hub
    /// </summary>
    /// <param name="hubName"></param>
    /// <param name="projectName"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<(string hubId, List<(string projectId, string projectName)> projects)> GetProjectIdsByNameAsync(string hubName, string projectName)
    {
        var hubs = await GetHubIdByNameAsync(hubName);

        if (hubs.Count == 0)
            throw new InvalidOperationException($"Hub '{hubName}' not found");

        if (hubs.Count > 1)
            throw new InvalidOperationException($"'{hubs.Count}' hubs found with the name '{hubName}'. This method assumes the 'hubName' is unique");

        var hubId = hubs[0];

        var allProjects = (await GetAllProjectsByHubIdAsync(hubId)).projects.Where(p => string.Equals(p.projectName, projectName, StringComparison.InvariantCultureIgnoreCase)); ;

        return (hubId, allProjects.ToList());

    }

    /// <summary>
    /// Get all projects in a hub
    /// </summary>
    /// <param name="hubId">The id of the hub</param>
    /// <returns>List of project Id</returns>
    public async Task<(string hubId, List<(string projectId, string projectName)> projects)> GetAllProjectsByHubIdAsync(string hubId)
    {
        var pageNumber = 0;
        var isLastPage = false;
        var projects = new List<(string projectId, string projectName)>();

        while (isLastPage == false)
        {
            projects.AddRange(await getProjects(pageNumber));
            pageNumber++;
        }


        return (hubId, projects);


        async Task<List<(string projectId, string projectName)>> getProjects(int pageNumber)
        {
            var projects = await DataMgtApi.Project.V1.Hubs[hubId].Projects.GetAsync(r => { r.QueryParameters.Pagenumber = pageNumber; });

            isLastPage = projects?.Links?.Next is null;

            return projects?.Data?.Select(p => (p.Id ?? "", p.Attributes?.Name ?? ""))?.ToList() ?? [];
        }

    }

    /// <summary>
    /// Get all projects in a hub
    /// </summary>
    /// <param name="hubName">Name of the hub</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"> <para>hubName</para> is not unique or not found</exception>
    public async Task<(string hubId, List<(string projectId, string projectName)> projects)> GetAllProjectsByHubNameAsync(string hubName)
    {
        var hubs = await GetHubIdByNameAsync(hubName);

        if (hubs.Count == 0)
            throw new InvalidOperationException($"Hub {hubName} not found");

        if (hubs.Count > 1)
            throw new InvalidOperationException($"{hubs.Count} found with the name '{hubName}'. This method assumes the 'hubName' is unique");

        var hubId = hubs[0];

        return await GetAllProjectsByHubIdAsync(hubId);

    }


    /// <summary>
    /// Get file items from a folder (not recursive)
    /// </summary>
    /// <param name="projectId">Project Id. Prefix 'b.' is handled</param>
    /// <param name="folderId">Folder urn like: <c>urn:adsk.wipprod:dm.folder:hC6k4hndRWaeIVhIjvHu8w</c></param>
    /// <param name="fileExtensions">File extensions filter</param>
    /// <returns>List of file items</returns>
    public async Task<IEnumerable<IdNameMap>> GetFileItemIdsByFolderIdAsync(string projectId, string folderId, IEnumerable<string>? fileExtensions = null)
    {
        projectId = FixProjectId(projectId);

        var folderContents = await _dataMgtClient.Projects[projectId].Folders[folderId].Contents
                                .GetAsync(r =>
                                {
                                    r.QueryParameters.FiltertypeAsGetFilterTypeQueryParameterType = [GetFilterTypeQueryParameterType.Items];
                                    r.QueryParameters.FilterextensionType = ["items:autodesk.bim360:File"];
                                });

        var fileIds = folderContents?.Data?
            .Select(c =>
        {
            if (c?.Attributes?.DisplayName is null || c?.Id is null)
                throw new InvalidOperationException("Invalid file");

            return new IdNameMap()
            {
                Name = c.Attributes.DisplayName,
                Id = c.Id
            };
        }) ?? [];

        if (fileExtensions is null || !fileExtensions.Any())
        {
            return fileIds;
        }

        fileIds = fileIds.Where(file => fileExtensions.Any(ext => file.Name.EndsWith(ext, StringComparison.CurrentCultureIgnoreCase)));

        return fileIds;
    }

    /// <summary>
    /// Upload file by chunks to a bucket
    /// </summary>
    /// <param name="bucketId">File destination</param>
    /// <param name="uniqueFileName">Unique file name like {{GUID}}.ifc</param>
    /// <param name="fileContent">Content of the file to upload</param>
    /// <param name="defaultChunkSize">Optional: Chunk size in bytes value 10 000 000</param>
    /// <returns>Upload results</returns>
    /// <exception cref="InvalidDataException">No signed url was created</exception>
    public async Task<Completes3upload_response_200> UploadFileAsync(string bucketId, string uniqueFileName, Stream fileContent, int defaultChunkSize = 10000000)
    {
        var fileChunks = await CreateFIleChunks(fileContent, defaultChunkSize);

        //Create signed urls
        var signedUrls = await _ossClient.Buckets[bucketId].Objects[uniqueFileName].Signeds3upload.GetAsync(r => { r.QueryParameters.Parts = fileChunks.Count; });

        if (signedUrls?.Urls is null)
        {
            throw new InvalidDataException("SignedUrls is null");
        }

        //Upload the file by chunks in parallel
        fileContent.Position = 0;
        var uploadTasks = new List<Task<HttpResponseMessage>>();

        for (int i = 0; i < fileChunks.Count; i++)
        {
            var url = signedUrls.Urls[i];

            var uploadTask = httpClient.PutAsync(url, new ByteArrayContent(fileChunks[i]));

            uploadTasks.Add(uploadTask);
        }

        await Task.WhenAll(uploadTasks);

        //Complete the upload
        var result = await _ossClient.Buckets[bucketId].Objects[uniqueFileName].Signeds3upload
            .PostAsync(
                new()
                {
                    UploadKey = signedUrls.UploadKey
                });

        return result ?? new Completes3upload_response_200();
    }

    /// <summary>
    /// Create a new file version in a ACC/BIM360 folder. If the file exists, create a new version. 
    /// </summary>
    /// <param name="projectId">Project Id. Prefix 'b.' handled automatically</param>
    /// <param name="folderId">Folder id like: </param>
    /// <param name="fileName">File name as displayed in ACC/BIM360</param>
    /// <param name="fileContent"></param>
    /// <param name="defaultChunkSize">Optional: Chunk size in bytes value 10 000 000</param>
    /// <returns>File item id and version Id of the file version created in ACC/BIM360</returns>
    /// <exception cref="InvalidDataException">Upload failed</exception>
    /// <exception cref="InvalidOperationException">Version creation failed</exception>
    public async Task<(string fileItemId, string versionId)> UploadFileAsync(string projectId, string folderId, string fileName, Stream fileContent, int defaultChunkSize = 10000000)
    {
        var newVersion = await UploadNewVersionAsync(projectId, folderId, fileName, fileContent, defaultChunkSize);
        if (newVersion?.ObjectId is null || newVersion?.ObjectKey is null)
        {
            throw new InvalidDataException();
        }
        var items = await GetFileItemIdsByFolderIdAsync(projectId, folderId);

        var fileItem = items.FirstOrDefault(i => string.Equals(i.Name, fileName, StringComparison.InvariantCultureIgnoreCase));

        var versionId = string.Empty;
        var fileItemId = string.Empty;

        if (fileItem is null)
        {
            var result = await CreateNewFileAsync(projectId, folderId, newVersion.ObjectId, fileName);
            fileItemId = result?.Data?.Id ?? throw new InvalidOperationException("File id is null");
            versionId = result?.Included?.FirstOrDefault()?.Id ?? throw new InvalidOperationException("Version id is null");
        }
        else
        {
            var result = await UpdateFileAsync(projectId, fileItem.Id, fileName, newVersion.ObjectId);
            versionId = result?.Data?.Id ?? throw new InvalidOperationException("Version id is null");
            fileItemId = result?.Included?.FirstOrDefault()?.Id ?? throw new InvalidOperationException("File id is null");
        }

        return (fileItemId, versionId);
    }

    /// <summary>
    /// Use Search endpoint to search for files in a folder recursively based on advanced search filters
    /// </summary>
    /// <param name="projectId">Project Id. Prefix 'b.' is handled</param>
    /// <param name="folderId">Folder urn like: <c>urn:adsk.wipprod:dm.folder:hC6k4hndRWaeIVhIjvHu8w</c></param>
    /// <param name="filters">List of filters used as query parameters like: ("filter[fileTYpe]","rvt,mwd") <see href="https://aps.autodesk.com/en/docs/data/v2/developers_guide/filtering/"/></param>
    /// <returns>First 100 search results. Use page[number] to get the next results</returns>
    /// <remarks>Required 3 legged authentication</remarks>
    public async Task<SDKmodels.Search?> SearchAdvancedAsync(string projectId, string folderId, List<(string Name, string Value)> filters)
    {
        projectId = FixProjectId(projectId);

        var requestInfo = _dataMgtClient.Projects[projectId].Folders[folderId].Search.ToGetRequestInformation();

        var searchWithFiltersURI = CreateRequestWithFilters(requestInfo, filters);

        var searchResult = await _dataMgtClient.Projects[projectId].Folders[folderId].Search.WithUrl(searchWithFiltersURI).GetAsync();

        return searchResult;
    }

    /// <summary>
    /// Update the request URI with advanced search filters that includes comparison type or custom filter like 'filter[fileType]=rvt,jpg&amp;filter[attributes.fileName]-contains=Floor'
    /// </summary>
    /// <param name="requestInfo">The request info for the original endpoint. Use 'ToGetRequestInformation()' to retrieve it </param>
    /// <param name="filters">Filters to include as query parameters</param>
    /// <returns>New URL combining the original one and filters</returns>
    public string CreateRequestWithFilters(RequestInformation requestInfo, List<(string Name, string Value)> filters)
    {
        var uriBuilder = new UriBuilder(requestInfo.URI);
        var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);

        foreach (var filter in filters)
        {
            query.Add(filter.Name, filter.Value);
        }

        uriBuilder.Query = query.ToString();

        return uriBuilder.Uri.AbsoluteUri;
    }

    /// <summary>
    /// Search for files in a folder recursively and return the latest version of each file
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="folderId"></param>
    /// <param name="skipDeleted">(Optional) Ignore deleted files</param>
    /// <param name="filters">(Optional) Query string like: 'filter[fileType]=txt,jpg'.See documentation https://aps.autodesk.com/en/docs/data/v2/developers_guide/filtering/. </param>
    /// <returns>List of file version</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<List<FileVersion>> SearchLatestFileVersionAsync(string projectId, string folderId, bool skipDeleted = true, List<(string Name, string Value)>? filters = null)
    {
        List<(string Name, string Value)> customFilters = filters is null ? [] : [.. filters];
        customFilters.RemoveAll(f => f.Name.StartsWith("page[number]", StringComparison.InvariantCultureIgnoreCase));

        var fileIds = new List<FileVersion>();

        projectId = FixProjectId(projectId);

        var isLastPage = false;
        var pageNumber = 0;
        while (isLastPage == false)
        {
            var newFileIds = await searchByPageAsync(pageNumber);
            fileIds.AddRange(newFileIds);

            //isLastPage updated in the function searchByPageAsync

            pageNumber++;

        }

        return fileIds;

        //Search for files in a folder recursively and return the latest version of each file
        async Task<List<FileVersion>> searchByPageAsync(int page)
        {

            var folderContents = await SearchAdvancedAsync(projectId, folderId, [("page[number]", page.ToString()), .. customFilters]);
            var files = folderContents?.Included ?? [];
            if (skipDeleted)
            {
                files = files.Where(f => f.Attributes?.Hidden == false).ToList();
            }

            var fileIds = files.Select(c =>
            {
                if (c?.Attributes?.DisplayName is null || c?.Id is null)
                    throw new InvalidOperationException("Invalid file");

                var parentFolderId = c.Relationships?.Parent?.Data?.Id;

                return new FileVersion(parentFolderId, c.Attributes.DisplayName, c?.Relationships?.Tip?.Data?.Id ?? throw new InvalidOperationException("File Version urn is null"));
            });

            isLastPage = folderContents?.Links?.Next is null;

            return fileIds?.ToList() ?? [];
        }

    }

    /// <summary>
    /// Get files in a folder (not recursive) and return the latest version of each file
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="folderId"></param>
    /// <param name="filters"></param>
    /// <remarks>Use search for recursive search</remarks>
    /// <returns>List of file version</returns>
    /// <exception cref="InvalidOperationException">Unexpected output</exception>
    public async Task<List<FileVersion>> GetLatestFilesVersionAsync(string projectId, string folderId, List<(string Name, string Value)>? filters = null)
    {
        List<(string Name, string Value)> customFilters = filters is null ? [] : [.. filters];
        customFilters.RemoveAll(f => f.Name.StartsWith("page[number]", StringComparison.InvariantCultureIgnoreCase));
        customFilters.RemoveAll(f => f.Name.StartsWith("filter[extension.type]", StringComparison.InvariantCultureIgnoreCase));

        customFilters.Add(("filter[extension.type]", "items:autodesk.bim360:File"));

        projectId = FixProjectId(projectId);

        var fileIds = new List<FileVersion>();

        var isLastPage = false;
        var pageNumber = 0;
        while (isLastPage == false)
        {
            var newFileIds = await getFolderContentByPageAsync(pageNumber);
            fileIds.AddRange(newFileIds);

            pageNumber++;
        }

        return fileIds;

        //Get files in a folder and return the latest version of each file
        async Task<List<FileVersion>> getFolderContentByPageAsync(int page)
        {
            var folderContentsReq = _dataMgtClient.Projects[projectId].Folders[folderId].Contents.ToGetRequestInformation();

            var searchWithFiltersURI = CreateRequestWithFilters(folderContentsReq, customFilters);

            var folderContents = await _dataMgtClient.Projects[projectId].Folders[folderId].Contents.WithUrl(searchWithFiltersURI).GetAsync();

            var fileIds = folderContents?.Data?.Select(c =>
            {
                if (c?.Attributes?.DisplayName is null || c?.Id is null)
                    throw new InvalidOperationException("Invalid file");

                var parentFolderId = c.Relationships?.Parent?.Data?.Id;

                return new FileVersion(parentFolderId, c.Attributes.DisplayName, c?.Relationships?.Tip?.Data?.Id ?? throw new InvalidOperationException("File Version urn is null"));
            }) ??
                                throw new InvalidOperationException("Folder contents is null");

            isLastPage = folderContents?.Links?.Next is null;

            return fileIds?.ToList() ?? [];
        }
    }

    /// <summary>
    /// Get files in a folder (not recursive) and return the latest version of each file
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="folderId"></param>
    /// <param name="fileExtensionFilter"></param>
    /// <remarks>Use search for recursive search</remarks>
    /// <returns>List of file version</returns>
    /// <exception cref="InvalidOperationException">Unexpected output</exception>
    public async Task<List<FileVersion>> GetLatestFileVersionAsync(string projectId, string folderId, IEnumerable<string> fileExtensionFilter)
    {
        var fileIds = await GetLatestFilesVersionAsync(projectId, folderId);

        return FilterFilesByExtension(fileIds, fileExtensionFilter).ToList();
    }

    /// <summary>
    /// Fix project id by adding the prefix 'b.' if it is missing
    /// </summary>
    /// <param name="projectId">Current project id</param>
    /// <returns>Project id with 'b.' prefix</returns>
    public string FixProjectId(string projectId)
    {
        return projectId.StartsWith("b.") ? projectId : $"b.{projectId}";
    }

    private async Task<Completes3upload_response_200?> UploadNewVersionAsync(string projectId, string folderId, string fileName, Stream fileContent, int defaultChunkSize = 10000000)
    {
        var fileChunks = await CreateFIleChunks(fileContent, defaultChunkSize);

        //Create signed urls
        projectId = FixProjectId(projectId);

        var storage = await _dataMgtClient.Projects[projectId].Storage
            .PostAsync(new()
            {
                Jsonapi = new()
                {
                    Version = "1.0"
                },
                Data = new()
                {
                    Type = "objects",
                    Attributes = new()
                    {
                        Name = fileName,
                    },
                    Relationships = new()
                    {
                        Target = new()
                        {
                            Data = new()
                            {
                                Type = "folders",
                                Id = folderId
                            }
                        }
                    }
                }
            });

        if (storage?.Data?.Id is null)
        {
            throw new InvalidDataException("Storage is null");
        }

        var storageData = storage.Data.Id.Split('/');
        var bucketKey = storageData[0].Split(':').Last();
        var objectKey = storageData[1];

        return await UploadFileAsync(bucketKey, objectKey, fileContent, defaultChunkSize);
    }

    private async Task<SDKmodels.Item?> CreateNewFileAsync(string projectId, string folderId, string storageId, string fileName)
    {
        projectId = FixProjectId(projectId);

        return await _dataMgtClient.Projects[projectId].Items
                        .PostAsync(new SDKmodels.CreateItem()
                        {
                            Jsonapi = new()
                            {
                                Version = "1.0"
                            },
                            Data = new()
                            {
                                Type = "items",
                                Attributes = new()
                                {
                                    DisplayName = fileName,
                                    Extension = new()
                                    {
                                        Type = "items:autodesk.bim360:File",
                                        Version = "1.0"
                                    }
                                },
                                Relationships = new()
                                {
                                    Tip = new()
                                    {
                                        Data = new()
                                        {
                                            Type = "versions",
                                            Id = "1"
                                        }
                                    },
                                    Parent = new()
                                    {
                                        Data = new()
                                        {
                                            Type = "folders",
                                            Id = folderId
                                        }
                                    }
                                }
                            },
                            Included =
                            [
                                new()
                                {
                                    Type = "versions",
                                    Id = "1",
                                    Attributes = new ()
                                    {
                                        Name = fileName,
                                        Extension = new ()
                                        {
                                            Type = "versions:autodesk.bim360:File",
                                            Version = "1.0"
                                        }
                                    },
                                    Relationships = new ()
                                    {
                                        Storage = new ()
                                        {
                                            Data = new ()
                                            {
                                                Type = "objects",
                                                Id = storageId
                                            }
                                        }
                                    }
                                }
                            ]
                        });
    }

    private async Task<SDKmodels.CreatedVersion?> UpdateFileAsync(string projectId, string itemId, string fileName, string objectKey)
    {
        projectId = FixProjectId(projectId);

        return await _dataMgtClient.Projects[projectId].Versions
             .PostAsync(new()
             {
                 Jsonapi = new()
                 {
                     Version = "1.0"
                 },
                 Data = new()
                 {
                     Type = "versions",
                     Attributes = new()
                     {
                         Name = fileName,
                         Extension = new()
                         {
                             Type = "versions:autodesk.bim360:File",
                             Version = "1.0"
                         },
                     },
                     Relationships = new()
                     {
                         Item = new()
                         {
                             Data = new()
                             {
                                 Type = "items",
                                 Id = itemId
                             }
                         },
                         Storage = new()
                         {
                             Data = new()
                             {
                                 Type = "objects",
                                 Id = objectKey
                             }
                         }
                     }
                 }
             });
    }

    private static async Task<List<byte[]>> CreateFIleChunks(Stream fileContent, int defaultChunkSize = 10000000)
    {
        var MAX_CHUNCK = 25; //S3 limit
        var MIN_CHUNCK_SIZE = 5000; //S3 limit

        ArgumentOutOfRangeException.ThrowIfLessThan(defaultChunkSize, MIN_CHUNCK_SIZE);

        var fileSize = fileContent.Length;

        //Recalculate the chunk size to avoid the 25 chunks limit
        if (fileSize / defaultChunkSize > 25)
        {
            defaultChunkSize = (int)fileSize / (MAX_CHUNCK - 1);
        }

        var numberOfChunks = (int)Math.Round((double)(fileSize / defaultChunkSize)) + 1;

        var chunks = new List<byte[]>();

        for (int i = 0; i < numberOfChunks; i++)
        {
            var chunkSize = fileSize - fileContent.Position;
            if (chunkSize > defaultChunkSize)
                chunkSize = defaultChunkSize;

            var buffer = new byte[chunkSize];

            await fileContent.ReadAsync(buffer.AsMemory(0, (int)chunkSize));

            chunks.Add(buffer);
        }

        return chunks;
    }



    private static IEnumerable<T> FilterFilesByExtension<T>(IEnumerable<T> fileNames, IEnumerable<string> extensionsToKeep) where T : IHasFileName
    {
        if (extensionsToKeep.Any() == false)
            return fileNames;

        return fileNames
            .Where(file => extensionsToKeep.Any(ext => file.FileName.EndsWith(ext, StringComparison.CurrentCultureIgnoreCase)));
    }
}
