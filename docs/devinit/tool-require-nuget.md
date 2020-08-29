---
title: require-nuget
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-nuget

The `require-nuget` tool to download NuGet CLI and adds to PATH variable. NuGet CLI provides the full extent of NuGet functionality to install, create, publish, and manage packages without making any changes to project files. Read more about NuGet CLI [here](https://docs.microsoft.com/en-us/nuget/reference/nuget-exe-cli-reference).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | NuGet CLI version to install. See [input](#input) below for details. |
| [**additionalOptions**](#Additional-Options)     | string | No       | See [Additional Options](#Additional-Options) below for details.                     |

### Input

The `input` is an optional property used to specific the version of NuGet CLI to be installed. If `input` is omitted, latest version of CLI will be installed.

### Additional Options

Not used.

### Default Behavior

The default behavior of the `require-nuget` tool is to install latest of NuGet CLI.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
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
