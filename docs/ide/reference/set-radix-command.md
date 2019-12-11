---
title: Set Radix Command
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.setradix"
helpviewer_keywords:
  - "Set Radix command"
  - "Debug.SetRadix command"
ms.assetid: 6ffd1554-7530-4da4-b5f5-e276a5034f3b
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Set Radix Command
Sets or returns the numeric base used to display integer values.

## Syntax

```cmd
Debug.SetRadix [10 | 16 | hex | dec]
```

## Arguments
`10` or `16` or `hex` or `dec`

Optional. Indicates decimal (10 or dec) or hexadecimal (16 or hex). If an argument is omitted, then the current radix value is returned.

## Example
This example sets the environment to display integer values in hexadecimal format.

```cmd
>Debug.SetRadix hex
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)