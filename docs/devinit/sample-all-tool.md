---
title: All tools 
description: Example of using all the devinit tools.
ms.date: 02/08/2021
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# All tools

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

This example has a `devinit.json`, which installs all the available devinit tools.

## .devinit.json

```json
{
  "$schema": "./devinit.schema-6.0.json",
  "comments": "A sample dot-devinit file",
  "run": [
    {
      "tool": "azurecli-login",
      "comments": "Logs in to Azure Cli."
    },
    {
      "tool": "choco-install",
      "input": "kubernetes-cli",
      "additionalOptions": "--version 1.18.1",
      "comments": "Additional options are appended to the 'choco install' command line. In this case, we pass in the specific package version to install."
    },
    {
      "tool": "choco-upgrade",
      "input": "kubernetes-cli",
      "additionalOptions": "--version 1.18.2",
      "comments": "Additional options are appended to the 'choco upgrade' command line. In this case, we pass in the specific package version to install."
    },
    {
      "tool": "dotnet-restore",
      "input": "C:\\app1\\app1.csproj",
      "comments": "Restores the dependencies and tools of a project using .NET Core. Input can be used to provide .sln path or project file path."
    },
    {
      "tool": "dotnet-toolinstall",
      "input": "dotnet-ef",
      "additionalOptions": "--global",
      "comments": "Installs a .NET Core tool."
    },
    {
      "tool": "enable-iis",
      "comments": "Enables IIS features and installs the latest ASP.NET hosting bundle."
    },
    {
      "tool": "msi-install",
      "input": "https://www.7-zip.org/a/7z1900.msi",
      "comments": "Installs the 7-Zip MSI",
    },
    {
      "tool": "npm-install",
      "input": "some-package",
      "additionalOptions": "--some-additional-options",
      "comments": "Installs an NPM package"
    },
    {
      "tool": "nuget-restore",
      "comments": "Restores nuget packages to current directory 'Packages' folder. Input is optional and used for packages.config path.",
      "input": "C:\\packages.config"
    },
    {
      "tool": "require-azureartifactscredentialprovider",
      "comments": "Installs Azure Artifacts Credential Provider."
    },
    {
      "tool": "require-azurecli",
      "comments": "Always installs latest of Azure CLI for Windows."
    },
    {
      "tool": "require-choco",
      "input": "0.10.15"
    },
    {
      "tool": "require-dotnetcoresdk",
      "comments": "If input is null, the sdk version is from global.json if it exists; otherwise, current LTS version."
    },
    {
      "tool": "require-dotnetcoresdk",
      "input": "3.1.200",
      "comments": "Input specifies an explicit SDK version."
    },
    {
      "tool": "require-dotnetframeworksdk",
      "input": "4.8.0",
      "comments": "Input specifies an explicit SDK version."
    },
    {
      "tool": "require-mssql",
      "input": "install",
      "comments": "Installs MS SQL."
    },
    {
      "tool": "require-nodejs",
      "input": "12.16.3",
      "comments": "Installs Node.js."
    },
    {
      "tool": "require-npm",
      "input": "6.14.4",
      "comments": "Installs NPM."
    },
    {
      "tool": "require-nuget",
      "input": "5.5.1",
      "comments": "Installs NuGet for given input version. If no input given, then installs latest."
    },
    {
      "tool": "require-psmodule",
      "input": "PowerShellGet",
      "additionalOptions": "-Repository PSGallery",
      "comments": "Installs specified PS module mentioned in input from PSGallery, unless repository mentioned in additional options."
    },
    {
      "tool": "require-vcpkg",
      "comments": "Installs vcpkg."
    },
    {
      "tool": "require-vscomponent",
      "input": "C:\\.vsconfig",
      "comments": "Imports .vsconfig file which is passed as input to Visual Studio."
    },
    {
      "tool": "require-winget",
      "comments": "Installs winget",
    },
    {
      "tool": "set-env",
      "input": "Foo=Bar",
      "comments": "Set-env can set, display or delete individual variables and can display all variables."
    },
    {
      "tool": "vcpkg-install",
      "input": "some-package",
      "additionalOptions": "--some-additional-options",
      "comments": "Installs a package using vcpkg."
    },
    {
      "comments": "Enables the .NET Framework 3.5 feature.",
      "tool": "windowsfeature-enable",
      "input": "Microsoft-Windows-NetFx3-OC-Package"
    },
    {
      "comments": "Disables the IIS Asp.Net 4.5 feature.",
      "tool": "windowsfeature-disable",
      "input": "IIS-ASPNET45"
    },
    {
      "comments": "Lists the state of all Windows features.",
      "tool": "windowsfeature-list"
    },
    {
      "comments": "Installs the package defined in winget-manifest.yml.",
      "tool": "winget-install",
      "additionalOptions": "--manifest winget-manifest.yml"
    },
    {
      "tool": "wsl-install",
      "input": "https://aka.ms/wslubuntu2004",
      "additionalOptions": "--wsl-version 1 --post-create-command some-post-create-command",
      "comments": "Installs distro from target URL using Windows Subsystem for Linux."
    }
  ]
}
```

## .devcontainer.json

Contents of the _.devcontainer.json_ file in the repo root.

```json
{
  "postCreateCommand": "devinit init"
}
```
