---
title: "IDebugPendingBreakpoint2::GetBreakpointRequest | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPendingBreakpoint2::GetBreakpointRequest"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::GetBreakpointRequest method"
  - "GetBreakpointRequest method"
ms.assetid: cb1e36aa-4302-455c-98fb-6638a1ef5c46
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugPendingBreakpoint2::GetBreakpointRequest
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the breakpoint request that was used to create this pending breakpoint.  
  
## Syntax  
  
```cpp#  
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
