---
title: require-gitsubmodule
description: devinit tool require-gitsubmodule.
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
# require-gitsubmodule

The `require-gitsubmodule` tool restores Git Submodules for given `.gitmodules` file. Uses local `.gitmodules` file in root directory if no input is passed. Read more about Git Submodules [here](https://git-scm.com/book/en/v2/Git-Tools-Submodules).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | `.gitmodules` file full path. See [input](#input) below for details.               |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.                     |

### Input

Optional, `input` is used to get `.gitmodules` file path for restoring. If `input` is omitted, then the root directory `.gitmodules` file is used.

### Additional options

Not used.

### Default behavior

The Default behavior of the `require-gitsubmodule` tool is to restore git submodules mentioned in `.gitmodules` file.

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "comments": "A sample dot-devinit file that restores Git submodules.'",
    "run": [
        {
            "tool": "require-gitsubmodule",
            "input": "RepoThatHasDotGitModulesFile",
            "comments": "Input specifies a folder that contains a .gitmodules file. If no input is specified, then current directory is used."
        }
    ]
}
```
