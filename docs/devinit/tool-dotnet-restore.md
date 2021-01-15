---
title: dotnet-restore
description: devinit tool dotnet-restore.
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
# dotnet-restore

The `dotnet-restore` tool restore dependencies and project-specific tools that are specified in the project file. Read more about dotnet restore [here](/dotnet/core/tools/dotnet-restore).

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

Additional options are passed as-is to the dotnet restore command.

### Default behavior

The default behavior of the `dotnet-restore` tool is to run `dotnet restore` in the current directory.

## Example usage
Below is an example of how to run `dotnet-restore` using a `.devinit.json`.

#### .devinit.json that will restore dependencies and tools of a project:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "dotnet-restore",
            "input": "C:\\app1\\app1.csproj"
        }
    ]
}
```