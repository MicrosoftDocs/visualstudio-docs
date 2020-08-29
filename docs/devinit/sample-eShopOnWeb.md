---
title: eShopOnWeb
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# eShopOnWeb

This example illustrates how to customize the dotnet architecture example [eShopOnWeb](https://github.com/dotnet-architecture/eShopOnWeb) to automatically be provisioned in a [Codespace with Visual Studio 2019](https://docs.microsoft.com/en-us/visualstudio/codespaces/quickstarts/vs).

## .devcontainer.json

Contents of the [`.devcontainer.json`]() file in the repo root.

```json
{
  "postCreateCommand": "Powershell.exe -ExecutionPolicy unrestricted -File PostCloneSetup.ps1"
}
```

## PostCloneSetup.ps1

This script is called from `PostCloneSetup.ps1` and can also be ran locally to set up the repository. This file needs to be in the same folder as [`.devcontainer.json`]().

```cmd
devinit init
dotnet ef database update -c catalogcontext -p src\Infrastructure\Infrastructure.csproj -s src\Web\Web.csproj
dotnet ef database update -c appidentitydbcontext -p src\Infrastructure\Infrastructure.csproj -s src\Web\Web.csproj
```

## .devinit.json

Contents of the [`.devinit.json`]() file. This file needs to be in the same folder as [`.devcontainer.json`]().

```json
{
    "run": [
        {
            "tool": "require-dotnetcoresdk"
        },
        {
            "tool": "require-mssql"
        },
        {
            "tool": "dotnet-toolinstall",
            "input": "dotnet-ef",
            "additionalOptions": "--global"
        }
    ]
}
```