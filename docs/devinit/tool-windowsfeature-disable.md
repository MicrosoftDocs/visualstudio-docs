---
title: windowsfeature-disable
description: devinit tool windowsfeature-disable.
ms.date: 11/20/2020
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

The default behavior of the `windowsfeature-disable` tool is to error as `input` is required.

## Example usage
Below is an example of how to run `windowsfeature-disable` using a `.devinit.json`.

#### .devinit.json that will disable a specified feature:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-windowsfeature",
            "input": "web-server",
        }
    ]
}
```
