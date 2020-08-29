---
title: require-psmodule
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-psmodule

The `require-psmodule` tool is used to install a [PowerShell Module](https://docs.microsoft.com/en-us/powershell/scripting/developer/module/understanding-a-windows-powershell-module?view=powershell-7) from the [PowerShell Gallery](https://www.powershellgallery.com/) via [Install-Module](https://docs.microsoft.com/en-us/powershell/module/powershellget/install-module?view=powershell-7, so that it can be used in PowerShell scripts.

>
>!TIP Once a module is installed it will still need to be imported into a script using [Import-Module](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/import-module?view=powershell-7).
>

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                   |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                   |
| [**input**](#input)                              | string | Yes      | The package(s) to install. See [Input](#input) below for details.                       |
| [**additionalOptions**](#Additional-Options)     | string | No       | Not used. See [Additional Options](#Additional-Options) below for details.              |

### Input

The `input` property should be the `Name` of the PowerShell module to install. A list of available PowerShell modules can be found by searching the [PowerShell Gallery](https://www.powershellgallery.com/).

### Additional Options

Additional Options are passed directly to the [Install-Module](https://docs.microsoft.com/en-us/powershell/module/powershellget/install-module?view=powershell-7) command and are documented on [Microsoft Docs](https://docs.microsoft.com/en-us/powershell/module/powershellget/install-module?view=powershell-7).

### Default Behavior

The default behavior of the `require-psmodule` tool is to error as `input` is required.

## Builtin Options

The `require-psmodule` tool sets a number of `Install-Module` command line arguments to ensure that `Install-Module` can run headless. These arguments are listed below and documentation on them can be found in the [Install-Module](https://docs.microsoft.com/en-us/powershell/module/powershellget/install-module?view=powershell-7).

| Name         | Description                                                                                                                                                                                                                                                                                                                                                               |
|--------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **-Force**   | Installs a module and overrides warning messages about module installation conflicts. If a module with the same name already exists on the computer, Force allows for multiple versions to be installed. Will overwrite the module if an existing module with the same name and version exists. Force and AllowClobber can be used together in an Install-Module command. |
| **-WhatIf**  | -WhatIf flag is added when dry run is passed for `devinit` command.                                                                                                                                                                                                                                                                                                       |
| **-Verbose** | -Verbose flag is added when verbose is passed for `devinit` command.                                                                                                                                                                                                                                                                                                      |


## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
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
