---
title: Debugger Components | Microsoft Docs
description: Learn about the elements that make up a debug session, which is managed by the Visual Studio debugger, implemented as a VSPackage.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Visual Studio], components
- components [Visual Studio SDK], debugging
- debugging [Debugging SDK], components
ms.assetid: 8b8ab77f-a134-495c-be42-3bc51aa62dfb
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Debugger components
The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger is implemented as a VSPackage and manages the entire debug session. The debug session comprises the following elements:

- **Debug Package:** The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger provides the same user interface no matter what is being debugged.

- **Session debug manager (SDM):** Provides a consistent programmatic interface to the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Debugger for the management of a variety of debug engines. It is implemented by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

- **Process debug manager (PDM):** Manages, for all running instances of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], a list of all programs that can be or are being debugged. It is implemented by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

- **Debug engine (DE):** Is responsible for monitoring a program being debugged, communicating the state of the running program to the SDM and the PDM, and interacting with the expression evaluator and symbol provider to provide real-time analysis of the state of a program's memory and variables. It is implemented by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] (for the languages it supports) and third-party vendors who want to support their own run time.

- **Expression evaluator (EE):** Provides support for dynamically evaluating variables and expressions supplied by the user when a program has been stopped at a particular point. It is implemented by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] (for the languages it supports) and third-party vendors who want to support their own languages.

- **Symbol provider (SP):** Also called a symbol handler, maps the debugging symbols of a program to a running instance of the program so that meaningful information can be provided (such as source-code-level debugging and expression evaluation). It is implemented by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] (for the Common Language Runtime [CLR] symbols and the Program DataBase [PDB] symbol file format) and by third-party vendors who have their own proprietary method of storing debugging information.

  The following diagram shows the relationship among these elements of the Visual Studio debugger.

  ![Debugging Components Overview](../../extensibility/debugger/media/dbugcompovrview.gif "DBugCompOvrview")

## In this section
 [Debug package](../../extensibility/debugger/debug-package.md)
 Discusses the debug package, which runs in the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] shell and handles all of the UI.

 [Process debug manager](../../extensibility/debugger/process-debug-manager.md)
 Provides an overview of the features of the PDM, which is the manager of the processes that can be debugged.

 [Session debug manager](../../extensibility/debugger/session-debug-manager.md)
 Defines the SDM, which provides a unified view of the debug session to the IDE. The SDM manages the DE.

 [Debug engine](../../extensibility/debugger/debug-engine.md)
 Documents the debugging services that the DE provides.

 [Operational modes](../../extensibility/debugger/operational-modes.md)
 Provides an overview of the three modes in which the IDE can operate: design mode, run mode, and break mode. Transition mechanisms are also discussed.

 [Expression evaluator](../../extensibility/debugger/expression-evaluator.md)
 Explains the purpose of the EE at run time.

 [Symbol provider](../../extensibility/debugger/symbol-provider.md)
 Discusses how, at implementation, the symbol provider evaluates variables and expressions.

 [Type visualizer and custom viewer](../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
 Discusses what a type visualizer and custom viewer are and what role the expression evaluator plays in supporting both.

## Related sections
 [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
 Describes the main debugging architectural concepts.

 [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)
 Explains how the DE operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.

 [Debug tasks](../../extensibility/debugger/debugging-tasks.md)
 Contains links to various debugging tasks, such as launching a program and evaluating expressions.

## See also
- [Get started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)
