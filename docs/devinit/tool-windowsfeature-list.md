---
title: windowsfeature-list
description: devinit tool windowsfeature-list.
ms.date: 08/28/2020
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
# windowsfeature-list

The `windowsfeature-list` tool is used to list the enable/disable state of all Windows features.

| Name                                             | Type   | Required | Value                                      |
|--------------------------------------------------|--------|----------|--------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.      |
| [**input**](#input)                              | string | No       | Not used. Ignored.                         |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. Ignored.                         |

### Input

Not used. Ignored.

#### Additional options

Not used. Ignored.

### Default behavior

The default behavior of the `windowsfeature-list` tool is to list the enable/disable state of all Windows features.

## Example usage

```json
{
    "$schema": "./devinit.schema-2.0.json",
    "run": [
        {
            "comments": "Lists the state of all Windows features.",
            "tool": "windowsfeature-list"
        }
    ]
}
```
