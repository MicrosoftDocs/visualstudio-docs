---
title: require-npm
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-npm

The `require-npm` tool is used to install [NPM](https://www.npmjs.com/).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                       |
|--------------------------------------------------|--------|----------|---------------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                       |
| [**input**](#input)                              | string | Yes      | Specifies the NPM version. See [Input](#input) below for details.                           |
| [**additionalOptions**](#Additional-Options)     | string | No       | Not used. See [Additional Options](#Additional-Options) below for details.                  |

### Input

The `input` property is used to specify the NPM version.

### Additional Options

Unused.

### Default Behavior

The default behavior of the `require-nodejs` tool is to install the latest LTS version of NPM.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Example that will trigger the default behavior of installing latest LTS of NPM.",
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
