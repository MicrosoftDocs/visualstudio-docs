---
title: "List Threads Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "debug.listthreads"
helpviewer_keywords:
  - "ListThreads command"
  - "list threads command"
  - "Debug.ListThreads command"
ms.assetid: 34b665c0-d46f-4c1a-a066-b678eba5ac54
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# List Threads Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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

## See Also
 [List Call Stack Command](../../ide/reference/list-call-stack-command.md)
 [List Disassembly Command](../../ide/reference/list-disassembly-command.md)
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
