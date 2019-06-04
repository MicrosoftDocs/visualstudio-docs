---
title: "Breakpoints (Visual Studio SDK) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "breakpoints"
ms.assetid: acfcabed-9f2f-436c-ad18-7ca2f45d631b
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Breakpoints (Visual Studio SDK)
There are three types of breakpoints: pending, bound, and error.

 **A pending breakpoint:**

- Is an abstraction that contains all the information needed to bind a breakpoint to one or more code contexts in one or more programs. Each time a program being debugged cause code to load, the debug engine checks all pending breakpoints to see if they can be bound.

   A pending breakpoint itself never binds to code, but rather collects and is said to contain all the bound breakpoints that it generates.

- Is represented by an [IDebugPendingBreakpoint2](../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) interface.

  **A bound breakpoint:**

- Is an abstraction for a breakpoint associated with or bound to a single code context. Each bound breakpoint is generated in response to a pending breakpoint. A pending breakpoint can, however, generate more than one bound breakpoint.

   When code is unloaded, a bound breakpoint can be unbound and discarded.

- Is represented by an [IDebugBoundBreakpoint2](../../extensibility/debugger/reference/idebugboundbreakpoint2.md) interface.

  **An error breakpoint:**

- Is an abstraction for describing an error in attempting to bind a pending breakpoint to a code context. An error breakpoint describes either an error in location or in the breakpoint expression itself. For more information, see [Binding breakpoints](../../extensibility/debugger/binding-breakpoints.md).

   The breakpoint error can be either an error or a warning.

- Is represented by an [IDebugErrorBreakpoint2](../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) interface.

## See also
- [Programs](../../extensibility/debugger/programs.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [Code context](../../extensibility/debugger/code-context.md)
- [IDebugBoundBreakpoint2](../../extensibility/debugger/reference/idebugboundbreakpoint2.md)
- [IDebugPendingBreakpoint2](../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [IDebugErrorBreakpoint2](../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)