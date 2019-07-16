---
title: "Terminating a Program | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "programs, termination events"
  - "debugging [Debugging SDK], terminating a program"
ms.assetid: eedda0a3-5e05-44fe-841d-a2f4866ac72d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Terminating a program
The following section describes the termination of a single program with one thread.

## Termination process

1. The DE sends an [IDebugThreadDestroyEvent2](../../extensibility/debugger/reference/idebugthreaddestroyevent2.md) with a valid [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md).

2. The DE sends an [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) with a valid [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md).

   The IDE goes into design mode. The debug engine or run-time environment calls [IDebugPortNotify2::RemoveProgramNode](../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md) to remove the program from the port.

## See also
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)