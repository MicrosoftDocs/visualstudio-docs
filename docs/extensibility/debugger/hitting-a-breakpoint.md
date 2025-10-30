---
title: Hitting a Breakpoint
description: This article describes the process that takes place when the debug engine hits a breakpoint while running or stepping.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debugging [Debugging SDK], hitting breakpoints
- breakpoints, hitting
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Hit a breakpoint

The following section describes the process when the debug engine (DE) hits a breakpoint while running or stepping:

## Troubleshoot a hit breakpoint

1. The DE sends an [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md) interface as an **EVENT_SYNC_STOP**.

2. The session debug manager (SDM) calls [IDebugBreakpointEvent2:::EnumBreakpoints](../../extensibility/debugger/reference/idebugbreakpointevent2-enumbreakpoints.md) to get the breakpoint that was hit.

## Related content
- [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)
