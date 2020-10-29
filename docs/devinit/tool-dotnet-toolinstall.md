---
title: dotnet-toolinstall
description: devinit tool dotnet-toolinstall.
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
# dotnet-toolinstall

The `dotnet-toolinstall` tool is used to install the [.NET Core Tools](https://dotnet.microsoft.com/) via the `dotnet tool update` command.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                 |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                 |
| [**input**](#input)                              | string | Yes      | The .NET Core tool to install. See [Input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.      |

### Input

The `input` property is used to specify the .NET Core tool to install. There is in an unofficial list of tools at [https://github.com/natemcmaster/dotnet-tools](https://github.com/natemcmaster/dotnet-tools).

### Additional options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are a direct passthrough to the arguments used by the [`dotnet tool update`](/dotnet/core/tools/global-tools#update-a-tool) command. 

The `dotnet tool update` command is used to safely handle the case where a tool is already installed.

### Default behavior

The Default behavior of the `dotnet-toolinstall` tool is to error as `input` is required.

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "run": [
        {
            "comments": "Example that will install the dotnet-trace tool.",
            "tool": "dotnet-toolinstall",
            "input": "dotnet-trace"
        },
        {
            "comments": "Example that will install the dotnet-trace tool as a global tool.",
            "tool": "dotnet-toolinstall",
            "input": "dotnet-trace",
            "additionalOptions": "--global"
        }
    ]
}
```