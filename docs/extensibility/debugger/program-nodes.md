---
title: Program Nodes
description: This article describes the definition and role of a program node in the debugger architecture in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- program nodes, debugging context
- debugging [Debugging SDK], program nodes
- program nodes, adding
- program nodes, superseding
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Program nodes

In the debugger architecture, a *program node*:

- Is a lightweight description of a program.

- Can identify itself and the process it's running in. A program node can be attached to, be detached from, and describe the debug engine (DE) that created it, if any.

- Is represented by an [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) interface, typically created by a DE or port. Program nodes are added to a port by calling [AddProgramNode](../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md). When a program node is added to a port, it's added to the process containing the program that this program node represents.

  Sometime after a debug session is started, depending on the implementation of the debug package, program nodes are used to create corresponding programs. When a process is queried for its programs, the programs are enumerated, one for each program node.

  Before a program is attached to, the IDE needs only a lightweight description of the program. This information can be obtained from the program node. Once the program is attached to, the IDE displays more detailed information, such as a list of all threads running in the program. This information is obtained from the program itself.

## See also
- [Programs](../../extensibility/debugger/programs.md)
- [Processes](../../extensibility/debugger/processes.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md)
- [AddProgramNode](../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md)
