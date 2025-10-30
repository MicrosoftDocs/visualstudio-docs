---
title: When a Breakpoint Binds or Becomes Unbound
description: Explore unbound breakpoints. When a breakpoint can't be bound at the time a call is made, the bind time and create time of the breakpoint are different.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debugging [Debugging SDK], breakpoint unbound events
- breakpoint bound events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# When a breakpoint binds or becomes unbound

When a breakpoint can't be bound at the time a call is made to the [IDebugPendingBreakpoint2::CanBind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md) method, the bind time and create time of the breakpoint are different.

## Methods called
 The session debug manager (SDM) calls the following methods:

1. [IDebugEngine2::CreatePendingBreakpoint](../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md). The DE returns an [IDebugPendingBreakpoint2](../../extensibility/debugger/reference/idebugpendingbreakpoint2.md).

2. [IDebugPendingBreakpoint2::Enable](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enable.md).

3. [IDebugPendingBreakpoint2::Virtualize](../../extensibility/debugger/reference/idebugpendingbreakpoint2-virtualize.md).

4. The [IDebugPendingBreakpoint2::Bind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md) method and returns S_OK. The DE sends an [IDebugBreakpointBoundEvent2](../../extensibility/debugger/reference/idebugbreakpointboundevent2.md) or [IDebugBreakpointErrorEvent2](../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md).

5. [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../../extensibility/debugger/reference/idebugbreakpointboundevent2-getpendingbreakpoint.md) and [IDebugBreakpointBoundEvent2::EnumBoundBreakpoints](../../extensibility/debugger/reference/idebugbreakpointboundevent2-enumboundbreakpoints.md) methods to verify and to get the bound breakpoints.

## Related content
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
