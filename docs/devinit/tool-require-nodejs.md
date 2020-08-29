---
title: require-nodejs
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-nodejs

The `require-nodejs` tool is used to install the [Node.js](https://nodejs.org/) via an MSI distributed by the Node.js organization.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                     |
|--------------------------------------------------|--------|----------|---------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                     |
| [**input**](#input)                              | string | No       | The version of Node.JS to install. See [Input](#input) below for details. |
| [**additionalOptions**](#Additional-Options)     | string | No       | See [Additional Options](#Additional-Options) below for details.          |

### Input

The `input` property is used to specify the Node.js version. A list of versions can be found on the [Node.js download page](https://nodejs.org/en/download/). The full version number is required Major.Minor.Path (for example 14.4.0) if any are omitted the installation will fail.

### Additional Options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the MSI installer for Node.js.  

### Default Behavior

The default behavior of the `require-nodejs` tool is to install the latest LTS version of Node as detailed on the Node.JS [website](https://nodejs.org/en/download/).

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Example that will trigger the default behavior of installing latest LTS of Node.JS.",
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
