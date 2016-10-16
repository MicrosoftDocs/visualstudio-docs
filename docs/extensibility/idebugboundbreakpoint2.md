---
title: "IDebugBoundBreakpoint2"
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
  - "IDebugBoundBreakpoint2"
helpviewer_keywords: 
  - "IDebugBoundBreakpoint2 interface"
ms.assetid: df33c52e-ded2-48a0-951d-1f36c8fc922e
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
# IDebugBoundBreakpoint2
This interface represents a breakpoint that is bound to a code location.  
  
## Syntax  
  
```  
IDebugBoundBreakpoint2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for breakpoints.  
  
## Notes for Callers  
 A call to [Bind](../extensibility/idebugpendingbreakpoint2--bind.md) creates this interface. Calls to [GetBreakpoint](../extensibility/idebugbreakpointunboundevent2--getbreakpoint.md) and [Next](../extensibility/ienumdebugboundbreakpoints2--next.md) can also obtain This interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBoundBreakpoint2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPendingBreakpoint](../extensibility/idebugboundbreakpoint2--getpendingbreakpoint.md)|Gets the pending breakpoint from which the specified bound breakpoint was created.|  
|[GetState](../extensibility/idebugboundbreakpoint2--getstate.md)|Gets the state of this bound breakpoint.|  
|[GetHitCount](../extensibility/idebugboundbreakpoint2--gethitcount.md)|Gets the current hit count for this bound breakpoint.|  
|[GetBreakpointResolution](../extensibility/idebugboundbreakpoint2--getbreakpointresolution.md)|Gets the breakpoint resolution that describes this breakpoint.|  
|[Enable](../extensibility/idebugboundbreakpoint2--enable.md)|Enables or disables the breakpoint.|  
|[SetHitCount](../extensibility/idebugboundbreakpoint2--sethitcount.md)|Sets the hit count for this bound breakpoint.|  
|[SetCondition](../extensibility/idebugboundbreakpoint2--setcondition.md)|Sets or changes the condition associated with this bound breakpoint.|  
|[SetPassCount](../extensibility/idebugboundbreakpoint2--setpasscount.md)|Sets or change the pass count associated with this bound breakpoint.|  
|[Delete](../extensibility/idebugboundbreakpoint2--delete.md)|Deletes the breakpoint.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [GetBreakpoint](../extensibility/idebugbreakpointunboundevent2--getbreakpoint.md)   
 [Next](../extensibility/ienumdebugboundbreakpoints2--next.md)   
 [Bind](../extensibility/idebugpendingbreakpoint2--bind.md)