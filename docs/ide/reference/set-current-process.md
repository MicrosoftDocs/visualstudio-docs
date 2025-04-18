---
title: Set Current Process
description: Learn about the Set Current Process command and how it sets the specified process as the active process in the debugger.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Debug.SetCurrentProcess command
- Set Current Process command
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Set Current Process

Sets the specified process as the active process in the debugger.

## Syntax

```cmd
Debug.SetCurrentProcess index
```

## Arguments
`index`

Required. The index of the process.

## Remarks
You can attach to multiple processes when you are debugging, but only one process is active in the dubber at any given time. You can use the `SetCurrentProcess` command to set the active process.

## Example

```cmd
>Debug.SetCurrentProcess 1
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
