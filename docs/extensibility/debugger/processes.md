---
title: Processes
description: This article describes the definition and role of a process in the debugger architecture in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debugging [Debugging SDK], processes
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Processes

In the debugger architecture, a *process*:

- Is a container for a set of programs. It is closely analogous to a Windows process, which is a container for a set of threads.

- Can identify itself by name, identifier, or physical identifier.

- Can enumerate all running programs (and their threads).

- Can describe itself, the port it is running in, and the machine that contains it.

- Can create one or more programs, terminate any of the programs it creates, or cause a program to stop.

- Is represented by an [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md) interface, which is created when the process is launched. A process is launched by either the session debug manager (SDM) or [LaunchSuspended](../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md).

  The debug package can attach a debug engine (DE) to a process by calling [Attach](../../extensibility/debugger/reference/idebugprocess2-attach.md), which means that the DE attaches to all possible programs running in the process that it can handle. For example, if the common language runtime DE attaches to a process, it attaches only to programs that are running managed code.

## See also
- [Programs](../../extensibility/debugger/programs.md)
- [Threads](../../extensibility/debugger/threads.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [Debug package](../../extensibility/debugger/debug-package.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md)
- [LaunchSuspended](../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)
- [Attach](../../extensibility/debugger/reference/idebugprocess2-attach.md)
