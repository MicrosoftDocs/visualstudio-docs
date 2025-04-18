---
title: Set Radix Command
description: Learn about the Set Radix command and how it sets or returns the numeric base used to display integer values.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.setradix"
helpviewer_keywords:
  - "Set Radix command"
  - "Debug.SetRadix command"
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
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