# Error Handling

The APS Toolkit provides a consistent approach to error handling across all API calls. When an error occurs, the toolkit will throw an exception that contains detailed information about the error, including:

- The HTTP status code
- The error message
- The 'context', which is `HttpResponseMessage`

## Handling Errors in Your Application

To handle errors in your application, you can use try-catch blocks around your API calls. Here's an example:

```csharp
try
{
    var hubs = await dmClient.DataMgtApi.Project.V1.Hubs.GetAsync();
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Status Code: {ex.StatusCode}");
    Console.WriteLine($"Error Details: {ex.Data["context"]}");
}
```

## Getting the error message from the underlying API

To get the error message from the underlying API, you can access the `HttpResponseMessage` from the exception's data. Here's how you can do it:

```csharp
catch (HttpRequestException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Status Code: {ex.StatusCode}");
    Console.WriteLine($"Error Details: {ex.Data["context"]}");

    if (ex.Data["context"] is HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Response content: {content}");
    }
}