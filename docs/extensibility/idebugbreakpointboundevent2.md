---
title: "IDebugBreakpointBoundEvent2"
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
  - "IDebugBreakpointBoundEvent2"
helpviewer_keywords: 
  - "IDebugBreakpointBoundEvent2"
ms.assetid: 24ba362e-5be1-481a-b071-e1ebd3cae6e8
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
# IDebugBreakpointBoundEvent2
This interface tells the session debug manager (SDM) that a pending breakpoint has been successfully bound to a loaded program.  
  
## Syntax  
  
```  
IDebugBreakpointBoundEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface as part of its support for breakpoints. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the `IDebugEvent2` interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when a pending breakpoint is successfully bound to the program being debugged. The event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBreakpointBoundEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPendingBreakpoint](../extensibility/idebugbreakpointboundevent2--getpendingbreakpoint.md)|Gets the pending breakpoint that is being bound.|  
|[EnumBoundBreakpoints](../extensibility/idebugbreakpointboundevent2--enumboundbreakpoints.md)|Creates an enumerator of breakpoints that were bound on this event.|  
  
## Remarks  
 Whenever a breakpoint is bound, an event is sent to the SDM. If the breakpoint cannot be bound, an [IDebugBreakpointErrorEvent2](../extensibility/idebugbreakpointerrorevent2.md) is sent; otherwise, an `IDebugBreakpointBoundEvent2` is sent.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [IDebugPendingBreakpoint2](../extensibility/idebugpendingbreakpoint2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)   
 [IDebugBreakpointErrorEvent2](../extensibility/idebugbreakpointerrorevent2.md)