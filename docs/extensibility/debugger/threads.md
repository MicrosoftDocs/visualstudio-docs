---
title: Threads | Microsoft Docs
description: This article describes the definition and role of a thread in the debugger architecture in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- debugging [Debugging SDK], threads
- threading [Debugging SDK]
ms.assetid: 2243d24a-c3d2-41d1-abbb-6db21a2db9ee
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Threads
In the debugger architecture, a *thread*:

- Is the fundamental unit of computation. A thread sequentially executes its instructions within the context of a single call stack, moving from one code context to the next.

- Can identify itself and the program it is running in. Threads can be named, suspended, and resumed. A thread can also enumerate its associated stack frames and, under some conditions, can be moved to another stack frame. Given the context of a stack frame, a thread can return its associated logical thread, if any. A thread has properties, such as a suspend count, that can be displayed in the **Threads** window of the IDE.

- Is represented by an [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md) interface, typically created by a debug engine (DE) or virtual machine as a consequence of executing a program.

## See also
- [Programs](../../extensibility/debugger/programs.md)
- [Stack frames](../../extensibility/debugger/stack-frames.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [Session debug manager](../../extensibility/debugger/session-debug-manager.md)
