---
title: Terminating a Program
description: This article describes how the IDE uses the debug engine to terminate a single program with a single thread.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- programs, termination events
- debugging [Debugging SDK], terminating a program
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Terminating a program

The following section describes the termination of a single program with one thread.

## Termination process

1. The DE sends an [IDebugThreadDestroyEvent2](../../extensibility/debugger/reference/idebugthreaddestroyevent2.md) with a valid [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md).

2. The DE sends an [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) with a valid [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md).

   The IDE goes into design mode. The debug engine or run-time environment calls [IDebugPortNotify2::RemoveProgramNode](../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md) to remove the program from the port.

## Related content
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
