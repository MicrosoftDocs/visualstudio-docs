---
title: Deleting a Breakpoint
description: Learn how the session debug manager removes a pending breakpoint and all bound breakpoints bound from it when a pending breakpoint is deleted.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- breakpoints, deleting
- debugging [Debugging SDK], deleting breakpoints
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Deleting a breakpoint

The following describes the process when deleting a pending breakpoint:

## Deletion process
 The session debug manager (SDM) calls the [IDebugPendingBreakpoint2::Delete](../../extensibility/debugger/reference/idebugpendingbreakpoint2-delete.md) method to remove the pending breakpoint and all bound breakpoints bound from it.

> [!NOTE]
> A single bound breakpoint can also be deleted by a call to [IDebugBoundBreakpoint2::Delete](../../extensibility/debugger/reference/idebugboundbreakpoint2-delete.md).

## Related content
- [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)
