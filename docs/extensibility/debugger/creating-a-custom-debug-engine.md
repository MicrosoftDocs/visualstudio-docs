---
title: "Creating a Custom Debug Engine | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debug engines, implementing"
  - "debug engines, custom"
  - "debugging [Debugging SDK], custom debug engines"
ms.assetid: 52794238-6fae-451c-bf1c-99f344c6f173
caps.latest.revision: 15
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Creating a Custom Debug Engine
A debug engine (DE) is a component that allows debugging of particular run-time architectures. There is typically only one DE implementation per run-time environment.  
  
> [!NOTE]
>  While there are separate DE implementations for Transact-SQL and JScript, VBScript and JScript share a single DE.  
  
 A DE works with the interpreter or operation system to provide such debugging services as execution control, breakpoints, and expression evaluation. These services are implemented through the DE interfaces and can cause the debugger to transition between different operational modes. For more information, see [Operational Modes](../../extensibility/debugger/operational-modes.md).  
  
 Creating a DE consists of the following steps:  
  
1.  Registering a DE with Visual Studio  
  
2.  Enabling a program to be debugged  
  
3.  Execution control and state evaluation  
  
4.  Sending events  
  
5.  Termination and detaching  
  
## In This Section  
 [Registering a Custom Debug Engine](../../extensibility/debugger/registering-a-custom-debug-engine.md)  
 Explains the steps needed to register a debug engine with Visual Studio so that it can be used.  
  
 [Enabling a Program to Be Debugged](../../extensibility/debugger/enabling-a-program-to-be-debugged.md)  
 Explains that before your DE can debug a program, you must first launch the DE or attach it to an existing program.  
  
 [Execution Control and State Evaluation](../../extensibility/debugger/execution-control-and-state-evaluation.md)  
 Discusses why debugging an application requires implementing execution control features.  
  
 [Sending Events](../../extensibility/debugger/sending-events.md)  
 Describes communication between the debugger and the DE as an event model based on DCOM.  
  
 [Termination and Detaching](../../extensibility/debugger/termination-and-detaching.md)  
 Explains how to achieve normal termination, which means that there are no breakpoints, exceptions, run-time errors, or infinite loops in the application to be debugged.  
  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)  
 Documents the calling order of the events occurring in a debugging session.  
  
 [How To: Debug a Custom Debug Engine](../../extensibility/debugger/how-to-debug-a-custom-debug-engine.md)  
 Explains how to debug a custom DE.  
  
## See Also  
 [Visual Studio Debugger Extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)