---
title: "IDebugProcessEx2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProcessEx2"
helpviewer_keywords: 
  - "IDebugProcessEx2 interface"
ms.assetid: 44e309ba-1d6f-499b-aa7e-9b34858a6d57
caps.latest.revision: 21
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
# IDebugProcessEx2
This interface lets the session debug manager (SDM) notify a process that it is attaching to or detaching from the process.  
  
## Syntax  
  
```  
IDebugProcessEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface on the same object as the [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) interface in order to:  
  
-   Support tracking of sessions connected to a process  
  
-   Support auto-attach across multiple debug engines  
  
 The custom port supplier can implement this interface if it chooses.  
  
## Notes for Callers  
  
-   The SDM calls [QueryInterface](/visual-cpp/atl/queryinterface) on an `IDebugProcess2` interface to obtain this interface.  
  
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