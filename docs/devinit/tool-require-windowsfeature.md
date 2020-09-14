---
title: require-windowsfeature
description: devinit tool require-windowsfeature.
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
# require-windowsfeature

The `require-windowsfeature` tool is used to acquire Windows features using Desired State Configuration.

>[!IMPORTANT]
>This tool is only available on Windows Server.

## Usage

| Name                                             | Type   | Required | Value                                                                                                                            |
|--------------------------------------------------|--------|----------|----------------------------------------------------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                                                            |
| [**input**](#input)                              | string | Yes      | The Windows Feature to install. See [Input](#input) below for details.                                                           |
| [**additionalOptions**](#additional-options)     | string | No       | An additional option can be used to uninstall a Windows Feature. See [Additional options](#additional-options) below for details.|

### Input

The `input` property should be the `name` of the `windows feature` to install. A list of available features can be found by running the Get-WindowsFeature PowerShell cmdlet on a Windows Server.

### Additional-Options

Additional options are passed directly to the PowerShell script implementing the 'require-windowsfeature' tool.
To uninstall a Windows Feature, specify '-EnsureState Absent' as the Additional options.

### Default behavior

The Default behavior of the `require-windowsfeature` tool is to error, as `input` is required.

## Example usage

```json
{
    "$schema": "./devinit.schema-2.0.json",
    "run": [
        {
            "comments": "Installs IIS.",
            "tool": "require-windowsfeature",
            "input": "web-server",
        },
        {
            "comments": "Installs the .NET Framework 3.5.",
            "tool": "require-windowsfeature",
            "input": "net-framework-features"
        },
        {
            "comments": "Installs the .NET Framework 4.5.",
            "tool": "require-windowsfeature",
            "input": "net-framework-45-features"
        },
        {
            "comments": "Installs Windows Subsystem for Linux 2.0.",
            "tool": "require-windowsfeature",
            "input": "Microsoft-Windows-Subsystem-Linux"
        }
    ]
}
```
