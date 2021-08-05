---
title: Task Class - Internal Members | Microsoft Docs
description: Learn about the internal members of the System.Threading.Tasks.Task class that help you implement a custom debugger. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- debug engines, Task class [.NET Framework]
- Task class [.NET Framework debug engines]
ms.assetid: 28e47c3b-9323-424a-80ac-6cc3bf19e09b
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Task class - internal members
This article describes the internal members of the <xref:System.Threading.Tasks.Task?displayProperty=fullName> class that help you implement a custom debugger. For general information about this class, see the <xref:System.Threading.Tasks.Task> reference article.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

 Because you can't access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.class public auto ansi System.Threading.Tasks.Task
       extends System.Object
       implements System.Threading.IThreadPoolWorkItem,
                  System.IAsyncResult,
                  System.IDisposable,
                  System.Threading.ICancelableOperation
```

## Members

### Methods

|Name|Description|
|----------|-----------------|
|[SetNotificationForWaitCompletion Method](../../extensibility/debugger/setnotificationforwaitcompletion-method.md)|Sets or clears the TASK_STATE_WAIT_COMPLETION_NOTIFICATION state bit.|
|[NotifyDebuggerOfWaitCompletion Method](../../extensibility/debugger/notifydebuggerofwaitcompletion-method.md)|Placeholder method used as a breakpoint target by the debugger.|

### Fields

|Name|Description|
|----------|-----------------|
|[m_action](../../extensibility/debugger/m-action-field.md)|The delegate that represents the code to execute in the <xref:System.Threading.Tasks.Task> object.|
|[m_contingentProperties](../../extensibility/debugger/m-contingentproperties-field.md)|Stores additional properties of the <xref:System.Threading.Tasks.Task> object.|
|[m_parent](../../extensibility/debugger/m-parent-field.md)|The backing field for the <xref:System.Threading.Tasks.Task?displayProperty=fullName> parent property.|
|[m_stateFlags](../../extensibility/debugger/m-stateflags-field.md)|Stores information about the current state of the <xref:System.Threading.Tasks.Task> object.|
|[m_stateObject](../../extensibility/debugger/m-stateobject-field.md)|An object that represents data that will be used by the action.|
|[m_taskId](../../extensibility/debugger/m-taskid-field.md)|The backing field for the <xref:System.Threading.Tasks.Task.Id%2A?displayProperty=fullName> property.|
|[s_taskIdCounter](../../extensibility/debugger/s-taskidcounter-field.md)|The next available identifier for a <xref:System.Threading.Tasks.Task> object.|
|[TASK_STATE_CANCELED](../../extensibility/debugger/task-state-canceled-field.md)|Indicates that the task canceled before it reached the running state, or that the task confirmed its cancellation and completed without exception.|
|[TASK_STATE_EXECUTED](../../extensibility/debugger/task-state-executed-field.md)|Indicates that the task is running.|
|[TASK_STATE_FAULTED](../../extensibility/debugger/task-state-faulted-field.md)|Indicates that the task completed because of an unhandled exception.|
|[TASK_STATE_RAN_TO_COMPLETION](../../extensibility/debugger/task-state-ran-to-completion-field.md)|Indicates that the task completed execution successfully.|
|[TASK_STATE_WAITING_ON_CHILDREN](../../extensibility/debugger/task-state-waiting-on-children-field.md)|Indicates that the task finished executing its delegate and is implicitly waiting for attached child tasks to finish.|

## Remarks
 The following internal methods are useful to a debugger engine because they mark the entrance to <xref:System.Threading.Tasks.Task> code execution:

- `Execute`

- `ExecuteEntry`

- `ExecuteWithThreadLocal`

- `Finish`

- `InnerInvoke`

- `InternalWait`

## See also
- <xref:System.Threading.Tasks.Task?displayProperty=fullName>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
