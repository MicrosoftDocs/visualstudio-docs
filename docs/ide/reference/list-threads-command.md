---
title: List Threads Command
description: Learn about the List Threads command and how it displays a list of the threads in the current program.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- debug.listthreads
helpviewer_keywords:
- ListThreads command
- list threads command
- Debug.ListThreads command
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# List Threads Command

Displays a list of the threads in the current program.

## Syntax

```
Debug.ListThreads [index]
```

## Arguments
`index`

Optional. Selects a thread by its index to be the current thread.

## Remarks
When specified, the `index` argument marks the indicated thread as the current thread. An asterisk (*) is displayed in the list next to the current thread.

## Example

```
>Debug.ListThreads
```

## See also

- [List Call Stack Command](../../ide/reference/list-call-stack-command.md)
- [List Disassembly Command](../../ide/reference/list-disassembly-command.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
