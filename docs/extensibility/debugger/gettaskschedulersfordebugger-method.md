---
description: "Retrieves an array of all System.Threading.Tasks.TaskScheduler objects that are currently active."
title: GetTaskSchedulersForDebugger Method | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetTaskSchedulersForDebugger method, TaskScheduler class [.NET Framework debug engines]
ms.assetid: 58aa236a-5ab8-4695-b303-89dffdbcd946
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# GetTaskSchedulersForDebugger Method
Retrieves an array of all <xref:System.Threading.Tasks.TaskScheduler> objects that are currently active.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

 Because you can't access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.method assembly hidebysig static class System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger() cil managed
```

## Return value
 An array of all <xref:System.Threading.Tasks.TaskScheduler> objects that are currently active in this <xref:System.AppDomain>.

## Remarks
 This method is not thread safe and you shouldn't use it concurrently with other instances of <xref:System.Threading.Tasks.TaskScheduler>. Call this method from a debugger only when the debugger has suspended all other threads.

## See also
- [TaskScheduler class](../../extensibility/debugger/taskscheduler-class-internal-members.md)
