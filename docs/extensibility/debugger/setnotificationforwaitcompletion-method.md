---
title: "SetNotificationForWaitCompletion Method | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "SetNotificationForWaitCompletion method, Task class [.NET Framework debug engines]"
ms.assetid: da149c9a-20f4-4543-a29e-429c8c1d2e19
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# SetNotificationForWaitCompletion Method
Sets or clears the TASK_STATE_WAIT_COMPLETION_NOTIFICATION state bit.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

## Syntax

```vb
internal void SetNotificationForWaitCompletion(bool enabled)
```

### Parameters
 `enabled`

 `true` to set the bit; `false` to unset the bit.

## Exceptions

## Remarks
 The debugger sets this bit to help step out of an async method body. If `enabled` is `true`, this method must be called only on a task that has not yet been completed. When `enabled` is `false`, this method can be called on completed tasks. In either event, it should only be used for promise-style tasks.

## Requirements

## See also
- [Task class](../../extensibility/debugger/task-class-internal-members.md)