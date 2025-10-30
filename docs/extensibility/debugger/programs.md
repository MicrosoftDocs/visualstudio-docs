---
title: Programs
description: This article describes the definition and role of a program in the debugger architecture in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debugging [Debugging SDK], programs
- programs, debugging
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Programs

In the debugger architecture, a *program*:

- Is a container for both a set of threads and a set of modules. A program has no single analogy in the Windows operating system.

     A program is a kind of subprocess. For example, when you are debugging a Web site, a script can be seen as a program. While a script runs in the scripting engine process, independent of other scripts, it also has its own set of threads. A debug engine (DE) attaches to a program, and not to a process or a thread.

- Can identify itself and the process it's running in. A program can be attached to, be detached from, and describe the DE that created it, if any. A program can also execute, stop, continue, and be terminated.

- Can enumerate all its threads. A program can also supply its own disassembly stream, and can enumerate all the code contexts of a given document position.

- Is represented by an [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) interface, created before the program is attached, or as part of the attach process, depending on the implementation. When a port enumerates the programs of a process, each program is created in accordance with a corresponding [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) interface passed as an argument to [AddProgramNode](../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md). While debug engines also create `IDebugProgram2` interfaces to represent programs, these programs are not created in accordance with a program node. The `IDebugProgramNode2` interfaces created by a DE are used for actual debugging, while those created by a port are used only for discovering which programs are running in a process.

## See also
- [Processes](../../extensibility/debugger/processes.md)
- [Program nodes](../../extensibility/debugger/program-nodes.md)
- [Modules](../../extensibility/debugger/modules.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [Document position](../../extensibility/debugger/document-position.md)
- [Code context](../../extensibility/debugger/code-context.md)
- [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md)
- [AddProgramNode](../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md)
