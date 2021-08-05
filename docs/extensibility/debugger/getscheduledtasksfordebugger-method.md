---
description: "Retrieves an array of all scheduled tasks."
title: GetScheduledTasksForDebugger Method | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetScheduledTasksForDebugger method, TaskScheduler class [.NET Framework debug engines]
ms.assetid: 7c9b4cde-6e4a-4cef-929f-7d02b1da5762
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# GetScheduledTasksForDebugger Method
Retrieves an array of all scheduled tasks.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

 Because you can't access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.method assembly hidebysig instance class System.Threading.Tasks.Task[] GetScheduledTasksForDebugger() cil managed
```

## Return Value
 An array of all scheduled tasks. Each task is executing or has finished executing.

## Remarks
 This method is not thread safe and you shouldn't use it concurrently with other instances of <xref:System.Threading.Tasks.TaskScheduler>. Call this method from a debugger only when the debugger has suspended all other threads.

## See also
- [TaskScheduler class](../../extensibility/debugger/taskscheduler-class-internal-members.md)
