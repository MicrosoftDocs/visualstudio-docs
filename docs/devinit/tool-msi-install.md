---
title: msi-install
description: devinit tool for msiexec.
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
# msi-install

The `msi-install` tool is used to install `.msi` package file formats using [msiexec](https://docs.microsoft.com/windows-server/administration/windows-commands/msiexec).

## Usage

If the `input` is omitted or empty, then the tool will output an error.

| Name                                         | Type   | Required | Value                                                                             |
|----------------------------------------------|--------|----------|-----------------------------------------------------------------------------------|
| **comments**                                 | string | No       | Optional comments property. Not used.                                             |
| [**input**](#input)                          | string | Yes      | The `msi` to install. See [Input](#input) below for details.                      |
| [**additionalOptions**](#additional-options) | string | No       | See [Additional options](#additional-options) below for details.                  |

### Input

The input property is used to specify a path or URL to a `.msi` file that will be installed. If the path to the `.msi` is incorrect or the URL doesn't point to a `.msi` directly, then `msi-install` will note that the installation package cannot be opened.

### Additional options

Additional configuration options can be passed in as a value of the additionalOptions. These arguments are a direct passthrough to the arguments used by `msiexec` and are defined in the `msiexec` [documentation](https://docs.microsoft.com/windows-server/administration/windows-commands/msiexec).

### Built-in options

The msi-install tool sets a number of `msiexec` command-line arguments to ensure that msi can run headless. These arguments are listed below and documentation on them can be found in the `msiexec` [documentation](https://docs.microsoft.com/windows-server/administration/windows-commands/msiexec).

| Name          | Description                                                                                                                                                                                   |
|---------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| /i            | Runs a normal installation                                                                                                                                                                    |
| /quiet        | Specifies quiet mode with no user interaction required                                                                                                                                        |
| /qn           | Specifies there's no UI during installation process                                                                                                                                           |
| /passive      | Specifies unattended mode where the installation only shows a progress bar                                                                                                                    |
| /l*V          | Turns on logging and logs all information, including verbose information, to a `devinit.log` file in the machine's local temp folder. If the tool fails, the log file path is displayed.      |
| /norestart    | Stops the machine from restarting after the installation is complete, but will return a 3010 exit code if a reboot is needed                                                                  |

### Default behavior

The default behavior of the `msi-install` tool is to error as the `input` property is required.

## Example usage
Below is an example of how to run `msi-install` using a `.devinit.json`.

#### .devinit.json that will install the 7-Zip MSI:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-4.0",
    "run": [
        {
            "tool": "msi-install",
            "input": "https://www.7-zip.org/a/7z1900.msi"
        }
    ]
}
```
