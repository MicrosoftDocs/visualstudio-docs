---
title: Breakpoint Errors
description: Learn about the process when a breakpoint attempts to bind to code but fails and how to troubleshoot breakpoint errors.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- breakpoints, errors
- debugging [Debugging SDK], breakpoint errors
- errors [Debugging SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Breakpoint errors

The following describes the process when a breakpoint attempts to bind to code but fails.

## Troubleshoot a breakpoint error

1. The debug engine (DE) sends an [IDebugBreakpointErrorEvent2](../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md) to the session debug manager (SDM).

2. The SDM calls [IDebugBreakpointErrorEvent2::GetErrorBreakpoint](../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md) (IDebugErrorBreakpoint2** `ppErrorBP`) to get the error breakpoint.

3. The SDM calls [IDebugErrorBreakpoint2::GetPendingBreakpoint](../../extensibility/debugger/reference/idebugerrorbreakpoint2-getpendingbreakpoint.md) to get the pending breakpoint from which the error breakpoint originated.

4. The SDM calls [IDebugErrorBreakpoint2::GetBreakpointResolution](../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md) to get the reason why the error breakpoint failed to bind.

## Related content
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
