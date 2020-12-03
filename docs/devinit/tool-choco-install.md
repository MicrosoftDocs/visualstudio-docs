---
title: choco-install
description: devinit tool choco-install to install Chocolatey packages.
ms.date: 11/20/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# choco-install

The `choco-install` tool can be used to install and update [chocolatey](https://chocolatey.org/) packages.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will do nothing.

| Name                                             | Type   | Required  | Value                                                                                                          |
|--------------------------------------------------|--------|-----------|----------------------------------------------------------------------------------------------------------------|
| **comments**                                     | string | No        | Optional comments property. Not used.                                                                          |
| [**input**](#input)                              | string | Yes       | The package to install. See [Input](#input) below for details.                                                 |
| [**additionalOptions**](#additional-options)     | string | No        | Additional options to pass to the tool. See [Additional options](#additional-options) below for details.       |

### Input

The `input` property is used to specify the name of the package to install (for example 'mongodb') or the path to a configuration file of the following formats _packages.config_, _.nuspec_, and _.nupkg_. The value of `input` will be append to a `choco install` command (for example `choco install mongodb`) along with any arguments specific in [`additionalOptions`](#additional-options) and the built-in `choco` options (defined [below](#built-in-options)). Packages can be found in the [Chocolatey package gallery](https://chocolatey.org/packages). When using a configuration file, you can pass in the path to that file in the `input` property, for example `"input":"packages.config"`.

### Additional options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the arguments used by [`choco install`](https://chocolatey.org/docs/commands-install) and are defined in chocolatey documentation.

### Built-in options

The `choco-install` tool sets a number of `choco` command-line arguments to ensure that `choco` can run headless. These arguments are listed below and documentation on them can be found in the [chocolatey documentation](https://chocolatey.org/docs/).

| Name                  | Description                                                                                        |
|-----------------------|----------------------------------------------------------------------------------------------------|
| **--yes**             | Confirm all prompts - Chooses affirmative answer instead of prompting. Implies `--accept-license.` |
| **--no-progress**     | Don't show progress - Progress percentages won't be shown.                                         |
| **--skip-powershell** | Skip PowerShell - chocolateyInstall.ps1 won't be ran.                                              |

### Default behavior

The default behavior of the `choco-install` tool is to error as the `input` property is required.

## Example usage
Below are examples of how to run `choco-install` using a `.devinit.json`.

#### .devinit.json that will install packages listed in packages.config:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "choco-install",
            "input": "packages.config",
        }
    ]
}
```

#### .devinit.json that will install MongoDB:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "choco-install",
            "input": "mongodb"
        }
    ]
}
```

#### .devinit.json that will install a specific version of MongoDB:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "choco-install",
            "input": "mongodb",
            "additionalOptions": "--version 4.2.7"
        }
    ]
}
```