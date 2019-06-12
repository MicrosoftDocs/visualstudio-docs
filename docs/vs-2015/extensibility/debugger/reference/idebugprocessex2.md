---
title: "IDebugProcessEx2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcessEx2"
helpviewer_keywords: 
  - "IDebugProcessEx2 interface"
ms.assetid: 44e309ba-1d6f-499b-aa7e-9b34858a6d57
caps.latest.revision: 22
ms.author: gregvanl
manager: jillfra
---
# IDebugProcessEx2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface lets the session debug manager (SDM) notify a process that it is attaching to or detaching from the process.  
  
## Syntax  
  
```  
IDebugProcessEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface on the same object as the [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) interface in order to:  
  
- Support tracking of sessions connected to a process  
  
- Support auto-attach across multiple debug engines  
  
  The custom port supplier can implement this interface if it chooses.  
  
## Notes for Callers  
  
- The SDM calls [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on an `IDebugProcess2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProcessEx2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Attach](../../../extensibility/debugger/reference/idebugprocessex2-attach.md)|Informs the process that a session is now debugging the process.|  
|[Detach](../../../extensibility/debugger/reference/idebugprocessex2-detach.md)|Informs the process that a session is no longer debugging the process.|  
|[AddImplicitProgramNodes](../../../extensibility/debugger/reference/idebugprocessex2-addimplicitprogramnodes.md)|Adds program nodes for a list of debug engines.|  
  
## Remarks  
 This interface is private between the SDM and the process.  
  
## Requirements  
 Header: Portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
