---
title: require-nodejs
description: devinit tool require-nodejs.
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
# require-nodejs

The `require-nodejs` tool is used to install the [Node.js](https://nodejs.org/) via an MSI distributed by the Node.js organization.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                     |
|--------------------------------------------------|--------|----------|---------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                     |
| [**input**](#input)                              | string | No       | The version of Node.JS to install. See [Input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.          |

### Input

The `input` property is used to specify the Node.js version. A list of versions can be found on the [Node.js download page](https://nodejs.org/en/download/). The full version number is required Major.Minor.Path (for example 14.4.0) if any are omitted the installation will fail.

### Additional options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the MSI installer for Node.js.  

### Default behavior

The Default behavior of the `require-nodejs` tool is to install the latest LTS version of Node as detailed on the Node.JS [website](https://nodejs.org/en/download/).

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "run": [
        {
            "comments": "Example that will trigger the Default behavior of installing latest LTS of Node.JS.",
            "tool": "require-nodejs"
        },
        {
            "comments": "Example that will install a specific version.",
            "tool": "require-nodejs",
            "input": "14.4.0"
        }
    ]
}
```
