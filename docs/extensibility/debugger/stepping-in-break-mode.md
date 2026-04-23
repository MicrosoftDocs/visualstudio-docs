---
title: Stepping in Break Mode
description: Learn about the process that occurs when the debugger is in break mode. The debugger must then step through code.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- break mode, stepping
- stepping, in break mode
- debugging [Debugging SDK], stepping in break mode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Stepping in break mode

The following section describes the process that occurs when the debugger is in break mode and must step through code:

## Stepping process

1. Call [IDebugProgram2::Step](../../extensibility/debugger/reference/idebugprogram2-step.md) with [STEPKIND](../../extensibility/debugger/reference/stepkind.md) and [STEPUNIT](../../extensibility/debugger/reference/stepunit.md) arguments to execute a step.

2. When the step is finished, send an [IDebugStepCompleteEvent2](../../extensibility/debugger/reference/idebugstepcompleteevent2.md) as a stopping event.

## Related content
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
