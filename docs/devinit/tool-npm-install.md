---
title: npm-install
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# npm-install

The `npm-install` tool can be used to install [NPM](https://www.npmjs.com/) packages.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will do nothing.

| Name                                             | Type   | Required | Value                                                                                                          |
|--------------------------------------------------|--------|----------|----------------------------------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                                          |
| [**input**](#Input)                              | string | Yes      | The package to install. See [Input](#input) below for details.                                                 |
| [**additionalOptions**](#Additional-Options)     | string | No       | Additional Options to pass to the tool. See [Additional Options](#Additional-Options) below for details.       |

### Input

The `input` property is used to specify the name of the package to install (for example 'mongo').

### Additional Options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the arguments used by [npm install](https://docs.npmjs.com/cli/install).

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Example that will install the mongo NPM package (https://www.npmjs.com/package/mongo).",
            "tool": "npm-install",
            "input": "mongo",
        }
    ]
}
```
