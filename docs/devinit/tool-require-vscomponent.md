---
title: require-vscomponent
description: devinit tool require-vscomponent.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-vscomponent

The `require-vscomponent` tool is used to import Visual Studio configurations to existing Visual Studio. Read more about `.vsconfig` [here](https://docs.microsoft.com/visualstudio/install/import-export-installation-configurations?view=vs-2019).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                     | Type   | Required | Value                                                                |
|------------------------------------------|--------|----------|----------------------------------------------------------------------|
| **comments**                             | string | No       | Optional comments property. Not used.                                |
| [**input**](#input)                      | string | No       | The full path of `.vsconfig`. See [input](#input) below for details. |
| [additionalOptions](#additional-options) | string | No       | See [Additional options](#additional-options) below for details.     |

### Input

The `input` property is used to specify the full path of `.vsconfig` file. If not mentioned, the tool will search for a `.vsconfig` in current directory and pass the value to the Visual Studio Installer.

#### Additional options

Not used.

### Default behavior

The Default behavior of the `require-vscomponent` tool is to look for a `.vsconfig` file in current directory and run the Visual Studio Installer with these details in quiet mode. `require-vscomponent` only supports modifying an existing Visual Studio installation.

## Example usage

```json
{
    "$schema": "./devinit.schema-2.0.json",
    "comments": "A sample dot-devinit file.",
    "run": [
        {
            "tool": "require-vscomponent",
            "comments": "Imports .vsconfig file which is passed as input to Visual Studio.",
            "input": "C:\\.vsconfig"
        }
    ]
}
```
