---
title: require-nodejs
description: devinit tool require-nodejs.
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
# require-nodejs

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

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

The default behavior of the `require-nodejs` tool is to install the latest LTS version of Node as detailed on the Node.JS [website](https://nodejs.org/en/download/).

## Example usage
Below are examples of how to run `require-nodejs` using a `.devinit.json`. 

#### .devinit.json that will install the LTS of Node.js:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-nodejs"
        }
    ]
}
```

#### .devinit.json that will install a specific version of Node.js:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-nodejs",
            "input": "14.4.0"
        }
    ]
}
```
