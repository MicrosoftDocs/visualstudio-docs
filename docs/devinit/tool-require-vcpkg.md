---
title: require-vcpkg
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-vcpkg

The `require-vcpkg` tool is used to install [vcpkg](https://github.com/microsoft/vcpkg).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                      |
|--------------------------------------------------|--------|----------|----------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                      |
| [**input**](#input)                              | string | No       | Not used. See [Input](#input) below for details.                           |
| [**additionalOptions**](#Additional-Options)     | string | No       | Not used. See [Additional Options](#Additional-Options) below for details. |

### Input

Not used.

### Additional Options

Not used.

### Default Behavior

The default behavior of the `require-vcpkg` tool is to install vcpkg, and add it to the PATH (Windows only).

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Installs vcpkg.",
            "tool": "require-vcpkg"
        }
    ]
}
```
