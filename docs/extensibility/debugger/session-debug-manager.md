---
title: Session Debug Manager
description: Learn about the session debug manager, which manages multiple debug engines debugging programs in multiple processes across any number of machines.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- session debug manager, unifying session views
- session debug manager, broadcasting
- debugging [Debugging SDK], session debug manager
- session debug manager
- session debug manager, debug engine multiplexing
- session debug manager, delegating
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Session debug manager

The session debug manager (SDM) manages any number of debug engines (DE) that are debugging any number of programs in multiple processes across any number of machines. In addition to being a debug engine multiplexer, the SDM provides a unified view of the debug session to the IDE.

## Session debug manager operation
 The session debug manager (SDM) manages the DE. There can be more than one debug engine running on a machine at the same time. To multiplex the DEs, the SDM wraps a number of interfaces from the DEs and exposes them to the IDE as a single interface.

 To increase performance, some interfaces aren't multiplexed. Instead, they are used directly from the DE, and calls to these interfaces don't go through the SDM. For example, interfaces used with memory, code, and document contexts aren't multiplexed, because they refer to a specific instruction, memory, or document in a specific program debugged by a specific DE. No other DE needs to be involved in that level of communication.

 This is not true of all contexts. Calls to the expression evaluation context interface go through the SDM. During expression evaluation, the SDM wraps the [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface that it gives to the IDE because when that expression is evaluated, it may involve multiple DEs that are debugging programs in the same process that might be running on the same thread.

 The SDM typically acts as a delegation mechanism, but it might act as a broadcast mechanism. For example, during expression evaluation, the SDM acts as a broadcast mechanism to notify all DEs that they can run code on a specified thread. Similarly, when the SDM receives a stopping event, it broadcasts to the programs that they should stop running. When a step is called, the SDM broadcasts to the programs that they can continue running. Breakpoints are also broadcast to every DE.

 The SDM does not track the current program, thread, or stack frame. The process, program, and thread information are sent to the SDM in conjunction with specific debugging events.

## See also
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [Debugger components](../../extensibility/debugger/debugger-components.md)
- [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
