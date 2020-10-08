---
title: "Notifying the Port | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "ports, notification"
ms.assetid: f9fce48e-7d4e-4627-a0fb-77b75428146a
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# Notifying the Port
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

After launching a program, the port must be notified, as follows:  
  
1. When a port receives a new program node, it sends a program creation event back to the debug session. The event carries with it an interface that represents the program.  
  
2. The debug session queries the program for the identifier of a debug engine (DE) that can attach to.  
  
3. The debug session checks to see if the DE is on the list of allowable DEs for that program. The debug session gets this list from the solution's active program settings, originally passed to it by the debug package.  
  
    The DE must be on the allowable list, or else the DE will not be attached to the program.  
  
   Programmatically, when a port first receives a new program node, it creates an [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) interface to represent the program.  
  
> [!NOTE]
> This should not be confused with the `IDebugProgram2` interface created later by the debug engine (DE).  
  
 The port sends an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) program creation event back to the session debug manager (SDM) by means of a COM `IConnectionPoint` interface.  
  
> [!NOTE]
> This should not be confused with the `IDebugProgramCreateEvent2` interface, which is sent later by the DE.  
  
 Along with the event interface itself, the port sends the [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md), [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md), and [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) interfaces, which represent the port, process, and program, respectively. The SDM calls [IDebugProgram2::GetEngineInfo](../../extensibility/debugger/reference/idebugprogram2-getengineinfo.md) to get the GUID of the DE that can debug the program. The GUID was originally obtained from the [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) interface.  
  
 The SDM checks to see if the DE is on the list of allowable DEs. The SDM gets this list from the solution's active program settings, originally passed to it by the debug package. The DE must be on the allowable list, or else it will not be attached to the program.  
  
 Once the identity of the DE is known, the SDM is ready to attach it to the program.  
  
## See Also  
 [Launching a Program](../../extensibility/debugger/launching-a-program.md)   
 [Attaching After a Launch](../../extensibility/debugger/attaching-after-a-launch.md)   
 [Debugging Tasks](../../extensibility/debugger/debugging-tasks.md)
