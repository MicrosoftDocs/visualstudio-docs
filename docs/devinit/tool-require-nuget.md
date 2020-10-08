---
title: require-nuget
description: devinit tool require-nuget.
ms.date: 08/28/2020
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
# require-nuget

The `require-nuget` tool to download NuGet CLI and adds to PATH variable. NuGet CLI provides the full extent of NuGet functionality to install, create, publish, and manage packages without making any changes to project files. Read more about NuGet CLI [here](https://docs.microsoft.com/nuget/reference/nuget-exe-cli-reference).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | NuGet CLI version to install. See [input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.                     |

### Input

The `input` is an optional property used to specific the version of NuGet CLI to be installed. If `input` is omitted, latest version of CLI will be installed.

### Additional options

Not used.

### Default behavior

The Default behavior of the `require-nuget` tool is to install latest of NuGet CLI.

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "comments": "A sample dot-devinit file that downloads NuGet CLI and adds to PATH variable.'",
    "run": [
        {
            "tool": "require-nuget",
            "input": "5.5.1",
            "comments": "Installs NuGet for given input version. If no input given, then installs latest."
        }
    ]
}
```
