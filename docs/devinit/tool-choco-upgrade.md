---
title: choco-upgrade
description: devinit tool choco-upgrade.
ms.date: 11/20/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# choco-upgrade

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

The `choco-upgrade` tool can be used to install and update [chocolatey](https://chocolatey.org/docs/commandsupgrade) packages.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will do nothing.

| Name                                             | Type   | Required  | Value                                                                                                          |
|--------------------------------------------------|--------|-----------|----------------------------------------------------------------------------------------------------------------|
| **comments**                                     | string | No        | Optional comments property. Not used.                                                                          |
| [**input**](#input)                              | string | Yes       | The package to upgrade. See [Input](#input) below for details.                                                 |
| [**additionalOptions**](#additional-options)     | string | No        | Additional options to pass to the tool. See [Additional options](#additional-options) below for details.       |

### Input

The `input` property is used to specify the name of the package to upgrade (for example 'mongodb') or the path to a configuration file of the following formats _packages.config_, _.nuspec_, and _.nupkg_. The value of `input` will be append to a `choco upgrade` command (for example `choco upgrade mongodb`) along with any arguments specific in [`additionalOptions`](#additional-options) and the built-in `choco` options (defined [below](#built-in-options)). Packages can be found in the [Chocolatey package gallery](https://chocolatey.org/packages). When using a configuration file, you can pass in the path to that file in the `input` property for example: `"input":"packages.config"`.

### Additional options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are direct passthrough to the arguments used by [`choco upgrade`](https://chocolatey.org/docs/commands-upgrade) and are defined in chocolatey documentation.

### Built-in options

The `choco-upgrade` tool sets a number of `choco` command-line arguments to ensure that `choco` can run headless. These arguments are listed below and documentation on them can be found in the [chocolatey documentation](https://chocolatey.org/docs/).

| Name                  | Description                                                                                        |
|-----------------------|----------------------------------------------------------------------------------------------------|
| **--yes**             | Confirm all prompts - Chooses affirmative answer instead of prompting. Implies `--accept-license`. |
| **--no-progress**     | Don't show progress - Progress percentages won't be shown.                                         |
| **--skip-powershell** | Skip PowerShell - chocolateyInstall.ps1 won't be ran.                                              |

### Default behavior

The default behavior of the `choco-upgrade` tool is to error as the `input` property is required.

## Example usage
Below are examples of how to run `choco-upgrade` using a `.devinit.json`.

#### .devinit.json that will update packages listed in packages.config:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "choco-upgrade",
            "input": "packages.config",
        }
    ]
}
```

#### .devinit.json that will upgrade MongoDB:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "choco-upgrade",
            "input": "mongodb"
        }
    ]
}
```

#### .devinit.json that will upgrade to a specific version of MongoDB:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "choco-upgrade",
            "input": "mongodb",
            "additionalOptions": "--version 4.2.7"
        }
    ]
}
```