---
title: Enabling a Program to Be Debugged
description: Learn about how to launch your debug engine or attach the debug engine to an existing program to debug a program.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], enabling for programs
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Enable a program to be debugged

Before your debug engine (DE) can debug a program, you must first launch the DE or attach it to an existing program.

## In this section

[Get a port](../../extensibility/debugger/getting-a-port.md) discusses how to obtain a port as the first step to enabling a program to be debugged.

 [Register the program](../../extensibility/debugger/registering-the-program.md) explains the next step in enabling a program to be debugged: registering it with the port. Once registered, the program can be debugged either by the process of attaching or just-in-time (JIT) debugging.

 [Attach to the program](../../extensibility/debugger/attaching-to-the-program.md) explains the next step: attaching the debugger to the program.

 [Launch-based attaching](../../extensibility/debugger/launch-based-attachment.md) describes launch-based attachment to a program, which is automatic upon launch by the SDM.

 [Send the required events](../../extensibility/debugger/sending-the-required-events.md) steps you through the required events when creating a debug engine (DE) and attaching it to a program.

## Related content

- [Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md) defines a debug engine (DE), and describes services implemented through the DE interfaces and how they can cause the debugger to transition between different operational modes.
