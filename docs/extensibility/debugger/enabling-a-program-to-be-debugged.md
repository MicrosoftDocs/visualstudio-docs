---
title: "Enabling a Program to Be Debugged | Microsoft Docs"
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
  - "debugging [Debugging SDK], enabling for programs"
ms.assetid: 61d24820-0cd9-48b6-8674-6813f7493237
caps.latest.revision: 8
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
# Enabling a Program to Be Debugged
Before your debug engine (DE) can debug a program, you must first launch the DE or attach it to an existing program.  
  
## In This Section  
 [Getting a Port](../../extensibility/debugger/getting-a-port.md)  
 Discusses how to obtain a port as the first step to enabling a program to be debugged.  
  
 [Registering the Program](../../extensibility/debugger/registering-the-program.md)  
 Explains the next step in enabling a program to be debugged: registering it with the port. Once registered, the program can be debugged either by the process of attaching or just-in-time (JIT) debugging.  
  
 [Attaching to the Program](../../extensibility/debugger/attaching-to-the-program.md)  
 Explains the next step:attaching the debugger to the program.  
  
 [Launch-based Attaching](../../extensibility/debugger/launch-based-attachment.md)  
 Describes launch-based attachment to a program, which is automatic upon launch by the SDM.  
  
 [Sending the Required Events](../../extensibility/debugger/sending-the-required-events.md)  
 Steps you through the required events when creating a debug engine (DE) and attaching it to a program.  
  
## Related Sections  
 [Creating a Custom Debug Engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)  
 Defines a debug engine (DE), and describes services implemented through the DE interfaces and how they can cause the debugger to transition between different operational modes.