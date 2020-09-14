---
title: require-dotnetframeworksdk
description: devinit tool require-dotnetframeworksdk.
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
# require-dotnetframeworksdk

The `require-dotnetframeworksdk` tool is used to install the [.NET Framework SDK](https://dotnet.microsoft.com/) via the [provided installers](https://dotnet.microsoft.com/download/visual-studio-sdks).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required  | Value                                                                                    |
|--------------------------------------------------|--------|-----------|------------------------------------------------------------------------------------------|
| **comments**                                     | string | No        | Optional comments property. Not used.                                                    |
| [**input**](#input)                              | string | No        | The version of the .NET Framework SDK to install. See [Input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No        | Not used. See [Additional options](#additional-options) below for details.               |

### Input

The `input` property is used to specify the .NET Framework SDK version to install. A list of versions can be found on the [dotnet-framework site](https://dotnet.microsoft.com/download/visual-studio-sdks).

### Additional options

Not used.

### Default behavior

The Default behavior of the `require-dotnetframeworksdk` tool is to install the latest release. See the [provided installers](https://dotnet.microsoft.com/download/visual-studio-sdks) for the latest version.

## Example usage

```json
{
    "$schema": "./devinit.schema-2.0.json",
    "run": [
        {
            "comments": "Example that will install a specific version of the .NET Framework SDK.",
            "tool": "require-dotnetframeworksdk",
            "input": "4.8.0"
        },
        {
            "comments": "Example that will install the latest version of the .NET Framework SDK.",
            "tool": "require-dotnetframeworksdk"
        }
    ]
}
```
