---
title: .NET Core Runtime
description: Example customization using devinit for the dotnet/runtime repo.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# .NET Core Runtime

This example illustrates how to customize the .NET Core Runtime [dotnet/runtime](https://github.com/dotnet/runtime) to automatically be provisioned in a [Codespace with Visual Studio 2019](https://docs.microsoft.com/visualstudio/codespaces/quickstarts/vs).

## .devcontainer.json

Contents of the `.devcontainer.json` file in the repo root.

```json
{ 
    "postCreateCommand": "PostCloneSetup.ps1"
} 
```

## PostCloneSetup.ps1

This script is called from `PostCloneSetup.ps1` and can also be ran locally to set up the repository. This file needs to be in the same folder as `.devcontainer.json`.

```batch
devinit init
git config --system core.longpaths true
devinit init -f .devinit.json
```

## packages.config

The `packages.config` file is a [Chocolatey](https://chocolatey.org/) file that defines the list of Chocolatley packages to install. This file needs to be in the same folder as `.devcontainer.json`.

```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
    <package id="python" version="3.8.3"  />
    <package id="cmake" version="3.17.3"  />
</packages> 
```

## .devinit.json

Contents of the [`.devinit.json`](devinit-json.md) file. This file needs to be in the same folder as `.devcontainer.json` file.

```json
{
    "run": [
        {
            "tool": "require-dotnetsdk"
        },
        {
            "tool": "choco-install",
            "input": "packages.config"
        },
        {
            "tool": "require-vscomponent"
        }
    ]
} 
```
