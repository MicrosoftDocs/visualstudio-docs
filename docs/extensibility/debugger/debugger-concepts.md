---
title: Debugger Concepts
description: Learn about the architectural concepts used in designing the Visual Studio debug package to help you build on that package.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- debugging [Debugging SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugger concepts

To build on the Visual Studio debug package, you need to be familiar with the architectural concepts used in designing the package.

## In this section

[Debug session](../../extensibility/debugger/debug-session.md) explains the role of a session in the debugging architecture.

 [Servers](../../extensibility/debugger/servers-visual-studio-sdk.md) defines what a server is in terms of debugging architecture, in both abstract and physical terms.

 [Port suppliers](../../extensibility/debugger/port-suppliers.md) defines what a port supplier is in terms of debugging architecture.

 [Ports](../../extensibility/debugger/ports.md) defines what a port is in terms of debugging architecture.

 [Processes](../../extensibility/debugger/processes.md) defines what a process is in terms of debugging architecture.

 [Program nodes](../../extensibility/debugger/program-nodes.md) defines a program node in terms of debugging architecture, including how it can identify itself and the process it is running in.

 [Programs](../../extensibility/debugger/programs.md) defines a program in terms of debugging architecture.

 [Threads](../../extensibility/debugger/threads.md) defines the characteristics of threads in terms of debugging architecture.

 [Stack frames](../../extensibility/debugger/stack-frames.md) defines a stack frame in terms of debugging architecture. A stack frame is an abstraction of a stack that provides the execution context of a thread.

 [Modules](../../extensibility/debugger/modules.md) defines a module, in terms of debugging architecture, as a physical container of code, such as an executable file or a DLL.

 [Breakpoints](../../extensibility/debugger/breakpoints-visual-studio-sdk.md) defines the three types of breakpoints—pending, bound, and error—in terms of debugging architecture.

## Related sections

[Debugger contexts](../../extensibility/debugger/debugger-contexts.md) explains how the debug engine (DE) operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.

 [Debugger components](../../extensibility/debugger/debugger-components.md) provides an overview of the Visual Studio Debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).

 [Debug tasks](../../extensibility/debugger/debugging-tasks.md) contains links to various debugging tasks, such as launching a program and evaluating expressions.
