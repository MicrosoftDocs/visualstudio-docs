---
title: require-azureartifactscredentialprovider
description: devinit tool require-azureartifactscredentialprovider.
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
# require-azureartifactscredentialprovider

The `require-azureartifactscredentialprovider` tool installs the Azure Artifacts Credential Provider. The Azure Artifacts Credential Provider automates the acquisition of credentials needed to restore NuGet packages as part of your .NET development workflow. Read more about Azure Artifacts Credential Provider [here](https://github.com/microsoft/artifacts-credprovider/blob/master/README.md).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | Not used. See [input](#input) below for details. |
| [**additionalOptions**](#additional-options)     | string | No       | See [Additional options](#additional-options) below for details.                     |

### Input

Not used. Ignores any input if mentioned.

### Additional options

Additional options are passed as-is to the credential provider command.

### Default behavior

The default behavior of the `require-azureartifactscredentialprovider` tool is to install the latest version of the Azure Artifacts Credential Provider.

## Example usage
Below is an example of how to run `require-azureartifactscredentialprovider` using a `.devinit.json`.

#### .devinit.json that will install Azure Artifacts Credential Provider:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-azureartifactscredentialprovider",
        }
    ]
}
```
