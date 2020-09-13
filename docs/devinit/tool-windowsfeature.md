---
title: windowsfeature
description: devinit tool windowsfeature.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# windowsfeature

## windowsfeature-enable

The `windowsfeature-enable` tool is used to enable Windows features using a PowerShell script.

| Name                                             | Type   | Required | Value                                                                 |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                 |
| [**input**](#input)                              | string | Yes      | The Windows Feature to enable. See [input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | Not used.                                                             |

### Input

The `input` property should be the `name` of the `windows feature` to enable. A list of available features can be found by running the `windowsfeature-list` tool.

### Additional options

Not used.

### Default behavior

The Default behavior of the `windowsfeature-enable` tool is to error, as `input` is required.

## windowsfeature-disable

The `windowsfeature-disable` tool is used to disable Windows features using a PowerShell script.

| Name                                             | Type   | Required | Value                                                                                   |
|--------------------------------------------------|--------|----------|------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                  |
| [**input**](#input)                              | string | Yes      | The Windows Feature to disable. See [input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | Not used.
                                                           |

### Input

The `input` property should be the `name` of the `windows feature` to disable. A list of available features can be found by running the [`windowsfeature-list`](#windowsfeature-list) tool.

### Additional options

Not used.

### Default behavior

The Default behavior of the `windowsfeature-disable` tool is to error, as `input` is required.

## windowsfeature-list

The `windowsfeature-list` tool is used to list the enable/disable state of all Windows features.

| Name                                             | Type   | Required | Value                                      |
|--------------------------------------------------|--------|----------|--------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.      |
| [**input**](#input)                              | string | No       | Not used. Ignored.                         |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. Ignored.                         |

### Input

Not used. Ignored.

### Additional options

Not used. Ignored.

### Default behavior

The Default behavior of the `windowsfeature-list` tool is to list the enable/disable state of all Windows features.

## Example usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Enables the IIS feature.",
            "tool": "windowsfeature-enable",
            "input": "IIS-WebServerRole",
        },
        {
            "comments": "Enables the .NET Framework 3.5 feature.",
            "tool": "windowsfeature-enable",
            "input": "Microsoft-Windows-NetFx3-OC-Package"
        },
        {
            "comments": "Disables the IIS Asp.Net 4.5 feature.",
            "tool": "windowsfeature-disable",
            "input": "IIS-ASPNET45"
        },
        {
            "comments": "Lists the state of all Windows features.",
            "tool": "windowsfeature-list"
        }
    ]
}
```
