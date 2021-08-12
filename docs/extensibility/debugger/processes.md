---
title: Processes | Microsoft Docs
description: This article describes the definition and role of a process in the debugger architecture in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- debugging [Debugging SDK], processes
ms.assetid: a6a1efdc-b243-40c8-a778-6f69f6b018be
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
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
