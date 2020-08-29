---
title: dotnet-restore
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# dotnet-restore

The `dotnet-restore` tool restore dependencies and project-specific tools that are specified in the project file. Read more about dotnet restore [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | Path to the project/solution file to restore. See [input](#input) below for details. |
| [**additionalOptions**](#Additional-Options)     | string | No       | See [Additional Options](#Additional-Options) below for details.                     |

### Input

Path to the project/solution file to restore.

#### Additional Options

Additional options are passed as-is to the dotnet restore command.

### Default Behavior

The default behavior of the `dotnet-restore` tool is to run 'dotnet restore' in the current directory.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "comments": "A sample dot-devinit file that builds the 'kitchen sink'",
    "run": [
        {
            "tool": "dotnet-restore",
            "comments": "Restores the dependencies and tools of a project using dotnet core.",
            "input": "C:\\app1\\app1.csproj"
        }
    ]
}
```
