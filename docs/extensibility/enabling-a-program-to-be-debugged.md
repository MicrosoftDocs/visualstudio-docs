---
title: "Enabling a Program to Be Debugged"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
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
 [Getting a Port](../extensibility/getting-a-port.md)  
 Discusses how to obtain a port as the first step to enabling a program to be debugged.  
  
 [Registering the Program](../extensibility/registering-the-program.md)  
 Explains the next step in enabling a program to be debugged: registering it with the port. Once registered, the program can be debugged either by the process of attaching or just-in-time (JIT) debugging.  
  
 [Attaching to the Program](../extensibility/attaching-to-the-program.md)  
 Explains the next step:attaching the debugger to the program.  
  
 [Launch-based Attaching](../extensibility/launch-based-attachment.md)  
 Describes launch-based attachment to a program, which is automatic upon launch by the SDM.  
  
 [Sending the Required Events](../extensibility/sending-the-required-events.md)  
 Steps you through the required events when creating a debug engine (DE) and attaching it to a program.  
  
## Related Sections  
 [Creating a Custom Debug Engine](../extensibility/creating-a-custom-debug-engine.md)  
 Defines a debug engine (DE), and describes services implemented through the DE interfaces and how they can cause the debugger to transition between different operational modes.