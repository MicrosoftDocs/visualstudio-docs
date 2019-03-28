---
title: "IDebugCanStopEvent2::CanStop | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCanStopEvent2::CanStop"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::CanStop"
ms.assetid: 7d61adbe-6b3d-41f3-86a1-45d9cc01a7f8
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugCanStopEvent2::CanStop
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Notifies the debug engine (DE) whether or not to stop at the current code location or just continue execution.  
  
## Syntax  
  
```cpp#  
HRESULT CanStop (   
   BOOL fCanStop  
);  
```  
  
```csharp  
int CanStop (   
   int fCanStop  
);  
```  
  
#### Parameters  
 `fCanStop`  
 [in] Non-zero (`TRUE`) if the DE should stop at the current code location; otherwise, zero (`FALSE`).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The receiver of this event typically calls the [GetReason](../../../extensibility/debugger/reference/idebugcanstopevent2-getreason.md) method to determine the reason the DE wants to stop, and then calls the `IDebugCanStopEvent2::CanStop` method with the appropriate response.  
  
 If the DE stops, it sends an event that describes the reason for stopping. There are typically two events that are sent, a user or signal break represented by the [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) interface, and a breakpoint event represented by the [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md) interface.  
  
## See Also  
 [IDebugCanStopEvent2](../../../extensibility/debugger/reference/idebugcanstopevent2.md)   
 [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md)   
 [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md)   
 [GetReason](../../../extensibility/debugger/reference/idebugcanstopevent2-getreason.md)
