---
title: require-nuget
description: devinit tool require-nuget.
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
# require-nuget

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

The `require-nuget` tool downloads NuGet CLI and adds it to the `PATH`. NuGet CLI provides the full extent of NuGet functionality to install, create, publish, and manage packages without making any changes to project files. Read more about NuGet CLI [here](/nuget/reference/nuget-exe-cli-reference).

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

The default behavior of the `require-nuget` tool is to install latest of NuGet CLI.

## Example usage
Below is an example of how to run `require-nuget` using a `.devinit.json`.

#### .devinit.json that will install a specified version of NuGet:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-nuget",
            "input": "5.5.1",
        }
    ]
}
```