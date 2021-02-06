---
title: .NET Core Runtime
description: Example customization using devinit for the dotnet/runtime repo.
ms.date: 08/28/2020
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
# .NET Core runtime

This example illustrates how to customize the .NET Core Runtime [dotnet/runtime](https://github.com/dotnet/runtime) to automatically be provisioned with [GitHub Codespaces](https://github.com/features/codespaces).

## PostCloneSetup.ps1

This script is called from _PostCloneSetup.ps1_ and can also be run locally to set up the repository. This file needs to be in the same folder as _.devcontainer.json_.

```console
devinit init
git config --system core.longpaths true
```

## packages.config

The _packages.config_ file is a [Chocolatey](https://chocolatey.org/) file that defines the list of Chocolatey packages to install. This file needs to be in the same folder as _.devcontainer.json_.

```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
    <package id="python" version="3.8.3"  />
    <package id="cmake" version="3.17.3"  />
</packages>
```

## .devinit.json

Contents of the [`.devinit.json`](devinit-json.md) file. This file needs to be in the same folder as the _.devcontainer.json_ file.

```json
{
    "run": [
        {
            "tool": "require-dotnetcoresdk"
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

## .devcontainer.json

Contents of the _.devcontainer.json_ file in the repo root.

```json
{
  "postCreateCommand": "Powershell.exe -ExecutionPolicy unrestricted -File .\\PostCloneSetup.ps1"
}
```
