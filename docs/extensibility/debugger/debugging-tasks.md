---
title: Debugging Tasks | Microsoft Docs
description: Learn about the tasks necessary to debug a program, such as attaching it to a debug engine, generating startup events, and hitting breakpoints.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: overview
helpviewer_keywords:
- debugging [Debugging SDK], tasks
ms.assetid: 5d60e9e8-305e-4a48-829f-b9440fc8af7b
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Debug tasks
To debug a program, it must be launched and a debug engine (DE) must be attached to it, or else the DE must be attached to a previously launched program. Once attached, the DE must generate certain startup events. In response, the debug package attempts to bind the breakpoints set in the IDE. When the program hits a bound breakpoint, it halts and waits for user input.

## In this section
 [Security issues](../../extensibility/debugger/security-issues.md)
 Discusses the security steps that are needed to debug a program.

 [Launch a program](../../extensibility/debugger/launching-a-program.md)
 Provides step-by-step instructions on how to specify a DE, which calls the operating system to launch the program.

 [Attach directly to a program](../../extensibility/debugger/attaching-directly-to-a-program.md)
 Describes the process used to debug a program in a process that is already running.

 [Send startup events after a launch](../../extensibility/debugger/sending-startup-events-after-a-launch.md)
 Lists the events that take place once the DE is attached to the program, until the program is at its main entry point and is ready for debugging.

 [Control of execution](../../extensibility/debugger/control-of-execution.md)
 Explains how the DE typically sends an entry-point event, a load-complete event, or a stopping event, depending on the circumstances.

 [Bind breakpoints](../../extensibility/debugger/binding-breakpoints.md)
 Describes how, if the user sets a breakpoint, the IDE formulates the request and prompts the debug session to create the breakpoint.

 [Evaluate expressions](../../extensibility/debugger/evaluating-expressions.md)
 Explains how expressions are created and what happens when an expression is evaluated.

 [Visualize and view data](../../extensibility/debugger/visualizing-and-viewing-data.md)
 Explains how type visualizers and custom viewers are supported by the expression evaluator (EE).

## Related sections
 [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
 Describes the main debugging architectural concepts.

 [Debugger components](../../extensibility/debugger/debugger-components.md)
 Provides an overview of the Visual Studio debugging components, which include the DE, EE, and symbol handler (SH).

 [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
 Explains how the DE operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.

## See also
 [Get started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)
