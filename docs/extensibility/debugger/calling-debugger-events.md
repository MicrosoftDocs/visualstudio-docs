---
title: Calling Debugger Events
description: Events in debugging sessions occur in a specific order. This article lists the calling order of the events that occur in a typical debugging session.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debugging [Debugging SDK], events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Call debugger events

Events in debugging sessions occur in a specific order.

## Discussion
 To understand the pattern of calls between the debug engine (DE) and the session debug manager (SDM), the following represents the calling order of the events that occur in a typical debugging session:

1. [Attaching and detaching to a program](../../extensibility/debugger/attaching-and-detaching-to-a-program.md)

2. [Launching the debugger](../../extensibility/debugger/launching-the-debugger.md)

3. [Terminating a program](../../extensibility/debugger/terminating-a-program.md)

4. [Creating a breakpoint](../../extensibility/debugger/creating-a-breakpoint.md)

5. [When a breakpoint binds or becoming unbound](../../extensibility/debugger/when-a-breakpoint-binds-or-becomes-unbound.md)

6. [Breakpoint errors](../../extensibility/debugger/breakpoint-errors.md)

7. [Hitting a breakpoint](../../extensibility/debugger/hitting-a-breakpoint.md)

8. [Deleting a breakpoint](../../extensibility/debugger/deleting-a-breakpoint.md)

9. [Entering break mode](../../extensibility/debugger/entering-break-mode.md)

10. [Stepping in break mode](../../extensibility/debugger/stepping-in-break-mode.md)

11. [Expression evaluation in break mode](../../extensibility/debugger/expression-evaluation-in-break-mode.md)

12. [Exception handling](../../extensibility/debugger/exception-handling-visual-studio-sdk.md)

## Related content
- [Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)
