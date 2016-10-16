---
title: "IDebugBreakpointUnboundEvent2"
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
  - "IDebugBreakpointUnboundEvent2"
helpviewer_keywords: 
  - "IDebugBreakpointUnboundEvent2"
ms.assetid: 6b1e1863-0c64-4d85-8ab9-aface522fdea
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
# IDebugBreakpointUnboundEvent2
This interface tells the session debug manager (SDM) that a bound breakpoint has been unbound from a loaded program.  
  
## Syntax  
  
```  
IDebugBreakpointUnboundEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for breakpoints. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the `IDebugEvent2` interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when a bound breakpoint has been unbound. The event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBreakpointUnboundEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetBreakpoint](../extensibility/idebugbreakpointunboundevent2--getbreakpoint.md)|Gets the breakpoint that became unbound.|  
|[GetReason](../extensibility/idebugbreakpointunboundevent2--getreason.md)|Gets the reason the breakpoint was unbound.|  
  
## Remarks  
 When a debug engine DLL or class unloads, all breakpoints that were bound to code in that module must be unbound from the program being debugged. An `IDebugBreakpointUnboundEvent2` is sent for each unbound breakpoint.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [IDebugBoundBreakpoint2](../extensibility/idebugboundbreakpoint2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)