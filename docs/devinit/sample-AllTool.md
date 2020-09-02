---
title: All Tools
ms.date: 08/28/200
description: List of all the devinit tools for customizing Visual Studio Codespaces for Visual Studio 2019.
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# All Tools

This example illustrates how to use a large range of `devinit` tools.

## .devcontainer.json

Contents of the `.devcontainer.json` file in the repo root.

```json
{
  "postCreateCommand": "devinit init"
}
```

## .devinit.json
Contents of the `.devcontainer.json` file. This file needs to be in the same folder as `.devcontainer.json`.

``` json
{
  "run": [
    {
      "tool": "require-choco",
      "input": "0.10.15"
    },
    {
      "tool": "choco-upgrade",
      "input": "kubernetes-cli",
      "comments": "Additional options are appended to the 'choco upgrade' command line. In this case, we pass in the specific package version to install.",
      "additionalOptions": "--version 1.18.2"
    },
    {
      "tool": "dotnet-restore",
      "comments": "Restores the dependencies and tools of a project using dotnet core. Input can be used to provide .sln path or project file path.",
      "input": "C:\\app1\\app1.csproj"
    },
    {
      "tool": "nuget-restore",
      "comments": "Restores nuget packages to current directory 'Packages' folder. Input is optional and used for packages.config path.",
      "input": "C:\\packages.config"
    },
    {
      "tool": "set-env",
      "input": "Foo=Bar",
      "comments": "Set-env can set, display or delete individual variables and can display all variables."
    },
    {
      "tool": "require-azurecli",
      "comments": "Always installs latest of Azure CLI for windows."
    },
    {
      "tool": "require-dotnetsdk",
      "comments": "If input is null, the sdk version is from global.json if it exists; otherwise, current LTS version."
    },
    {
      "tool": "require-dotnetsdk",
      "comments": "Input specifies an explicit SDK version.",
      "input": "3.1.200"
    },
    {
      "tool": "require-gitsubmodule",
      "comments": "Input specifies a folder that contains a .gitmodules file. If no input is specified, then current directory is used.",
      "input": "RepoThatHasDotGitModulesFile"
    },
    {
      "tool": "require-nuget",
      "comments": "Installs NuGet for given input version. If no input given, then installs latest.",
      "input": "5.5.1"
    },
    {
      "tool": "require-azureartifactscredentialprovider",
      "comments": "Installs Azure Artifacts Credential Provider."
    },
    {
      "tool": "require-psmodule",
      "input": "PowerShellGet",
      "comments": "Installs specified PS module mentioned in input from PSGallery, unless repository mentioned in Additional options.",
      "additionalOptions": "-Repository PSGallery"
    },
    {
      "tool": "require-vscomponent",
      "comments": "Imports .vsconfig file which is passed as input to Visual Studio.",
      "input": "C:\\.vsconfig"
    },
    {
      "tool": "azurecli-login",
      "comments": "Logs in to Azure Cli."
    },
    {
      "tool": "wsl-install",
      "comments": "Installs distro from target URL using Windows Subsystem for Linux.",
      "input": "https://aka.ms/wslubuntu2004"
    }
  ]
}
```