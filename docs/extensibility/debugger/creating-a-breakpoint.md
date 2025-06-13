---
title: Creating a Breakpoint
description: Learn about the method calls that the session debug manager makes when the module that is needed to bind a breakpoint is loaded.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- breakpoints, creating
- debugging [Debugging SDK], creating breakpoints
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Create a breakpoint

The following describes the process of creating a breakpoint.

## Methods in breakpoint creation
 When the module that is needed to bind a breakpoint is loaded, the session debug manager (SDM) calls the following methods:

1. [IDebugPendingBreakpoint2::Enable](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enable.md)

2. [IDebugPendingBreakpoint2::Virtualize](../../extensibility/debugger/reference/idebugpendingbreakpoint2-virtualize.md)

3. [IDebugPendingBreakpoint2::CanBind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md)

    > [!NOTE]
    > **CanBind** is called only when a user makes a breakpoint from the **Breakpoints** window.

4. [IDebugPendingBreakpoint2::Bind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md)

5. [IDebugPendingBreakpoint2::EnumBoundBreakpoints](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)

## Related content
- [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)
