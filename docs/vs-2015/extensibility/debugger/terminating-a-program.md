---
title: "Terminating a Program | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "programs, termination events"
  - "debugging [Debugging SDK], terminating a program"
ms.assetid: eedda0a3-5e05-44fe-841d-a2f4866ac72d
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# Terminating a Program
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following is a description of the termination of a single program with one thread.  
  
## Termination Process  
  
1. The DE sends an [IDebugThreadDestroyEvent2](../../extensibility/debugger/reference/idebugthreaddestroyevent2.md) with a valid [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md).  
  
2. The DE sends an [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) with a valid [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md).  
  
   The IDE goes into design mode. The debug engine or run-time environment calls [IDebugPortNotify2::RemoveProgramNode](../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md) to remove the program from the port.  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)
