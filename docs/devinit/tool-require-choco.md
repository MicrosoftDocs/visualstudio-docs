---
title: require-choco
description: devinit tool require-choco.
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
# require-choco

The `require-choco` tool can be used to install [chocolatey](https://chocolatey.org/).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                      |
|--------------------------------------------------|--------|----------|----------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                      |
| [**input**](#input)                              | string | No       | Not used. See [Input](#input) below for details.                           |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. See [Additional options](#additional-options) below for details. |

### Input

Not used.

### Additional options

Not used.

### Default behavior

The default behavior of the `require-choco` tool is to install chocolatey, and add it to the `PATH`.

## Example usage
Below is an example of how to run `require-choco` using a `.devinit.json`.

#### .devinit.json that will install chocolatey:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-choco"
        }
    ]
}
```