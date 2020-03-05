---
title: "IDebugBreakpointRequest3 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBreakpointRequest3"
helpviewer_keywords: 
  - "IDebugBreakpointRequest3"
ms.assetid: 8a042beb-b319-48e3-b3c8-9c8336ab371b
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugBreakpointRequest3
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface represents the information necessary to create and bind any type of breakpoint. It is an extension of [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md).  
  
## Syntax  
  
```  
IDebugBreakpointRequest3 : IDebugBreakpointRequest2  
```  
  
## Notes for Implementers  
 The session debug manager (SDM) typically implements this interface.  
  
## Notes for Callers  
 The debug engine (DE) accesses this interface by calling [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on the IDebugBreakpointRequest2 interface received in a call to [CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md).  
  
## Methods in Vtable Order  
 In addition to the methods inherited from [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md), the `IDebugBreakpointRequest3` interface exposes the following method.  
  
|Method|Description|  
|------------|-----------------|  
|[GetRequestInfo2](../../../extensibility/debugger/reference/idebugbreakpointrequest3-getrequestinfo2.md)|Gets the breakpoint request information that describes this breakpoint request.|  
  
## Remarks  
 This interface is used to provide additional information to the DE through the [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structure. This additional information includes the DE's vendor ID (in the form of a GUID), the name of a tracepoint, and the name of a breakpoint constraint.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md)   
 [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)
