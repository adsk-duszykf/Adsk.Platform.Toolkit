# Passing query parameters

The query parameters are the key-value pairs that are appended to the URL to filter or modify the request. They are typically used in GET requests to specify criteria for the data being requested.
The url bellow has a single query parameter `page[number]=1`:

```curl
https://developer.api.autodesk.com/data/v1/projects/:project_id/folders/:folder_id/search?page[number]=1
````

## Passing implemented query parameters

Most of the query parameters are supported by the services SDK. For example, to get the first page of search results in a project folder, you can use the following code snippet:

```csharp
using Autodesk.DataManagement;
using Autodesk.DataManagement.Models;

/// <summary>
/// Returns the first page of search results
/// </summary>
public async Task<Search?> Search()
{

    async Task<string> getAccessToken()
    {
        //return access token with your logic
    }

    var DMclient = new DataManagementClient(getAccessToken);

    return await DMclient.DataMgtApi.Data.V1
                    .Projects["project_id"]
                    .Folders["folder_id"]
                    .Search.GetAsync(r =>
                        {
                            // Set the query parameters page[number]
                            r.QueryParameters.Pagenumber = 1;
                        });

}
```

## Passing not implemented query parameters

Few query parameters are not implemented in the SDK. However, you can still pass them tweaking the request by using the `QueryParameterMiddleware`. Here's an example:

```csharp
using Autodesk.DataManagement;
using Autodesk.DataManagement.Models;
using Autodesk.Common.HttpClientLibrary.Middleware.Options;

/// <summary>
/// Returns this first page of results for all tip versions of Revit files or JPG files from the specified folder and its subfolders, where the filename contains the string: Floor
/// </summary>
public async Task<Search?> Search()
{

    async Task<string> getAccessToken()
    {
        //return access token with your logic
    }

    // Create query parameter middleware configuration
    var queryParamOptions = new QueryParameterHandlerOption();
    queryParamOptions.QueryParameters.Add("filter[fileType]", "rvt,jpg");
    queryParamOptions.QueryParameters.Add("filter[attributes.fileName]-contains", "floor");

    var DMclient = new DataManagementClient(getAccessToken);

    return await DMclient.DataMgtApi.Data.V1
                    .Projects["project_id"]
                    .Folders["folder_id"]
                    .Search.GetAsync(r =>
                        {
                            r.QueryParameters.Pagenumber = 1;
                            // Add the query parameter middleware options
                            r.Options.Add(queryParamOptions);
                        });

}
```
