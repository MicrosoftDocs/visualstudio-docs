---
title: Available Tools
description: List of all the devinit tools that can be used to customize a Visual Studio Codespaces for Visual Studio 2019. 
ms.date: 08/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# Available tools

The table below contains a list of all the currently available tools for `devinit`.

| Tool                                                                                          | Description                                                                                                 |
|-----------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------|
| [**choco-install**](tool-choco-install)                                                       | Tool to install chocolatey packages.                                                                        |
| [**dotnet-restore**](tool-dotnet-restore)                                                     | Tool to restore the dependencies and tools of a .NET project.                                               |
| [**dotnet-toolinstall**](tool-dotnet-toolinstall)                                             | Tool to install the .NET Core tools (for example. dotnet-ef)                                                |
| [**dsc-install**](tool-dsc-install)                                                           | Tool to use PowerShell Desired State Config, to enable and configure Windows features.                      |
| [**msi-install**](tool-msi-install)                                                           | Tool to install an MSI.                                                                                     |
| [**npm-install**](tool-npm-install)                                                           | Tool to install NPM packages.                                                                               |
| [**nuget-restore**](tool-nuget-restore)                                                       | Tool to restore the NuGet packages.                                                                         |
| [**require-azureartifactscredentialprovider**](tool-require-azureartifactscredentialprovider) | Installs the Azure Artifacts Credential provider.                                                           |
| [**require-azurecli**](tool-require-azurecli)                                                 | Tool to install the Azure CLI.                                                                              |
| [**require-dotnetcoresdk**](tool-require-dotnetcoresdk)                                       | Tool to install the .NET Core SDK and shared runtime.                                                       |
| [**require-dotnetframeworksdk**](tool-require-dotnetframeworksdk)                             | Tool to install the .NET Framework SDK.                                                                     |
| [**require-gitsubmodule**](tool-require-gitsubmodules)                                        | Restore Git Submodule. Use local `.gitmodules` if no `.gitmodules` is passed.                               |
| [**require-mssql**](tool-require-mssql)                                                       | Tool to install MS SQL Server 2019.                                                                         |
| [**require-nodejs**](tool-require-nodejs)                                                     | Tool to install Nodejs and NPM.                                                                             |
| [**require-npm**](tool-require-npm)                                                           | Tool to install NPM.                                                                                        |
| [**require-psmodule**](tool-require-psmodule)                                                 | Tool to install PowerShell modules from the gallery.                                                        |
| [**require-vcpkg**](tool-require-vcpkg)                                                       | Tool to install vcpkg.                                                                                      |
| [**require-vscomponent**](tool-require-vscomponent)                                           | Tool to modify VS installations based on a `.vsconfig` file.                                                |
| [**require-windowsfeature**](tool-require-vscomponent)                                        | Tool set enable or disable Windows Features using Desired State Configuration capability of Windows Server. |
| [**set-env**](tool-set-env)                                                                   | Tool to view and set environment variables.                                                                 |
| [**vcpkg-install**](tool-vcpkg-install)                                                       | Tool to install packages via vcpkg.                                                                         |
| [**wsl-install**](tool-wsl-install)                                                           | Tool to install and configure Linux distros for the Window Subsystem for Linux.                             |
