---
title: Start Command
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.start"
helpviewer_keywords:
  - "Start command"
  - "Debug.Start command"
ms.assetid: dc4e4aa2-b0ab-4e00-92db-6dc3058ddc21
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
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