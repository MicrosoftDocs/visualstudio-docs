---
title: require-npm
description: devinit tool require-npm.
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

# require-npm

The `require-npm` tool is used to install [NPM](https://www.npmjs.com/).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                       |
|--------------------------------------------------|--------|----------|---------------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                       |
| [**input**](#input)                              | string | Yes      | Specifies the NPM version. See [Input](#input) below for details.                           |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. See [Additional options](#additional-options) below for details.                  |

### Input

The `input` property is used to specify the npm version.

### Additional options

Unused.

### Default behavior

The default behavior of the `require-nodejs` tool is to install the latest LTS version of npm.

## Example usage
Below are examples of how to run `require-npm` using a `.devinit.json`.

#### .devinit.json that will install the LTS of npm:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-npm"
        }
    ]
}
```

#### .devinit.json that will install a specific version of npm:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-npm",
            "input": "6.14.6"
        }
    ]
}
```