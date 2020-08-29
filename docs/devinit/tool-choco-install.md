---
title: choco-install
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# choco-install

The `choco-install` tool can be used to install and update [chocolatey](https://chocolatey.org/) packages.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will do nothing.

| Name                                             | Type   | Required | Value                                                                                                          |
|--------------------------------------------------|--------|----------|----------------------------------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                                          |
| [**input**](#Input)                              | string | No       | The package to install. See [Input](#input) below for details.                                                 |
| [**additionalOptions**](#Additional-Options)     | string | No       | Additional Options to pass to the tool. See [Additional Options](#Additional-Options) below for details.       |

### Input

The `input` property is used to specify the name of the package to install (for example 'mongodb') or the path to a configuration file of the following formats `packages.config`, `.nuspec`, and `.nupkg`. The value of `input` will be append to a `choco install` command (for example `choco install mongodb`) along with any arguments specific in [`additionalOptions`](#Additional-Options) and the built-in choco options (defined [below](#Builtin-Choco-Options)). Packages can be found in the [chocolatey package gallery](https://chocolatey.org/packages). When using a configuration file, you can pass in the path to that file in the `input` property, for example `"input":"packages.config"`.

### Additional Options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the arguments used by [choco install](https://chocolatey.org/docs/commands-install) and are defined in chocolatey documentation.

## Builtin Choco Options

The `choc-install` tool sets a number of `choco` command line arguments to ensure that `choco` can run headless. These arguments are listed below and documentation on them can be found in the [chocolatey documentation](https://chocolatey.org/docs/).

| Name                  | Description                                                                                        |
|-----------------------|----------------------------------------------------------------------------------------------------|
| **--yes**             | Confirm all prompts - Chooses affirmative answer instead of prompting. Implies `--accept-license.` |
| **--no-progress**     | Don't show progress - Progress percentages won't be shown.                                         |
| **--skip-powershell** | Skip PowerShell - chocolateyInstall.ps1 won't be ran.                                              |


## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Example that will trigger the default behavior of installing packages listed in a packages.config file.",
            "tool": "choco-install",
            "input": "packages.config",
        },
        {
            "comments": "Example that will install the package 'mongodb'.",
            "tool": "choco-install",
            "input": "mongodb"
        },
        {
            "comments": "Example that will install the '4.2.7' version of 'mongodb'.",
            "tool": "choco-install",
            "input": "mongodb",
            "additionalOptions": "--version 4.2.7"
        }
    ]
}
```
