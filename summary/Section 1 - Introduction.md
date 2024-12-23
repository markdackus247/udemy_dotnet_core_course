# Introduction

## Setup development environment

To install .NET 8 on your Windows 11 computer, follow these steps:

1.  **Download the .NET 8 SDK:**

    - Visit the [.NET 8 download page](https://dotnet.microsoft.com/download/dotnet/8.0).
    - Download the installer for Windows.

2.  **Run the installer:**

    - Open the downloaded file and follow the prompts to install the .NET 8 SDK.

3.  **Verify the installation:**

    - Open a command prompt.
    - Run the following command to check the installed version:
      ```sh
      dotnet --version
      ```
    - You should see the version number of .NET 8.

4.  **Update your PATH environment variable (if necessary):**
    - The installer should automatically update your PATH. If it doesn't, you can manually add the installation path to your PATH environment variable.
    - To do this, follow these steps:
      1. Open the Start Menu and search for "Environment Variables".
      2. Select "Edit the system environment variables".
      3. In the System Properties window, click on the "Environment Variables" button.
      4. In the Environment Variables window, find the "Path" variable in the "System variables" section and select it.
      5. Click "Edit" and then "New" to add a new entry.
      6. Add the path to the .NET 8 SDK, typically `C:\Program Files\dotnet\`.
      7. Click "OK" to close all windows.

## Change the default .NET version

To change the default .NET version on your Windows computer, follow these steps:

1. **Open a command prompt with administrative privileges:**

   - Right-click on the Start Menu and select "Command Prompt (Admin)" or "Windows PowerShell (Admin)".

2. **Check the currently installed .NET versions:**

   - Run the following command to list all installed .NET SDKs:
     ```sh
     dotnet --list-sdks
     ```

3. **Set the global .NET version:**

   - Create or edit a `global.json` file in your user profile directory or your project directory to specify the desired .NET version. For example, to create it in your user profile directory, navigate to `C:\Users\<YourUsername>\`:
     ```json
     {
       "sdk": {
         "version": "8.0.100"
       }
     }
     ```
   - Save the `global.json` file.

4. **Verify the change:**
   - Run the following command to check the default .NET version:
     ```sh
     dotnet --version
     ```
   - The output should show the version specified in the `global.json` file.

## Install Node.js with NVM

To install Node.js using the Node Version Manager (NVM) on your Windows computer, follow these steps:

1. **Download and install NVM for Windows:**

    - Visit the [NVM for Windows releases page](https://github.com/coreybutler/nvm-windows/releases).
    - Download the latest `nvm-setup.zip` file.
    - Extract the contents and run the `nvm-setup.exe` installer.
    - Follow the prompts to complete the installation.

2. **Open a command prompt:**

    - Open the Start Menu and search for "Command Prompt".
    - Select "Command Prompt" to open it.

3. **Install the desired Node.js version:**

    - Run the following command to list available Node.js versions:
      ```sh
      nvm list available
      ```
    - Choose the version you want to install and run:
      ```sh
      nvm install <version>
      ```
      Replace `<version>` with the desired version number, e.g., `14.17.0`.

4. **Use the installed Node.js version:**

    - Run the following command to use the installed version:
      ```sh
      nvm use <version>
      ```
      Replace `<version>` with the version number you installed.

5. **Verify the installation:**

    - Run the following command to check the installed Node.js version:
      ```sh
      node --version
      ```
    - You should see the version number of Node.js that you installed.

6. **Install npm (if necessary):**

    - npm (Node Package Manager) is usually installed with Node.js. To verify, run:
      ```sh
      npm --version
      ```
    - If npm is not installed, you can install it by running:
      ```sh
      npm install -g npm
      ```

## Best C# Extensions for Visual Studio Code

To enhance your C# development experience in Visual Studio Code, consider installing the following extensions:

1. **C# (powered by OmniSharp):**
    - Provides rich support for C# development, including IntelliSense, debugging, and more.
    - [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

2. **NuGet Package Manager:**
    - Allows you to easily manage NuGet packages within your projects.
    - [NuGet Package Manager](https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager)

3. **Roslynator:**
    - A collection of 500+ analyzers, refactorings, and fixes for C#.
    - [Roslynator](https://marketplace.visualstudio.com/items?itemName=josefpihrt-vscode.roslynator)

4. **GitLens:**
    - Enhances Git capabilities within Visual Studio Code.
    - [GitLens](https://marketplace.visualstudio.com/items?itemName=eamodio.gitlens)

5. **Material Icon Theme:**
    - Provides a comprehensive set of icons for Visual Studio Code.
    - [Material Icon Theme](https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme)

6. **NuGet Gallery:**
    - A tool to search and install NuGet packages from the NuGet Gallery.
    - [NuGet Gallery](https://marketplace.visualstudio.com)

7. **C# Dev Kit:**
    - Provides additional tools and features for C# development in Visual Studio Code.
    - [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

8. **IntelliCode for C# Dev Kit:**
    - AI-assisted code recommendations for C# development.
    - [IntelliCode for C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=VisualStudioExptTeam.vscodeintellicode-csharp)
