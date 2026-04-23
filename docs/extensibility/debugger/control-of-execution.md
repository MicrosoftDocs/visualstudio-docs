---
title: Control of Execution
description: Learn about stopping events, which means that the DE waits for a response from the user by means of the IDE.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debugging [Debugging SDK], control of execution
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Control of execution

The debug engine (DE) typically sends one of the following events as the last startup event:

- The entry point event, if attaching to a newly launched program

- The load complete event, if attaching to a program that is already running

  Both these events are stopping events, meaning that the DE waits for a response from the user by means of the IDE. For more information, see [Operational modes](../../extensibility/debugger/operational-modes.md).

## Stopping event
 When a stopping event is sent to the debug session:

1. The program and thread that contain the current instruction pointer can be obtained from the event interface.

2. The IDE determines the current source code file and position, which it displays as highlighted in the editor.

3. The debug session typically responds to this first stopping event by calling the program's **Continue** method.

4. The program then runs until it encounters a stopping condition, such as hitting a breakpoint. In which case, the DE sends a breakpoint event to the debug session. The breakpoint event is a stopping event, and the DE again waits for a user response.

5. If the user elects to step into, over, or out of a function, the IDE prompts the debug session to call the program's `Step` method. The IDE then passes the unit of step (instruction, statement, or line) and the type of step (whether to step into, over, or out of the function). When the step is complete, the DE sends a step complete event to the debug session, which is a stopping event.

    -or-

    If the user elects to continue executing from the current instruction pointer, the IDE prompts the debug session to call the program's **Execute** method. The program resumes execution until it encounters the next stopping condition.

    -or-

    If the debug session is to ignore a particular stopping event, the debug session calls the program's **Continue** method. If the program was stepping into, over, or out of a function when it encountered the stopping condition, then it continues the step.

   Programmatically, when the DE encounters a stopping condition, it sends such stopping events as [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) or [IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md) to the session debug manager (SDM) by means of an [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md) interface. The DE passes the [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) and [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md) interfaces that represent the program and the thread containing the current instruction pointer. The SDM calls [IDebugThread2::EnumFrameInfo](../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md) to get the top stack frame and calls [IDebugStackFrame2::GetDocumentContext](../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md) to get the document context associated with the current instruction pointer. This document context is typically a source code file name, line, and column number. The IDE uses these to highlight the source code that contains the current instruction pointer.

   The SDM typically responds to this first stopping event by calling [IDebugProgram2::Continue](../../extensibility/debugger/reference/idebugprogram2-continue.md). The program then runs until it encounters a stopping condition, such as hitting a breakpoint, in which case the DE sends an [IDebugBreakpointEvent2 Interface](../../extensibility/debugger/reference/idebugbreakpointevent2.md) to the SDM. The breakpoint event is a stopping event, and the DE again waits for a user response.

   If the user elects to step into, over, or out of a function, the IDE prompts the SDM to call [IDebugProgram2::Step](../../extensibility/debugger/reference/idebugprogram2-step.md). The IDE then passes the [STEPUNIT](../../extensibility/debugger/reference/stepunit.md) (instruction, statement, or line) and the [STEPKIND](../../extensibility/debugger/reference/stepkind.md), that is, whether to step into, over, or out of the function. When the step is complete, the DE sends an [IDebugStepCompleteEvent2](../../extensibility/debugger/reference/idebugstepcompleteevent2.md) interface to the SDM, which is a stopping event.

   If the user elects to continue executing from the current instruction pointer, the IDE asks the SDM to call [IDebugProgram2::Execute](../../extensibility/debugger/reference/idebugprogram2-execute.md). The program resumes execution until it encounters the next stopping condition.

   If the debug package is to ignore a particular stopping event, the debug package calls the SDM, which calls [IDebugProgram2::Continue](../../extensibility/debugger/reference/idebugprogram2-continue.md). If the program was stepping into, over, or out of a function when it encountered the stopping condition, it continues the step. This implies that the program maintains a stepping state, so that it knows how to continue.

   The calls the SDM makes to `Step`, **Execute**, and **Continue** are asynchronous, which means that the SDM expects the call to return quickly. If the DE sends the SDM a stopping event on the same thread before `Step`, **Execute**, or **Continue** returns, the SDM stops responding.

## Related content
- [Debug tasks](../../extensibility/debugger/debugging-tasks.md)
