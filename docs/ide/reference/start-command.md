---
title: Start Command
description: Learn about the Start command and how it begins debugging the startup project.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- debug.start
helpviewer_keywords:
- Start command
- Debug.Start command
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Start Command

Begins debugging the startup project.

## Syntax

```cmd
Debug.Start [address]
```

## Arguments
`address`

Optional. The address at which the program suspends execution, similar to a breakpoint in source code. This argument is only valid in debug mode.

## Remarks
The **Start** command, when executed, performs a RunToCursor operation to the specified address.

## Example
This example starts the debugger and ignores any exceptions that occur.

```cmd
>Debug.Start
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
