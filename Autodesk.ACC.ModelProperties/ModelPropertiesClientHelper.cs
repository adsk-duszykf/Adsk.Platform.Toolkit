using System.Dynamic;
using Autodesk.ACC.ModelProperties.Helpers.Models;
using Newtonsoft.Json;
using SDKmodels = Autodesk.ACC.ModelProperties.Models;


namespace Autodesk.ACC.ModelProperties.Helpers;

public class ModelPropertiesClientHelper
{
    public BaseModelPropertiesClient Api { get; init; }
    internal ModelPropertiesClientHelper(BaseModelPropertiesClient api)
    {
        Api = api;
    }
    public async Task<List<Field>> GetFields(string projectId, string indexId)
    {
        projectId = FixProjectId(projectId);

        var fieldsAsStream = await Api.V2.Projects[projectId].Indexes[indexId].Fields.GetAsync()
                                    ?? throw new InvalidOperationException("No field returned");

        return ConvertLDJsonToList<Field>(fieldsAsStream);
    }

    public async Task<List<ExpandoObject>> GetPropertiesAsync(string projectId, string indexId, string queryId)
    {
        projectId = FixProjectId(projectId);

        var propertiesAsStream = await Api.V2.Projects[projectId].Indexes[indexId].Queries[queryId].Properties.GetAsync()
                                    ?? throw new InvalidOperationException("No property returned");

        return ConvertLDJsonToList<ExpandoObject>(propertiesAsStream);
    }
    /// <summary>
    /// Create a search index for a file version. Will wait for the index to be created.
    /// </summary>
    /// <param name="projectId">ACC/BIM360 projectId</param>
    /// <param name="fileVersionUrns">File version urn</param>
    /// <returns>The search Index Id</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<string> CreateSearchIndexAsync(string projectId, string fileVersionUrns)
    {
        projectId = FixProjectId(projectId);

        var response = await Api.V2.Projects[projectId].IndexesBatchStatus.PostAsync(new SDKmodels.IndexVersionsQueryRequest()
        {
            Versions = [new() { VersionUrn = fileVersionUrns }]
        });

        var indexBuildStatus = response?.Indexes?.FirstOrDefault() ?? throw new InvalidOperationException("Index not found");
        var indexBuildState = indexBuildStatus?.State;

        while (indexBuildState == SDKmodels.JobState.PROCESSING)
        {
            await Task.Delay(5000);
            indexBuildStatus = await Api.V2.Projects[projectId].Indexes[indexBuildStatus?.IndexId].GetAsync();
            indexBuildState = indexBuildStatus?.State;
        }

        if (indexBuildState == SDKmodels.JobState.FAILED)
        {
            throw new InvalidOperationException("Failed to create an index");
        }

        return indexBuildStatus?.IndexId ?? throw new InvalidOperationException("Index not found");
    }

    public async Task<string> RunQueryAsync(string projectId, string indexId, SDKmodels.IndexQueryRequest query)
    {
        projectId = FixProjectId(projectId);

        var queryRunStatus = await Api.V2.Projects[projectId].Indexes[indexId].Queries.PostAsync(query);

        var queryRunState = queryRunStatus?.State;

        while (queryRunState == SDKmodels.JobState.PROCESSING)
        {
            await Task.Delay(5000);
            queryRunStatus = await Api.V2.Projects[projectId].Indexes[indexId].Queries[queryRunStatus?.QueryId].GetAsync();
            queryRunState = queryRunStatus?.State;
        }

        if (queryRunState == SDKmodels.JobState.FAILED)
        {
            var message = queryRunStatus?.Errors?.Select(e => e.Detail).Aggregate((a, b) => $"{a}\n{b}") ?? "Unknown error";
            throw new InvalidOperationException($"Failed to run the query: {message}");
        }

        return queryRunStatus?.QueryId ?? throw new InvalidOperationException("Query not found");
    }

    /// <summary>
    /// Fix project id by removing the prefix 'b.' if it is existing
    /// </summary>
    /// <param name="projectId">Current project id</param>
    /// <returns>Project id with 'b.' prefix</returns>
    public static string FixProjectId(string projectId)
    {
        return projectId.StartsWith("b.") ? projectId.Substring(2) : projectId;
    }

    /// <summary>
    /// Convert a LDJSON (Line Delimited Json) stream to a list of dynamic objects. See https://jsonlines.org/
    /// </summary>
    /// <typeparam name="T">Type of the elements in the list</typeparam>
    /// <param name="sourceStream"></param>
    /// <returns>List of parsed json objects</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static List<T> ConvertLDJsonToList<T>(Stream sourceStream)
    {
        var result = new List<T>();

        using var streamReader = new StreamReader(sourceStream);
        using var jsonReader = new JsonTextReader(streamReader);

        var serializer = new JsonSerializer();

        jsonReader.SupportMultipleContent = true; // This is required to read multiple objects from the stream

        // Read and process each object from the stream
        while (jsonReader.Read())
        {
            if (jsonReader.TokenType == JsonToken.StartObject)
            {
                var field = serializer.Deserialize<T>(jsonReader) ?? throw new InvalidOperationException("Invalid field");

                result.Add(field);
            }
        }

        return result;

    }

}
