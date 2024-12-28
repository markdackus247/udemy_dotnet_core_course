# Section 2: Walking Skeleton Part 1 - API

## Commands to manage your projects
- `dotnet --info`: Displays information about the .NET SDK installations on the machine, including the version, OS, and other environment details.
- `dotnet new list`: Lists the available .NET templates installed on the machine.


## Application Project Structure

The application is organized into several layers, each with a specific responsibility:

1. **API Layer**: This layer is responsible for handling HTTP requests and responses. It acts as the entry point for client applications to interact with the system. It includes controllers, filters, and other web-related components.

2. **Application Layer**: This layer contains the business logic of the application. It includes services, commands, queries, and other application-specific logic. It acts as a mediator between the API layer and the domain layer.

3. **Domain Layer**: This layer represents the core of the application. It includes the domain entities, value objects, aggregates, and domain services. It is responsible for the business rules and domain logic.

4. **Persistence Layer**: This layer is responsible for data access and storage. It includes repositories, data context, and other data-related components. It interacts with the database and other storage mechanisms to persist and retrieve data.

Each layer is designed to be independent and loosely coupled, allowing for better maintainability and scalability of the application.


## Webserver settings (launchSettings.json)
In the folder properties of the API project there is a launchSettings.json file the configure the webserver.
{
    /**
     * Specifies the schema for the launch settings file.
     */
    "$schema": "http://json.schemastore.org/launchsettings.json",

    "profiles": {
        "http": {
            /**
             * The command to execute when launching the project.
             */
            "commandName": "Project",

            /**
             * Indicates whether to display .NET run messages.
             */
            "dotnetRunMessages": true,

            /**
             * Determines whether to launch the browser automatically.
             */
            "launchBrowser": false,

            /**
             * The URL where the application will be accessible.
             */
            "applicationUrl": "http://localhost:5000",

            "environmentVariables": {
                /**
                 * Sets the environment for the ASP.NET Core application.
                 */
                "ASPNETCORE_ENVIRONMENT": "Development"
            }
        }
    }
}


## API.csproj file
Setting strings to nullable for this project
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>disable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  

