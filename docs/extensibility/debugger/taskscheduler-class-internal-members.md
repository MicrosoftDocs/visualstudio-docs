---
title: "TaskScheduler Class - Internal Members | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "TaskScheduler class [.NET Framework debug engines]"
  - "debug engines, TaskScheduler class [.NET Framework]"
ms.assetid: 87f1c969-0217-4464-8907-7609c1bf61d3
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# TaskScheduler Class - Internal members
This article describes the internal members of the <xref:System.Threading.Tasks.TaskScheduler?displayProperty=fullName> class that help you implement a custom debugger. For general information about this class, see the <xref:System.Threading.Tasks.TaskScheduler> reference article.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

 Because you can't access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.class public abstract auto ansi beforefieldinit System.Threading.Tasks.TaskScheduler
       extends System.Object
```

## Members

### Methods

|Name|Description|
|----------|-----------------|
|[GetScheduledTasksForDebugger](../../extensibility/debugger/getscheduledtasksfordebugger-method.md)|Retrieves an array of all scheduled tasks.|
|[GetTaskSchedulersForDebugger](../../extensibility/debugger/gettaskschedulersfordebugger-method.md)|Retrieves an array of all <xref:System.Threading.Tasks.TaskScheduler> objects that are currently active.|

## Remarks

## See also
- <xref:System.Threading.Tasks.TaskScheduler?displayProperty=fullName>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)