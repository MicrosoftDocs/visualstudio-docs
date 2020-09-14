---
title: nuget-restore
description: devinit tool nuget-restore.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# nuget-restore

The `nuget-restore` tool restore dependencies and project-specific tools that are specified in the project file. Read more about NuGet restore [here](https://docs.microsoft.com/nuget/reference/cli-reference/cli-ref-restore).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | Path to the project/solution file to restore. See [input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.                     |

### Input

Path to the project/solution file to restore.

### Additional options

Additional options are passed as-is to the NuGet restore command.

### Default behavior

The Default behavior of the `nuget-restore` tool is to run 'NuGet restore' in the current directory.

## Example usage

```json
{
    "$schema": "./devinit.schema-2.0.json",
    "comments": "A sample dot-devinit file that restores NuGet pacakges.",
    "run": [
        {
            "tool": "nuget-restore",
            "comments": "Restores the dependencies and tools of a project using nuget restore.",
            "input": "C:\\nuget\\Nuget.config"
        }
    ]
}
```
