---
title: "IDebugPendingBreakpoint2::GetBreakpointRequest | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugPendingBreakpoint2::GetBreakpointRequest"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::GetBreakpointRequest method"
  - "GetBreakpointRequest method"
ms.assetid: cb1e36aa-4302-455c-98fb-6638a1ef5c46
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugPendingBreakpoint2::GetBreakpointRequest
Gets the breakpoint request that was used to create this pending breakpoint.  
  
## Syntax  
  
```cpp  
HRESULT GetBreakpointRequest(   
   IDebugBreakpointRequest2** ppBPRequest  
);  
```  
  
```csharp  
int GetBreakpointRequest(   
   out IDebugBreakpointRequest2 ppBPRequest  
);  
```  
  
#### Parameters  
 `ppBPRequest`  
 [out] Returns an [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md) object representing the breakpoint request that was used to create this pending breakpoint.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.  
  
## See Also  
 [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)   
 [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md)