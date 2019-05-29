---
title: "Getting Started with Debugger Extensibility | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "getting started, Debugging SDK"
  - "debugging [Debugging SDK], getting started"
  - "Debugging SDK, getting started"
ms.assetid: d6ce6f43-1409-4bf7-93cd-f3464ca23504
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Get started with debugger extensibility
The [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] provides the information that you need to create and customize debugger components used to debug programs from within the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] environment.

 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging has added improvements derived from the extensive usability testing performed on previous [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debuggers. You can use [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging to step through a multi-language application, or you can implement on-the-fly editing of variables while debugging applications and multi-language solutions.

 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging is executed out-of-process with the program being debugged and is therefore less intrusive in the process space of the application. Consequently, it is easier to write components that interact with the debugger without affecting your debugging program.

 To best use the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)], you should be familiar with the following items:

- The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE)

- The C++ programming language

- ATL COM

## In this section
 [Roadmap for extending the debugger](../../extensibility/debugger/roadmap-for-extending-the-debugger.md)
 Outlines the process of implementing debugging in your product, depending on your compiler and its output.

 [Debugger components](../../extensibility/debugger/debugger-components.md)
 Provides an overview of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).

 [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
 Describes the main debugging architectural concepts.

 [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
 Explains how the debug engine (DE) operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.

 [Debugging tasks](../../extensibility/debugger/debugging-tasks.md)
 Contains links to various debugging tasks, such as launching a program and evaluating expressions.