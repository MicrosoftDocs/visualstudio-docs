---
title: "IDebugEvent2 | Microsoft Docs"
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
  - "IDebugEvent2"
helpviewer_keywords: 
  - "IDebugEvent2 interface"
ms.assetid: de3d714d-96fb-4e12-b66b-a75391472153
caps.latest.revision: 11
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
# IDebugEvent2
This interface is used to communicate both critical debug information, such as stopping at a breakpoint, and non-critical information, such as a debugging message.  
  
## Syntax  
  
```  
IDebugEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) and custom port supplier implement this interface on the same object as all other event interfaces.  
  
## Notes for Callers  
 Using the interface ID (IID) argument given to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) or [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md), the session debug manager (SDM) calls [QueryInterface](/visual-cpp/atl/queryinterface) on the `IDebugEvent2` interface to obtain the appropriate event interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetAttributes](../../../extensibility/debugger/reference/idebugevent2-getattributes.md)|Gets the attributes for this debug event.|  
  
## Remarks  
 The more specific event interfaces, such as [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md), do not derive from the IDebugEvent2 interface but are instead implemented as a separate interface on the same object as `IDebugEvent2`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)   
 [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)