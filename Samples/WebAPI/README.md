# Sample Web API

This is a sample Web API project that demonstrates how to create a simple ASP.NET Core Web API using the Adsk Toolkit.
This sample demonstrates how to use the Adsk Toolkit with 2-legged and 3-legged tokens to access the Data Management API and using the dependency injection D.I.

## Prerequisites

1. Create a new Autodesk Application as described in the [Getting Started](https://tutorials.autodesk.io/?check_logged_in=1) guide.
   > Callback URL: **[yourserver]/signin-autodesk**
1. In the folder application create a `appsettings.json` file like:

	````json
    {
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },

      "AUTODESK_CLIENT_ID": "eicWhj****faLG",
      "AUTODESK_CLIENT_SECRET": "AJ16FHpjaARr****o9f4F9nAcil",

      "AllowedHosts": "*"
    }
	````

## Run the application

1. Run the application and go to `/hubs`, after the login you will see the number of accessible hubs:

    ````
    Number of hubs found with the 3L token: '9' and with the 2L token: '1'
    ````
