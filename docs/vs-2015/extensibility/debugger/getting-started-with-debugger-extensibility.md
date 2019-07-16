---
title: "Getting Started with Debugger Extensibility | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "getting started, Debugging SDK"
  - "debugging [Debugging SDK], getting started"
  - "Debugging SDK, getting started"
ms.assetid: d6ce6f43-1409-4bf7-93cd-f3464ca23504
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Getting Started with Debugger Extensibility
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The [!INCLUDE[vsipsdk](../../includes/vsipsdk-md.md)] provides the information that you must have to create and customize debugger components used to debug programs from within the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] environment.  
  
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] debugging has added improvements derived from the extensive usability testing performed on previous [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] debuggers. You can use [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] debugging to step through a multi-language application, or you can implement on-the-fly editing of variables while debugging applications and multi-language solutions.  
  
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] debugging is executed out-of-process with the program being debugged and is therefore less intrusive in the process space of the application. Consequently, it is easier to write components that interact with the debugger without affecting your debugging program.  
  
 To best use the [!INCLUDE[vsipsdk](../../includes/vsipsdk-md.md)], you should be familiar with the following:  
  
- The [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] integrated development environment (IDE)  
  
- The C++ programming language  
  
- ATL COM  
  
## In This Section  
 [Roadmap for Extending the Debugger](../../extensibility/debugger/roadmap-for-extending-the-debugger.md)  
 Outlines the process of implementing debugging in your product, depending on your compiler and its output.  
  
 [Debugger Components](../../extensibility/debugger/debugger-components.md)  
 Provides an overview of the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).  
  
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)  
 Describes the main debugging architectural concepts.  
  
 [Debugger Contexts](../../extensibility/debugger/debugger-contexts.md)  
 Explains how the debug engine (DE) operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position or evaluation relevant to it.  
  
 [Debugging Tasks](../../extensibility/debugger/debugging-tasks.md)  
 Contains links to various debugging tasks, such as launching a program and evaluating expressions.
