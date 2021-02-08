---
title: require-winget
description: devinit tool require-winget.
ms.date: 02/08/2021
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
# require-winget

The `require-winget` tool is used to install [winget](https://docs.microsoft.com/windows/package-manager/winget/). 
## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | Not used.                                                                            |
| [**additionalOptions**](#additional-options)     | string | No       | Not used.                    |

### Input

Not used.

### Additional options

Not used.

### Default behavior

The Default behavior of the `require-winget` tool is to install the latest version using the [`winget-cli` git repository](https://github.com/microsoft/winget-cli).

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-6.0",
    "comments": "Example that installs the latest version of winget",
    "run": [
        {
            "tool": "require-winget",
            "comments": "Installs winget",
        }
    ]
}
```
