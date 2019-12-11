---
title: "Creating a Custom Debug Engine | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debug engines, implementing"
  - "debug engines, custom"
  - "debugging [Debugging SDK], custom debug engines"
ms.assetid: 52794238-6fae-451c-bf1c-99f344c6f173
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Create a custom debug engine
A debug engine (DE) is a component that allows debugging of particular run-time architectures. There is typically only one DE implementation per run-time environment.

> [!NOTE]
> While there are separate DE implementations for Transact-SQL and JScript, VBScript and JScript share a single DE.

 A DE works with the interpreter or operation system to provide such debugging services as execution control, breakpoints, and expression evaluation. These services are implemented through the DE interfaces and can cause the debugger to transition between different operational modes. For more information, see [Operational modes](../../extensibility/debugger/operational-modes.md).

 Creating a DE consists of the following steps:

1. Register a DE with Visual Studio

2. Enable a program to be debugged

3. Implement execution control and state evaluation

4. Send events

5. Set up termination and detaching

## In this section
 [Register a custom debug engine](../../extensibility/debugger/registering-a-custom-debug-engine.md)
 Explains the steps needed to register a debug engine with Visual Studio so that it can be used.

 [Enable a program to be debugged](../../extensibility/debugger/enabling-a-program-to-be-debugged.md)
 Explains that before your DE can debug a program, you must first launch the DE or attach it to an existing program.

 [Implement execution control and state evaluation](../../extensibility/debugger/execution-control-and-state-evaluation.md)
 Discusses why debugging an application requires implementing execution control features.

 [Send events](../../extensibility/debugger/sending-events.md)
 Describes communication between the debugger and the DE as an event model based on DCOM.

 [Set up termination and detaching](../../extensibility/debugger/termination-and-detaching.md)
 Explains how to achieve normal termination, which means that there are no breakpoints, exceptions, run-time errors, or infinite loops in the application to be debugged.

 [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)
 Documents the calling order of the events occurring in a debugging session.

 [How To: Debug a custom debug engine](../../extensibility/debugger/how-to-debug-a-custom-debug-engine.md)
 Explains how to debug a custom DE.

## See also
- [Visual Studio debugger extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)