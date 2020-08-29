---
title: require-azureartifactscredentialprovider
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# require-azureartifactscredentialprovider

The `require-azureartifactscredentialprovider` tool installs the Azure Artifacts Credential Provider. The Azure Artifacts Credential Provider automates the acquisition of credentials needed to restore NuGet packages as part of your .NET development workflow. Read more about Azure Artifacts Credential Provider [here](https://github.com/microsoft/artifacts-credprovider/blob/master/README.md).

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                |
| [**input**](#input)                              | string | No       | Not used. See [input](#input) below for details. |
| [**additionalOptions**](#Additional-Options)     | string | No       | See [Additional Options](#Additional-Options) below for details.                     |

#### Input

Not used. Ignores any input if mentioned.

#### Additional Options

Additional options are passed as-is to the credential provider command.

### Default Behavior

The default behavior of the `require-azureartifactscredentialprovider` tool is to install latest of Azure Artifacts Credential Provider.

## Example Usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "comments": "A sample dot-devinit file that installs Azure Artifacts Credential Provider.'",
    "run": [
        {
            "tool": "require-azureartifactscredentialprovider",
            "comments": "Installs Azure Artifacts Credential Provider."
        }
    ]
}
```
