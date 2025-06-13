---
title: Program Control
description: Learn about routines in Visual Studio debugging that occur at the program level, such as executing, stepping, continuing, and suspending/resuming threads.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], control of execution
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Program control

In Visual Studio debugging, all of the following stepping and continuing routines occur at the program level:

- Setting the next statement, that is, setting your computer to the next instruction to be executed in a particular frame environment

- Executing, that is, continuing to exit out of stepping mode

- Stepping to the next instruction

- Continuing with the current stepping mode

- Suspending the threads contained by the program

- Resuming the threads contained by the program

> [!NOTE]
> Viewing the call stack is implemented on the thread level. To enumerate the frame information when viewing the call stack for a thread, you must implement all the methods of the [IEnumDebugFrameInfo2](../../extensibility/debugger/reference/ienumdebugframeinfo2.md) interface.

## Methods of program control
 The following table shows the methods of [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) that must be implemented for a minimally functional debug engine (DE) and execution control.

|Method|Description|
|------------|-----------------|
|[IDebugProgram2::Execute](../../extensibility/debugger/reference/idebugprogram2-execute.md)|Continues running all threads contained by a program from a stopped state. Required for execution control.|
|[IDebugProgram2::Continue](../../extensibility/debugger/reference/idebugprogram2-continue.md)|Continues running all threads contained by a program from a stopped state. Required for execution control.|
|[IDebugProgram2::Step](../../extensibility/debugger/reference/idebugprogram2-step.md)|Performs a step on the given thread. Continues running all other threads contained by the program. Required for execution control.|

 For multithreaded programs, you must also implement the [IDebugProgram2::EnumThreads](../../extensibility/debugger/reference/idebugprogram2-enumthreads.md) method and all the methods of the [IEnumDebugThreads2](../../extensibility/debugger/reference/ienumdebugthreads2.md) interface.

## See also
- [Execution control and state evaluation](../../extensibility/debugger/execution-control-and-state-evaluation.md)
