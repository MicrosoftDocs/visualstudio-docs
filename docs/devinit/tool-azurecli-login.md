---
title: azurecli-login
description: devinit tool azurecli-login.
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
# azurecli-login

The `azurecli-login` tool is used to sign into Azure Active Directory via [Azure CLI](/cli/azure/authenticate-azure-cli?preserve-view=true&view=azure-cli-latest). This tool uses the Azure CLI command: `az login --use-device-code`, to complete the login you will need to follow instructions printed to the console.

## Usage

If both properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

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

The default behavior of the `azurecli-login` tool is to install the latest version of the Azure CLI and add it to the `PATH`.

## Example usage
Below is an example of how to run `azurecli-login` using a `.devinit.json`.

#### .devinit.json that will trigger Azure login:

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "azurecli-login"
        }
    ]
}
```