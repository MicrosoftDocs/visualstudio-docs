---
title: "IDebugEngine2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugEngine2"
helpviewer_keywords: 
  - "IDebugEngine2 interface"
ms.assetid: 1f0e9ac0-6dfb-461a-976c-888d82144cdb
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
# IDebugEngine2
This interface represents a debug engine (DE). It is used to manage various aspects of a debugging session, from creating breakpoints to setting and clearing exceptions.  
  
## Syntax  
  
```  
IDebugEngine2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by a custom DE to manage debugging of programs. This interface must be implemented by the DE.  
  
## Notes for Callers  
 This interface is called by the session debug manager (SDM) to manage the debugging session, including managing exceptions, creating breakpoints, and responding to synchronous events sent by the DE.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugEngine2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumPrograms](../extensibility/idebugengine2--enumprograms.md)|Creates an enumerator for all the programs being debugged by a DE.|  
|[Attach](../extensibility/idebugengine2--attach.md)|Attaches a DE to a program.|  
|[CreatePendingBreakpoint](../extensibility/idebugengine2--creatependingbreakpoint.md)|Creates a pending breakpoint in the DE.|  
|[SetException](../extensibility/idebugengine2--setexception.md)|Specifies how the DE should handle a given exception.|  
|[RemoveSetException](../extensibility/idebugengine2--removesetexception.md)|Removes the specified exception so it is no longer handled by the debug engine.|  
|[RemoveAllSetExceptions](../extensibility/idebugengine2--removeallsetexceptions.md)|Removes the list of exceptions the IDE has set for a particular run-time architecture or language.|  
|[GetEngineID](../extensibility/idebugengine2--getengineid.md)|Gets the GUID of the DE.|  
|[DestroyProgram](../extensibility/idebugengine2--destroyprogram.md)|Informs a DE that the program specified has been atypically terminated and that the DE should clean up all references to the program and send a program destroy event.|  
|[ContinueFromSynchronousEvent](../extensibility/idebugengine2--continuefromsynchronousevent.md)|Called by the SDM to indicate that a synchronous debug event, previously sent by the DE to the SDM, was received and processed.|  
|[SetLocale](../extensibility/idebugengine2--setlocale.md)|Sets the locale of the DE.|  
|[SetRegistryRoot](../extensibility/idebugengine2--setregistryroot.md)|Sets the registry root currently in use by the DE.|  
|[SetMetric](../extensibility/idebugengine2--setmetric.md)|Sets a metric.|  
|[CauseBreak](../extensibility/idebugengine2--causebreak.md)|Requests that all programs being debugged by this DE stop execution the next time one of their threads attempts to run.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Event](../extensibility/idebugeventcallback2--event.md)   
 [GetEngine](../extensibility/idebugenginecreateevent2--getengine.md)