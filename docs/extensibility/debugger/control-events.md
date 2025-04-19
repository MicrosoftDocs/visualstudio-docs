---
title: Control Events
description: Learn about sending events during the controlled execution of your program by using the IDebugEvent2 interface.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], events
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Control events

You must send events during the controlled execution of your program. All of the events are sent using the [IDebugEvent2](../../extensibility/debugger/reference/idebugevent2.md) interface and have attributes that require you to implement the [IDebugEvent2::GetAttributes](../../extensibility/debugger/reference/idebugevent2-getattributes.md) method.

## Additional methods
 Some events require implementation of additional methods, as follows:

- Sending the [IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md) interface when the debug engine (DE) is initialized requires you to implement the [IDebugEngineCreateEvent2::GetEngine](../../extensibility/debugger/reference/idebugenginecreateevent2-getengine.md) method.

- Execution control requires implementation of such control events as the [IDebugBreakEvent2](../../extensibility/debugger/reference/idebugbreakevent2.md) and [IDebugStepCompleteEvent2](../../extensibility/debugger/reference/idebugstepcompleteevent2.md) interfaces. **IDebugBreakEvent2** is required only for asynchronous breaks.

- Stepping into functions requires implementation of the [IDebugStepCompleteEvent2](../../extensibility/debugger/reference/idebugstepcompleteevent2.md) interface and its methods.

  Events deriving from breakpoints require implementation of the [IDebugBreakpointErrorEvent2](../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md), [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md), and [IDebugBreakpointBoundEvent2](../../extensibility/debugger/reference/idebugbreakpointboundevent2.md) interfaces, as well as the [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../../extensibility/debugger/reference/idebugbreakpointboundevent2-getpendingbreakpoint.md) and [EnumBoundBreakpoints](../../extensibility/debugger/reference/idebugbreakpointboundevent2-enumboundbreakpoints.md) methods.

  Asynchronous expression evaluation requires you to implement the [IDebugExpressionEvaluationCompleteEvent2](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) interface and its [IDebugExpressionEvaluationCompleteEvent2::GetExpression](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getexpression.md)[and GetResult](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getresult.md) methods.

  Synchronous events require implementing the [IDebugEngine2::ContinueFromSynchronousEvent](../../extensibility/debugger/reference/idebugengine2-continuefromsynchronousevent.md) method.

  For your engine to write string-style output, you must implement the [IDebugOutputStringEvent2::GetString](../../extensibility/debugger/reference/idebugoutputstringevent2-getstring.md) method.

## See also
- [Execution control and state evaluation](../../extensibility/debugger/execution-control-and-state-evaluation.md)
