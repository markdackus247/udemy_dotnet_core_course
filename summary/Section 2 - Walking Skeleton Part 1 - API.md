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
/\*\*
_ Specifies the schema for the launch settings file.
_/
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

## Installing EntityFrameworkCore for SQLite

To install EntityFrameworkCore for SQLite in your project, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the root directory of your project.
3. Run the following command to install the necessary NuGet packages:

   ```sh
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite
   ```

4. Optionally, you can also install the tools package to enable EF Core commands in the CLI:

   ```sh
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   ```

5. After installing the packages, you can start using EntityFrameworkCore with SQLite in your project.

Make sure to update your `DbContext` and configuration settings to use SQLite as the database provider.

## Installing EntityFrameworkCore.Design

To install the EntityFrameworkCore.Design package in your project, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the root directory of your project.
3. Run the following command to install the necessary NuGet package:

   ```sh
   dotnet add package Microsoft.EntityFrameworkCore.Design
   ```

4. This package provides design-time tools for Entity Framework Core, such as the ability to create migrations and scaffold a DbContext.

After installing the package, you can use the design-time tools to manage your database schema and other design-time tasks.

## Creating the Initial EF Core Migration

To create the initial Entity Framework Core migration for your project, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the root directory of your project. Where the main projectfile is.
3. Run the following command to create the initial migration:

   ```sh
   dotnet ef migrations add InitialCreate -s API -p Persistence
   ```

4. This command will generate a new migration file in the `Migrations` folder of your project. The migration file will contain the necessary code to create the initial database schema based on your `DbContext` and entity classes.

5. After creating the migration, you can apply it to the database by running the following command:

   ```sh
   dotnet ef database update
   ```

This will create the database and apply the initial schema defined in the migration file. You can now start using the database with your application.


## Using `dotnet watch --no-hot-reload`

The `dotnet watch --no-hot-reload` command is used to run a .NET application with file watching enabled, but without hot reload functionality. This means that the application will restart automatically when changes are detected in the source files, but it will not apply changes to the running application without restarting.

This can be useful in scenarios where hot reload might cause issues or when you want to ensure that the application is restarted completely to reflect changes.

To use this command, navigate to the root directory of your project and run:

```sh
dotnet watch --no-hot-reload
```

This will start the application and watch for file changes, restarting the application as needed.