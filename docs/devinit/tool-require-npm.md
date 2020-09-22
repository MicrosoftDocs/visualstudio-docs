---
title: require-npm
description: devinit tool require-npm.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
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

The `input` property is used to specify the NPM version.

### Additional options

Unused.

### Default behavior

The Default behavior of the `require-nodejs` tool is to install the latest LTS version of NPM.

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "run": [
        {
            "comments": "Example that will trigger the Default behavior of installing latest LTS of NPM.",
            "tool": "require-npm"
        },
        {
            "comments": "Example that will install a specific version.",
            "tool": "require-npm",
            "input": "6.14.6"
        }
    ]
}
```
