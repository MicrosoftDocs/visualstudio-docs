---
title: eShopOnWeb
description: Example customization using devinit for the dotnet-architecture/eShopOnWeb repo.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# eShopOnWeb

This example illustrates how to customize the dotnet architecture example [eShopOnWeb](https://github.com/dotnet-architecture/eShopOnWeb) to automatically be provisioned in a [GitHub Codespace for Visual Studio](https://docs.microsoft.com/visualstudio/codespaces/quickstarts/vs).

## PostCloneSetup.ps1

This script is called from _PostCloneSetup.ps1_ and can also be ran locally to set up the repository. This file needs to be in the same folder as _.devcontainer.json_.

```batch
devinit init
dotnet ef database update -c catalogcontext -p src\Infrastructure\Infrastructure.csproj -s src\Web\Web.csproj
dotnet ef database update -c appidentitydbcontext -p src\Infrastructure\Infrastructure.csproj -s src\Web\Web.csproj
```

## .devinit.json

Contents of the [_.devinit.json_](devinit-json.md) file. This file needs to be in the same folder as _.devcontainer.json_.

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

## .devcontainer.json

Contents of the _.devcontainer.json_ file in the repo root.

```json
{
  "postCreateCommand": "devinit init"
}
```
