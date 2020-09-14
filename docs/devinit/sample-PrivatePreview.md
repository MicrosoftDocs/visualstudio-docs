---
title: Private Preview 
description: Example customizations used in the Visual Studio Codespaces for Visual Studio 2019 private preview repo.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# Private preview

This example illustrates how to customize a [Github Codespace for Visual Studio](https://docs.microsoft.com/visualstudio/codespaces/quickstarts/vs) to have the same features as the initial private preview.

## .devinit.json

Contents of the [`.devinit.json`](devinit-json.md) file. This file needs to be in the same folder as `.devcontainer.json`.

```json
{
    "run": [
        {
            "tool": "choco-install",
            "input": "python2"
        },
        {
            "tool": "choco-install",
            "input": "python3"
        },
        {
            "tool": "require-dotnetcoresdk",
            "input": "2.1.807"
        },
        {
            "tool": "require-dotnetcoresdk"
        },
        {
            "tool": "require-nodejs"
        },
        {
            "tool": "require-azurecli"
        },
        {
            "tool": "require-nodejs"
        },
        {
            "tool": "require-mssql"
        },
        {
            "tool": "dotnet-toolinstall",
            "input": "dotnet-ef",
            "additionalOptions": "--global"
        },
        {
            "tool": "require-vcpkg"
        }
    ]
}
```

## .devcontainer.json

Contents of the `.devcontainer.json` file in the repo root.

```json
{
  "postCreateCommand": "devinit init"
}
```
