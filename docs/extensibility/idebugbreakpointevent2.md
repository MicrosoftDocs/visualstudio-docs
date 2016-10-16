---
title: "IDebugBreakpointEvent2"
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
  - "IDebugBreakpointEvent2"
helpviewer_keywords: 
  - "IDebugBreakpointEvent2 interface"
ms.assetid: 50b3a7a7-331b-42c8-922c-ff3522ebe1da
caps.latest.revision: 14
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
# IDebugBreakpointEvent2
The debug engine (DE) sends this interface to the session debug manager (SDM) when a program stops at a breakpoint.  
  
## Syntax  
  
```  
IDebugBreakpointEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface as part of its support for breakpoints. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the `IDebugEvent2` interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when at least one breakpoint is encountered in the program. The event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBreakpointEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumBreakpoints](../extensibility/idebugbreakpointevent2--enumbreakpoints.md)|Creates an enumerator for all the breakpoints that fired at the current code location.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)