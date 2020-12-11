---
title: require-dotnetcoresdk
description: devinit tool require-dotnetcoresdk.
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
# require-dotnetcoresdk

The `require-dotnetcoresdk` tool is used to install the [.NET Core SDK](https://dotnet.microsoft.com/) and shared runtime via the [dotnet-install](/dotnet/core/tools/dotnet-install-script) script.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                               |
|--------------------------------------------------|--------|----------|-------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                               |
| [**input**](#input)                              | string | No       | The version of the .NET Core SDK to install. See [Input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.                    |

### Input

The `input` property is used to specify the .NET Core SDK version to install. A list of versions can be found on the [dotnet-core site](https://dotnet.microsoft.com/download/dotnet-core).

### Additional options

Additional configuration options can be passed in as a value of the `additionalOptions`. These arguments are a direct passthrough to the arguments used in [dotnet-install](/dotnet/core/tools/dotnet-install-script) script. For more information about the available parameters, see the [documentation](/dotnet/core/tools/dotnet-install-script) for the [dotnet-install](/dotnet/core/tools/dotnet-install-script) script. When using `additionalOptions`, make sure to use the PowerShell argument names and format.

> [!NOTE]
> Any additional value to an argument that includes a space must include an additional pair of escaped quotes (using backslash). An example can be seen in [Example usage](#example-usage) using `-InstallDir`.

### Default behavior

The default behavior of the `require-dotnetcoresdk` tool is to install the version of the .NET Core SDK specified in a `global.json` [(documentation)](/dotnet/core/tools/global-json?tabs=netcore3x) file in the current working directory. If no `global.json` file is found, `require-dotnetcoresdk` will install the latest current version of the .NET Core SDK and shared runtime.

## Example usage
Below are examples of how to run `require-dotnetcoresdk` using a `.devinit.json`.

#### .devinit.json that will install the latest version of .NET Core:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-dotnetcoresdk"
        }
    ]
}
```

#### .devinit.json that will install a specific version of .NET Core:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-dotnetcoresdk",
            "input": "3.0.0"
        }
    ]
}
```

#### .devinit.json that will install a specific version of .NET Core and ASP.NET Core:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-dotnetcoresdk",
            "input": "3.0.0",
            "additionalOptions": "-Runtime aspnetcore"
        }
    ]
}
```

#### .devinit.json that will install .NET Core in a specific directory:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-dotnetcoresdk",
            "additionalOptions": "-InstallDir \"C:\\Program Files\\dotnet\""
        }
    ]
}
```