---
title: require-gitsubmodule
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-gitsubmodule

The `require-gitsubmodule` tool restores Git Submodules for given `.gitmodules` file. Uses local `.gitmodules` file in root directory if no input is passed. Read more about Git Submodules [here](https://git-scm.com/book/en/v2/Git-Tools-Submodules).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | `.gitmodules` file full path. See [input](#input) below for details.               |
| [**additionalOptions**](#Additional-Options)     | string | No       | See [Additional Options](#Additional-Options) below for details.                     |

### Input

Optional, `input` is used to get `.gitmodules` file path for restoring. If `input` is omitted, then the root directory `.gitmodules` file is used.

### Additional Options

Not used.

### Default Behavior

The default behavior of the `require-gitsubmodule` tool is to restore git submodules mentioned in `.gitmodules` file.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
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
