---
title: windowsfeature-disable
description: devinit tool windowsfeature-disable.
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
# windowsfeature-disable

The `windowsfeature-disable` tool is used to acquire Windows features.

## Usage

| Name                                             | Type   | Required | Value                                                                  |
|--------------------------------------------------|--------|----------|------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                  |
| [**input**](#input)                              | string | Yes      | The Windows feature to install. See [Input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.       |

### Input

The `input` property should be the `name` of the `windows feature` to disable.

### Additional-Options

None.

### Default behavior

The Default behavior of the `windowsfeature-disable` tool is to error, as `input` is required.

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "run": [
        {
            "comments": "Installs IIS.",
            "tool": "require-windowsfeature",
            "input": "web-server",
        }
    ]
}
```
