---
title: .NET Core app
description: Example repository that uses devinit to install a specific .NET Core SDK.
ms.date: 11/04/2020
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
# .NET Core app

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

See the [devinit-example-dotnet-core](https://github.com/microsoft/devinit-example-dotnet-core) repository for a full example of using devinit to install the required .NET Core SDK version in Codespaces.

## .devinit.json

Contents of the _.devinit.json_ file in the repo root.

```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-2.0",
  "run": [
    {
      "comments": "Installs the .NET Core SDK specified in the global.json file.",
      "tool": "require-dotnetcoresdk"
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

## global.json

Contents of the _global.json_ file in the repo root.

```json
{
  "sdk": {
    "version": "3.1.302"
  }
}
```
