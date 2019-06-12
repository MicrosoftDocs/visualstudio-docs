---
title: "Hitting a Breakpoint | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Debugging SDK], hitting breakpoints"
  - "breakpoints, hitting"
ms.assetid: a77816e3-b15b-46a0-90cd-be7242e4d6c9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Hit a breakpoint
The following section describes the process when the debug engine (DE) hits a breakpoint while running or stepping:

## Troubleshoot a hit breakpoint

1. The DE sends an [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md) interface as an **EVENT_SYNC_STOP**.

2. The session debug manager (SDM) calls [IDebugBreakpointEvent2:::EnumBreakpoints](../../extensibility/debugger/reference/idebugbreakpointevent2-enumbreakpoints.md) to get the breakpoint that was hit.

## See also
- [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)