---
title: "IDebugEngine3 | Microsoft Docs"
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
  - "IDebugEngine3"
helpviewer_keywords: 
  - "IDebugEngine3 interface"
ms.assetid: 8bdf4bb7-3b5d-4991-8981-772d4f6bb656
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
# IDebugEngine3
Represents a single debug engine (DE) that controls the debugging of one or more modules.  
  
## Syntax  
  
```  
IDebugEngine3 : IDebugEngine2  
```  
  
## Notes for Implementers  
 This interface is implemented by a custom DE (if it supports symbols) to enable the JustMyCode state. This interface must be implemented by the DE if it supports symbols and JustMyCode.  
  
## Notes for Callers  
 This interface is called by the session debug manager (SDM) to pass on user options for locations from which to load symbols. It is also called to set the GUID of the engine when it is instantiated (this GUID is based on the metrics from the time of engine registration). The SDM also calls this interface to set the JustMyCode state and to set all exceptions known by the debugger to a specified state.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md), the `IDebugEngine3` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md)|Sets the path or paths that the DE will use to search for debugging symbols.|  
|[LoadSymbols](../../../extensibility/debugger/reference/idebugengine3-loadsymbols.md)|Loads the symbols for all modules that have not yet had their symbols loaded.|  
|[SetJustMyCodeState](../../../extensibility/debugger/reference/idebugengine3-setjustmycodestate.md)|Tells the DE about the JustMyCode information.|  
|[SetEngineGuid](../../../extensibility/debugger/reference/idebugengine3-setengineguid.md)|Sets the DE GUID from the metrics.|  
|[SetAllExceptions](../../../extensibility/debugger/reference/idebugengine3-setallexceptions.md)|Set all exceptions currently outstanding to a specified state.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)