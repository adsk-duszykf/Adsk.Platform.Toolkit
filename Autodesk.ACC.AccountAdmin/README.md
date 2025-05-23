# Autodesk ACC Account Admin Service

The package `Adsk.Platform.ACC.AccountAdmin` provides a .NET SDK to interact with the [Autodesk ACC Account Admin Service](https://aps.autodesk.com/en/docs/acc/v1/reference/http/admin-accounts-accountidprojects-GET/). This service allows you to manage accounts, projects, users, and other account-level administrative tasks within the Autodesk Construction Cloud.

## Documentation

More information on the Autodesk Construction Cloud APIs can be found [here](https://aps.autodesk.com/en/docs/acc/v1/overview/introduction/).

## Installation

```bash
dotnet add package Adsk.Platform.ACC.AccountAdmin
```

## Usage

See the [QuickStart Guide](../../Documentation/docs/GetStarted/quickStart.md) for a general understanding.

The root object is `AccountAdminClient`. This object provides a simplified interface to the Account Admin APIs.

### Example: Listing Projects for an Account

Here is an example of how to list projects for a specific account ID:

```csharp
using Autodesk.ACC.AccountAdmin; // For AccountAdminClient
using Autodesk.ACC.AccountAdmin.Models; // For Project, ProjectsGetResponse etc.
using System;
using System.Collections.Generic; // For Dictionary (though not directly used in this simplified example, often useful)
using System.Threading.Tasks; // For Task

public class AccountAdminExamples
{
    // Function to simulate obtaining an access token
    // In a real application, you would get this from the Autodesk Authentication API
    private static async Task<string> GetAccessTokenAsync()
    {
        // Replace with your actual token acquisition logic
        await Task.Delay(10); // Simulate async work
        return "YOUR_ACCESS_TOKEN"; // Ensure this is a valid token for testing
    }

    public static async Task ListProjectsForAccount(Guid accountId)
    {
        // Instantiate the new AccountAdminClient, passing the token acquisition function
        var client = new AccountAdminClient(GetAccessTokenAsync);

        try
        {
            // Configure the request to filter by accountId using the Api property
            var projectsResponse = await client.Api.Projects.GetAsProjectsGetResponseAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.FilteraccountId = accountId;
                requestConfiguration.QueryParameters.Limit = 10; // Optional: Limit the number of results
            });

            if (projectsResponse?.Results != null && projectsResponse.Results.Count > 0)
            {
                Console.WriteLine($"Projects for Account ID: {accountId}");
                foreach (var project in projectsResponse.Results)
                {
                    // Ensure project.Id, project.Name, and project.Status are valid properties
                    Console.WriteLine($"- Project ID: {project.Id}, Name: {project.Name}, Status: {project.Status?.ToString()}");
                }
            }
            else
            {
                Console.WriteLine($"No projects found for Account ID: {accountId} or error in response.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error listing projects: {ex.Message}");
            // It can be helpful to see more details during development
            // Console.WriteLine(ex.ToString());
        }
    }

    // Example of how to call the method
    // public static async Task Main(string[] args)
    // {
    //     // IMPORTANT: Replace with a valid Account ID (GUID format) from your Autodesk ACC account
    //     Guid targetAccountId = new Guid("00000000-0000-0000-0000-000000000000"); 
    //     if (targetAccountId == Guid.Empty)
    //     {
    //         Console.WriteLine("Please replace YOUR_ACCOUNT_ID_GUID with a valid Account ID in the example.");
    //         return;
    //     }
    //     await ListProjectsForAccount(targetAccountId);
    // }
}
```