---
title: "IDebugPendingBreakpoint2"
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
  - "IDebugPendingBreakpoint2"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2 interface"
ms.assetid: d416b095-917e-475e-b796-ec0a03ffb8da
caps.latest.revision: 13
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
# IDebugPendingBreakpoint2
This interface represents a breakpoint that is ready to bind to a code location.  
  
## Syntax  
  
```  
IDebugPendingBreakpoint2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for breakpoints.  
  
## Notes for Callers  
 A call to [CreatePendingBreakpoint](../extensibility/idebugengine2--creatependingbreakpoint.md) creates a pending breakpoint from an [IDebugBreakpointRequest2](../extensibility/idebugbreakpointrequest2.md) interface. A call to [Bind](../extensibility/idebugpendingbreakpoint2--bind.md) creates an `IDebugBreakpoint2` interface that represents a bound breakpoint in the program.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPendingBreakpoint2`.  
  
|Method|Description|  
|------------|-----------------|  
|[CanBind](../extensibility/idebugpendingbreakpoint2--canbind.md)|Determines whether this pending breakpoint can bind to a code location.|  
|[Bind](../extensibility/idebugpendingbreakpoint2--bind.md)|Binds this pending breakpoint to one or more code locations.|  
|[GetState](../extensibility/idebugpendingbreakpoint2--getstate.md)|Gets the state of this pending breakpoint.|  
|[GetBreakpointRequest](../extensibility/idebugpendingbreakpoint2--getbreakpointrequest.md)|Gets the breakpoint request that was used to create this pending breakpoint.|  
|[Virtualize](../extensibility/idebugpendingbreakpoint2--virtualize.md)|Toggles the virtualized state of this pending breakpoint.|  
|[Enable](../extensibility/idebugpendingbreakpoint2--enable.md)|Toggles the enabled state of this pending breakpoint.|  
|[SetCondition](../extensibility/idebugpendingbreakpoint2--setcondition.md)|Sets or changes the condition associated with this pending breakpoint.|  
|[SetPassCount](../extensibility/idebugpendingbreakpoint2--setpasscount.md)|Sets or changes the pass count associated with this pending breakpoint.|  
|[EnumBoundBreakpoints](../extensibility/idebugpendingbreakpoint2--enumboundbreakpoints.md)|Enumerates all breakpoints bound from this pending breakpoint.|  
|[EnumErrorBreakpoints](../extensibility/idebugpendingbreakpoint2--enumerrorbreakpoints.md)|Enumerates all error breakpoints that resulted from this pending breakpoint.|  
|[Delete](../extensibility/idebugpendingbreakpoint2--delete.md)|Deletes this pending breakpoint and all breakpoints bound from it.|  
  
## Remarks  
 `IDebugPendingBreakpoint2` can be thought of as a provider of all the necessary information needed to bind a breakpoint to code that can be applied to one or many programs.  
  
 A pending breakpoint can potentially produce more than one bound breakpoint. For example, a breakpoint in a C++-style template could produce a bound breakpoint for each unique instance of that template.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [CreatePendingBreakpoint](../extensibility/idebugengine2--creatependingbreakpoint.md)   
 [GetPendingBreakpoint](../extensibility/idebugbreakpointboundevent2--getpendingbreakpoint.md)   
 [GetPendingBreakpoint](../extensibility/idebugboundbreakpoint2--getpendingbreakpoint.md)   
 [GetPendingBreakpoint](../extensibility/idebugerrorbreakpoint2--getpendingbreakpoint.md)