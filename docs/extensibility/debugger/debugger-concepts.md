---
title: Debugger Concepts | Microsoft Docs
description: Learn about the architectural concepts used in designing the Visual Studio debug package to help you build on that package.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK]
ms.assetid: 2d371d38-f1a0-4a9a-8ea3-100e8c0149b7
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Debugger concepts
To build on the Visual Studio debug package, you need to be familiar with the architectural concepts used in designing the package.

## In this section
 [Debug session](../../extensibility/debugger/debug-session.md)
 Explains the role of a session in the debugging architecture.

 [Servers](../../extensibility/debugger/servers-visual-studio-sdk.md)
 Defines what a server is in terms of debugging architecture, in both abstract and physical terms.

 [Port suppliers](../../extensibility/debugger/port-suppliers.md)
 Defines what a port supplier is in terms of debugging architecture.

 [Ports](../../extensibility/debugger/ports.md)
 Defines what a port is in terms of debugging architecture.

 [Processes](../../extensibility/debugger/processes.md)
 Defines what a process is in terms of debugging architecture.

 [Program nodes](../../extensibility/debugger/program-nodes.md)
 Defines a program node in terms of debugging architecture, including how it can identify itself and the process it is running in.

 [Programs](../../extensibility/debugger/programs.md)
 Defines a program in terms of debugging architecture.

 [Threads](../../extensibility/debugger/threads.md)
 Defines the characteristics of threads in terms of debugging architecture.

 [Stack frames](../../extensibility/debugger/stack-frames.md)
 Defines a stack frame in terms of debugging architecture. A stack frame is an abstraction of a stack that provides the execution context of a thread.

 [Modules](../../extensibility/debugger/modules.md)
 Defines a module, in terms of debugging architecture, as a physical container of code, such as an executable file or a DLL.

 [Breakpoints](../../extensibility/debugger/breakpoints-visual-studio-sdk.md)
 Defines the three types of breakpoints—pending, bound, and error—in terms of debugging architecture.

## Related sections
 [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
 Explains how the debug engine (DE) operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.

 [Debugger components](../../extensibility/debugger/debugger-components.md)
 Provides an overview of the Visual Studio Debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).

 [Debug tasks](../../extensibility/debugger/debugging-tasks.md)
 Contains links to various debugging tasks, such as launching a program and evaluating expressions.
