---
title: require-dotnetframeworksdk
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-dotnetframeworksdk

The `require-dotnetframeworksdk` tool is used to install the [.NET Framework SDK](https://dotnet.microsoft.com/) via the [provided installers](https://dotnet.microsoft.com/download/visual-studio-sdks).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required  | Value                                                                                    |
|--------------------------------------------------|--------|-----------|------------------------------------------------------------------------------------------|
| **comments**                                     | string | No        | Optional comments property. Not used.                                                    |
| [**input**](#Input)                              | string | No        | The version of the .NET Framework SDK to install. See [Input](#input) below for details. |
| [**additionalOptions**](#Additional-Options)     | string | No        | Not used. See [Additional Options](#Additional-Options) below for details.               |

### Input

The `input` property is used to specify the .NET Framework SDK version to install. A list of versions can be found on the [dotnet-framework site](https://dotnet.microsoft.com/download/visual-studio-sdks).

### Additional Options

Not used.

### Default Behavior

The default behavior of the `require-dotnetframeworksdk` tool is to install the latest release. See the [provided installers](https://dotnet.microsoft.com/download/visual-studio-sdks) for the latest version.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
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
