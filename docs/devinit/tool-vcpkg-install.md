---
title: vcpkg-install
description: devinit tool vcpkg-install.
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
> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

# vcpkg-install

The `vcpkg-install` tool is used to acquire C/C++ libraries (referred to as ports) using [vcpkg](https://github.com/microsoft/vcpkg).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                   |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                   |
| [**input**](#input)                              | string | Yes      | The package(s) to install. See [Input](#input) below for details.                       |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.                        |

### Input

The `input` property should be the `name` of the `vcpkg` to install or a list of space separated names to install multiple packages. A list of available ports can be found on the [vcpkg GitHub repo](https://github.com/microsoft/vcpkg/tree/master/ports).

### Additional options

Additional options are passed directly to the [vcpkg](/powershell/module/powershellget/install-module?view=powershell-7&preserve-view=true) command and are documented on the [vcpkg GitHub repo](https://github.com/microsoft/vcpkg/blob/master/docs/examples/installing-and-using-packages.md).

### Default behavior

The default behavior of the `vcpkg-install` tool is to error as `input` is required.

## Example usage
Below are examples of how to run `vcpkg-install` using a `.devinit.json`.

#### .devinit.json that will install the sdl2 port:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "vcpkg-install",
            "input": "sdl2",
        }
    ]
}
```

#### .devinit.json that will install multiple ports:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [

        {
            "tool": "vcpkg-install",
            "input": "sdl2 sqlite3"
        }
    ]
}
```