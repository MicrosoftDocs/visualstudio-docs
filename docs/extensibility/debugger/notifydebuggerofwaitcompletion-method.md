---
title: NotifyDebuggerOfWaitCompletion Method | Microsoft Docs
description: Learn about the NotifyDebuggerOfWaitCompletion method, which is a placeholder used as a breakpoint target by the debugger.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- NotifyDebuggerOfWaitCompletion method, Task class [.NET Framework debug engines]
ms.assetid: 841c5908-4f3f-400b-a7b0-96a95f362817
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# NotifyDebuggerOfWaitCompletion method
Placeholder method used as a breakpoint target by the debugger. This method must not be inlined or optimized.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

## Syntax

```vb
private void NotifyDebuggerOfWaitCompletion()
```

## Remarks
 All join operations with a task should call this method if their debugger notification bit is set.

## Requirements

## See also
- [Task class](../../extensibility/debugger/task-class-internal-members.md)
