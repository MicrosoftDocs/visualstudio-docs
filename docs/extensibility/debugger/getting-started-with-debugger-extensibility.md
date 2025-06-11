---
title: Getting Started with Debugger Extensibility
description: Get started creating and customizing debugger components used to debug programs from within the Visual Studio environment.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- getting started, Debugging SDK
- debugging [Debugging SDK], getting started
- Debugging SDK, getting started
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Get started with debugger extensibility

The Visual Studio SDK provides the information that you need to create and customize debugger components used to debug programs from within the Visual Studio environment.

 Visual Studio debugging has added improvements derived from the extensive usability testing performed on previous Visual Studio debuggers. You can use Visual Studio debugging to step through a multi-language application, or you can implement on-the-fly editing of variables while debugging applications and multi-language solutions.

 Visual Studio debugging is executed out-of-process with the program being debugged and is therefore less intrusive in the process space of the application. Consequently, it is easier to write components that interact with the debugger without affecting your debugging program.

 To best use the Visual Studio SDK, you should be familiar with the following items:

- The Visual Studio integrated development environment (IDE)

- The C++ programming language

- ATL COM

## In this section

[Roadmap for extending the debugger](../../extensibility/debugger/roadmap-for-extending-the-debugger.md) outlines the process of implementing debugging in your product, depending on your compiler and its output.

 [Debugger components](../../extensibility/debugger/debugger-components.md) provides an overview of the Visual Studio debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).

 [Debugger concepts](../../extensibility/debugger/debugger-concepts.md) describes the main debugging architectural concepts.

 [Debugger contexts](../../extensibility/debugger/debugger-contexts.md) explains how the debug engine (DE) operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.

 [Debugging tasks](../../extensibility/debugger/debugging-tasks.md) contains links to various debugging tasks, such as launching a program and evaluating expressions.
