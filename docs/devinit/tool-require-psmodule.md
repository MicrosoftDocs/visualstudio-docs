---
title: require-psmodule
description: devinit tool require-psmodule.
ms.date: 08/28/2020
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
# require-psmodule

The `require-psmodule` tool is used to install a [PowerShell Module](https://docs.microsoft.com/powershell/scripting/developer/module/understanding-a-windows-powershell-module?view=powershell-7&preserve-view=true) from the [PowerShell Gallery](https://www.powershellgallery.com/) via [Install-Module](https://docs.microsoft.com/powershell/module/powershellget/install-module?view=powershell-7&preserve-view=true), so that it can be used in PowerShell scripts.

> [!TIP]
> Once a module is installed it will still need to be imported into a script using [Import-Module](https://docs.microsoft.com/powershell/module/microsoft.powershell.core/import-module?view=powershell-7&preserve-view=true).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                   |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                   |
| [**input**](#input)                              | string | Yes      | The package(s) to install. See [Input](#input) below for details.                       |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. See [Additional options](#additional-options) below for details.              |

### Input

The `input` property should be the `Name` of the PowerShell module to install. A list of available PowerShell modules can be found by searching the [PowerShell Gallery](https://www.powershellgallery.com/).

### Additional options

Additional options are passed directly to the [Install-Module](https://docs.microsoft.com/powershell/module/powershellget/install-module?view=powershell-7&preserve-view=true) command and are documented on [Microsoft Docs](https://docs.microsoft.com/powershell/module/powershellget/install-module?view=powershell-7&preserve-view=true).

### Default behavior

The Default behavior of the `require-psmodule` tool is to error as `input` is required.

## Builtin Options

The `require-psmodule` tool sets a number of `Install-Module` command line arguments to ensure that `Install-Module` can run headless. These arguments are listed below and documentation on them can be found in the [Install-Module](https://docs.microsoft.com/powershell/module/powershellget/install-module?view=powershell-7&preserve-view=true).

| Name         | Description                                                                                                                                                                                                                                                                                                                                                               |
|--------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **-Force**   | Installs a module and overrides warning messages about module installation conflicts. If a module with the same name already exists on the computer, Force allows for multiple versions to be installed. Will overwrite the module if an existing module with the same name and version exists. Force and AllowClobber can be used together in an Install-Module command. |
| **-WhatIf**  | -WhatIf flag is added when dry run is passed for `devinit` command.                                                                                                                                                                                                                                                                                                       |
| **-Verbose** | -Verbose flag is added when verbose is passed for `devinit` command.                                                                                                                                                                                                                                                                                                      |


## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
    "run": [
        {
            "comments": "Installs the PowerShellGet module.",
            "tool": "require-psmodule",
            "input": "PowerShellGet",
        },
        {
            "comments": "Installs the PowerShellGet module from a specific repository.",
            "tool": "require-psmodule",
            "input": "PowerShellGet",
            "additionalOptions": "-Repository PSGallery"
        }
    ]
}
```
