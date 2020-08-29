---
title: vcpkg-install
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# vcpkg-install

The `vcpkg-install` tool is used to acquire C/C++ libraries (referred to as ports) using [vcpkg](https://github.com/microsoft/vcpkg).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                   |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                   |
| [**input**](#input)                              | string | Yes      | The package(s) to install. See [Input](#input) below for details.                       |
| [**additionalOptions**](#Additional-Options)     | string | No       | See [Additional Options](#Additional-Options) below for details.                        |

### Input

The `input` property should be the `name` of the `vcpkg` to install or a list of space separated names to install multiple packages. A list of available ports can be found on the [vcpkg GitHub repo](https://github.com/microsoft/vcpkg/tree/master/ports).

### Additional Options

Additional Options are passed directly to the [vcpkg](https://docs.microsoft.com/en-us/powershell/module/powershellget/install-module?view=powershell-7) command and are documented on the [vcpkg GitHub repo](https://github.com/microsoft/vcpkg/blob/master/docs/examples/installing-and-using-packages.md).

### Default Behavior

The default behavior of the `vcpkg-install` tool is to error, as `input` is required.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Installs the sdl2 port.",
            "tool": "vcpkg-install",
            "input": "sdl2",
        },
        {
            "comments": "Installs the sdl2 and sqlite3 ports.",
            "tool": "vcpkg-install",
            "input": "sdl2 sqlite3"
        }
    ]
}
```
