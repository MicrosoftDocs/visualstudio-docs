---
title: Node.js app
description: Example repository that uses devinit to install npm packages for a Node.js Express project.
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

# Node.js app

See the [devinit-example-nodejs](https://github.com/microsoft/devinit-example-nodejs) repository for a full example of using devinit to install npm packages for a Node.js Express project.

## .devinit.json

Contents of the _.devinit.json_ file in the repo root.

```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-2.0",
  "run": [
    {
      "comments": "Installs the body-parser package.",
      "tool": "npm-install",
      "input": "body-parser"
    },
    {
      "comments": "Installs the cookie-parser package.",
      "tool": "npm-install",
      "input": "cookier-parser"
    },
    {
      "comments": "Installs the debug package.",
      "tool": "npm-install",
      "input": "debug"
    },
    {
      "comments": "Installs the express package.",
      "tool": "npm-install",
      "input": "express"
    },
    {
      "comments": "Installs the morgan package.",
      "tool": "npm-install",
      "input": "morgan"
    },
    {
      "comments": "Installs the pug package.",
      "tool": "npm-install",
      "input": "pug"
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
