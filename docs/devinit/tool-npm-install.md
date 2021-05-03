---
title: npm-install
description: devinit tool npm-install.
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
# npm-install

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

The `npm-install` tool can be used to install [NPM](https://www.npmjs.com/) packages.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will do nothing.

| Name                                             | Type   | Required | Value                                                                                                          |
|--------------------------------------------------|--------|----------|----------------------------------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                                          |
| [**input**](#input)                              | string | No       | The package to install. See [Input](#input) below for details.                                                 |
| [**additionalOptions**](#additional-options)     | string | No       | Additional options to pass to the tool. See [Additional options](#additional-options) below for details.       |

### Input

The `input` property is used to specify the name of the package to install (for example 'mongo').

### Additional options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the arguments used by [npm install](https://docs.npmjs.com/cli/install).

### Default behavior

The default behavior of the `npm-install` tool is to run `npm install` with no arguments. See [the npm documentation](https://docs.npmjs.com/cli/v6/commands/npm-install) for a description of this behavior.

## Example usage
Below is an example of how to run `npm-install` using a `.devinit.json`.

#### .devinit.json that will install mongo:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "npm-install",
            "input": "mongo",
        }
    ]
}
```
