---
title: windowsfeature-enable
description: devinit tool windowsfeature-enable.
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
# windowsfeature-enable

The `windowsfeature-enable` tool is used to enable Windows features.

## Usage

| Name                                             | Type   | Required | Value                                                                    |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                    |
| [**input**](#input)                              | string | Yes      | The Windows feature to install. See [Input](#input) below for details.   |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.         |

### Input

The `input` property should be the `name` of the `windows feature` to install. A list of available features can be found by running the `Get-WindowsFeature` PowerShell cmd.

### Additional-Options

None.

### Default behavior

The default behavior of the `windowsfeature-enable` tool is to error as `input` is required.

## Example usage
Below are examples of how to run `windowsfeature-enable` using a `.devinit.json`.

#### .devinit.json that will install IIS:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "windowsfeature-enable",
            "input": "web-server",
        }
    ]
}
```

#### .devinit.json that will install the .NET Framework:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "windowsfeature-enable",
            "input": "net-framework-features"
        }
    ]
}
```

#### .devinit.json that will install the .NET Framework 4.5:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "windowsfeature-enable",
            "input": "net-framework-45-features"
        }
    ]
}
```

#### .devinit.json that will install the Windows Subsystem for Linux 2.0:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "windowsfeature-enable",
            "input": "Microsoft-Windows-Subsystem-Linux"
        }
    ]
}
```
