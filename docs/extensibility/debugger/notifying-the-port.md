---
title: Notifying the Port
description: Learn how the port is notified after launching a program. This article contains a detailed description.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- ports, notification
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Notify the port

After launching a program, the port must be notified, as follows:

1. When a port receives a new program node, it sends a program creation event back to the debug session. The event carries with it an interface that represents the program.

2. The debug session queries the program for the identifier of a debug engine (DE) that can attach to.

3. The debug session checks to see if the DE is on the list of allowable DEs for that program. The debug session gets this list from the solution's active program settings, originally passed to it by the debug package.

    The DE must be on the allowable list, or else the DE will not be attached to the program.

   Programmatically, when a port first receives a new program node, it creates an [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) interface to represent the program.

> [!NOTE]
> This should not be confused with the `IDebugProgram2` interface created later by the debug engine (DE).

 The port sends an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) program creation event back to the session debug manager (SDM) by means of a COM `IConnectionPoint` interface.

> [!NOTE]
> This should not be confused with the `IDebugProgramCreateEvent2` interface, which is sent later by the DE.

 Along with the event interface itself, the port sends the [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md), [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md), and [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) interfaces, which represent the port, process, and program, respectively. The SDM calls [IDebugProgram2::GetEngineInfo](../../extensibility/debugger/reference/idebugprogram2-getengineinfo.md) to get the GUID of the DE that can debug the program. The GUID was originally obtained from the [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) interface.

 The SDM checks to see if the DE is on the list of allowable DEs. The SDM gets this list from the solution's active program settings, originally passed to it by the debug package. The DE must be on the allowable list, or else it will not be attached to the program.

 Once the identity of the DE is known, the SDM is ready to attach it to the program.

## Related content
- [Launching a program](../../extensibility/debugger/launching-a-program.md)
- [Attaching after a launch](../../extensibility/debugger/attaching-after-a-launch.md)
- [Debugging tasks](../../extensibility/debugger/debugging-tasks.md)
