---
title: "Stack Frames | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "stack frames, debugging"
  - "debugging [Debugging SDK], stack frames"
  - "stack frames"
ms.assetid: b5e439d4-1e9d-4e13-9cad-bb8b136d4ca8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Stack frames
In the debugger architecture, a *stack frame*:

- Is an abstraction of a stack that provides the execution context of a thread. A thread always executes within a function. A stack frame holds the local variables of the function and the arguments to it. In order to debug with Visual Studio, the language or environment being debugged must support stack frames.

- Can both identify and describe itself, and can return the associated thread. A stack frame can also return the code context that represents the current instruction pointer and the associated documentation and expression evaluation contexts.

- Has properties that describe the name, type, and value of local variables and arguments, and which appear in various IDE debug windows.

- Is represented by an [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md) interface, typically created by a debug engine (DE) or virtual machine as a consequence of executing a thread.

## See also
- [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md)