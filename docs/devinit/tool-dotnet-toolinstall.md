---
title: dotnet-toolinstall
description: devinit tool dotnet-toolinstall.
ms.date: 11/20/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

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

The default behavior of the `dotnet-toolinstall` tool is to error as `input` is required.

## Example usage
Below are examples of how to run `dotnet-toolinstall` using a `.devinit.json`.

#### .devinit.json that will install the dotnet-trace tool:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "dotnet-toolinstall",
            "input": "dotnet-trace"
        }
    ]
}
```

#### .devinit.json that will install the dotnet-trace tool as a global tool:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "dotnet-toolinstall",
            "input": "dotnet-trace",
            "additionalOptions": "--global"
        }
    ]
}
```