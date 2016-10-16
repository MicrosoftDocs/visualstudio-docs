---
title: "Terminating a Program"
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
  - "programs, termination events"
  - "debugging [Debugging SDK], terminating a program"
ms.assetid: eedda0a3-5e05-44fe-841d-a2f4866ac72d
caps.latest.revision: 7
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
# Terminating a Program
The following is a description of the termination of a single program with one thread.  
  
## Termination Process  
  
1.  The DE sends an [IDebugThreadDestroyEvent2](../extensibility/idebugthreaddestroyevent2.md) with a valid [IDebugThread2](../extensibility/idebugthread2.md).  
  
2.  The DE sends an [IDebugProgramDestroyEvent2](../extensibility/idebugprogramdestroyevent2.md) with a valid [IDebugProgram2](../extensibility/idebugprogram2.md).  
  
 The IDE goes into design mode. The debug engine or run-time environment calls [IDebugPortNotify2::RemoveProgramNode](../extensibility/idebugportnotify2--removeprogramnode.md) to remove the program from the port.  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)