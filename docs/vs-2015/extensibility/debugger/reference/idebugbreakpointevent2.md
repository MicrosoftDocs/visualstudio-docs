---
title: "IDebugBreakpointEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBreakpointEvent2"
helpviewer_keywords: 
  - "IDebugBreakpointEvent2 interface"
ms.assetid: 50b3a7a7-331b-42c8-922c-ff3522ebe1da
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# IDebugBreakpointEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The debug engine (DE) sends this interface to the session debug manager (SDM) when a program stops at a breakpoint.  
  
## Syntax  
  
```  
IDebugBreakpointEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface as part of its support for breakpoints. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to access the `IDebugEvent2` interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when at least one breakpoint is encountered in the program. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBreakpointEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumBreakpoints](../../../extensibility/debugger/reference/idebugbreakpointevent2-enumbreakpoints.md)|Creates an enumerator for all the breakpoints that fired at the current code location.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
