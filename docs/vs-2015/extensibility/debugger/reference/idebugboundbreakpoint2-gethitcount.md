---
title: "IDebugBoundBreakpoint2::GetHitCount | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBoundBreakpoint2::GetHitCount"
helpviewer_keywords: 
  - "GetHitCount method"
  - "IDebugBoundBreakpoint2::GetHitCount method"
ms.assetid: 23481f37-047c-41d2-8286-4da1f4084961
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugBoundBreakpoint2::GetHitCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the current hit count for this bound breakpoint.  
  
## Syntax  
  
```cpp#  
HRESULT GetHitCount(   
   DWORD* pdwHitCount  
);  
```  
  
```csharp  
int GetHitCount(   
   out uint pdwHitCount  
);  
```  
  
#### Parameters  
 `pdwHitCount`  
 [out] Returns the hit count.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration).  
  
## Remarks  
 The hit count is the number of times this breakpoint has fired during the current run of the session.  
  
## See Also  
 [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)   
 [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
