---
title: winget-install
description: devinit tool for winget.
ms.date: 02/08/2021
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
> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

# winget-install

The `winget-install` tool is used to install [winget packages](https://docs.microsoft.com/windows/package-manager/winget/).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will output an error.

| Name                                         | Type   | Required | Value                                                                             |
|----------------------------------------------|--------|----------|-----------------------------------------------------------------------------------|
| **comments**                                 | string | No       | Optional comments property. Not used.                                             |
| [**input**](#input)                          | string | No       | The package to install. See [Input](#input) below for details.                    |
| [**additionalOptions**](#additional-options) | string | No       | See [Additional options](#additional-options) below for details.                  |

### Input

The input property is used to specify the `Id` or `Name` of the package to install (for example 'MongoDB.Server'). The value of input will be append to a `winget install` command (for example `winget install MongoDB.Server`). If the package name isn't unique and matches other packages, you can specify the `Id` of the package and add the `--exact` flag to the `additionalOptions` to ensure the package identity matches exactly. The `Id` of a package can be found by executing the `winget search` command and using the `Id` parameter for a package.  

### Additional options

Additional configuration options can be passed in as a value of the additionalOptions. These arguments are direct passthrough to the arguments used by `winget install` and are defined in the `winget install` [documentation](https://docs.microsoft.com/windows/package-manager/winget/install).

#### Manifests

An additional optional that `winget` supports is the ability to provide a [manifest file](https://docs.microsoft.com/windows/package-manager/winget/install#local-install) to detail the package to be installed. To use this feature with devinit the `input` parameter should be empty and the `additionalOptions` property should include the `--manifest` option followed by the path to the manifest (for example `--manifest path.to.manifest.yml`).

### Built-in options

The winget-install tool sets a number of winget command-line arguments to ensure that winget can run headless. These arguments are listed below and documentation on them can be found in the `winget install` [documentation](https://docs.microsoft.com/windows/package-manager/winget/install).

| Name     | Description                                                                                                                       |
|----------|-----------------------------------------------------------------------------------------------------------------------------------|
| --silent | Runs the installer in silent mode. This suppresses all UI. The default experience shows installer progress.                       | 

## Example usage

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-6.0",
    "run": [
        {
            "comments": "Installs Microsoft PowerToys.",
            "tool": "winget-install",
            "input": "Microsoft.PowerToys",
            "additionalOptions": "--version 0.15.2",
        },
        {
            "comments": "Installs PostgreSQL.",
            "tool": "winget-install",
            "input": "PostgreSQL.PostgreSQL",
            "additionalOptions": "--exact"
        },
        {
            "comments": "Installs the package defined in winget-manifest.yml.",
            "tool": "winget-install",
            "additionalOptions": "--manifest winget-manifest.yml"
        }
    ]
}
```
