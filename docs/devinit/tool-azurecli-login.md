---
title: azurecli-login
description: devinit tool azurecli-login.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# azurecli-login

The `azurecli-login` tool is used to sign into Azure Active Directory via [Azure CLI](https://docs.microsoft.com/cli/azure/authenticate-azure-cli?view=azure-cli-latest).

## Usage

If both  properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                          |
|--------------------------------------------------|--------|----------|--------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                          |
| [**input**](#input)                              | string | No       | Not used. See [Input](#input) below for details.                               |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. See [Additional options](#additional-options) below for details.     |

### Input

Not used.

### Additional options

Not used.

### Default behavior

The Default behavior of the `azurecli-login` tool is to install the latest version of the Azure CLI and add it to the PATH (Windows only).

## Example usage

```json
{
    "$schema": "./devinit.schema-1.0.json",
    "run": [
        {
            "comments": "Example that will trigger az login --use-device-code behavior.",
            "tool": "azurecli-login"
        }
    ]
}
```
