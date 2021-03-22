---
title: windowsfeature-list
description: devinit tool windowsfeature-list.
ms.date: 11/20/2020
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
# windowsfeature-list

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

The `windowsfeature-list` tool is used to list the enable/disable state of all Windows features.

| Name                                             | Type   | Required | Value                                      |
|--------------------------------------------------|--------|----------|--------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.      |
| [**input**](#input)                              | string | No       | Not used. Ignored.                         |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. Ignored.                         |

### Input

Not used. Ignored.

#### Additional options

Not used. Ignored.

### Default behavior

The default behavior of the `windowsfeature-list` tool is to list the enable/disable state of all Windows features.

## Example usage
Below is an example of how to run `windowsfeature-list` using a `.devinit.json`.

#### .devinit.json that will list the state of all Windows Features:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0.json",
    "run": [
        {
            "tool": "windowsfeature-list"
        }
    ]
}
```
