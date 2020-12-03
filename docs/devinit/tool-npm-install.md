---
title: npm-install
description: devinit tool npm-install.
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
# npm-install

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
