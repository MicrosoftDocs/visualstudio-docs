---
title: Private Preview 
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# Private Preview 

This example illustrates how to customize a [Codespace with Visual Studio 2019](https://docs.microsoft.com/en-us/visualstudio/codespaces/quickstarts/vs) to have the same features as the initial private preview.

## .devcontainer.json

Contents of the [`.devcontainer.json`]() file in the repo root. 

```json
{
  "postCreateCommand": "devinit init"
}
```
## .devinit.json

Contents of the [`.devinit.json`]() file. This file needs to be in the same folder as [`.devcontainer.json`]().

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