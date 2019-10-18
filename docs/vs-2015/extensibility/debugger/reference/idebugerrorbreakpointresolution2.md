---
title: "IDebugErrorBreakpointResolution2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugErrorBreakpointResolution2"
helpviewer_keywords: 
  - "IDebugErrorBreakpointResolution2"
ms.assetid: b1234216-0ac8-461d-b2a7-54f60f8f3262
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugErrorBreakpointResolution2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface represents the resolution of a breakpoint error.  
  
## Syntax  
  
```  
IDebugErrorBreakpointResolution2 : IUnknown  
```  
  
## Notes for Implementers  
 A debug engine implements this interface as part of its support for breakpoints. This interface is used to report where a breakpoint failed to bind.  
  
## Notes for Callers  
 A call to [GetBreakpointResolution](../../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md) returns this interface to provide information about where the breakpoint failed to bind. The [GetErrorBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md) method obtains the [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugErrorBreakpointResolution2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetBreakpointType](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getbreakpointtype.md)|Gets the breakpoint type.|  
|[GetResolutionInfo](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md)|Gets the breakpoint resolution information.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See also  
 [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)   
 [GetBreakpointResolution](../../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md)   
 [GetErrorBreakpoint](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md)
