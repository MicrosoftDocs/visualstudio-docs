---
title: .NET Core app
description: Example repository that uses devinit to install a specific .NET Core SDK.
ms.date: 11/04/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---

# .NET Core app

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
