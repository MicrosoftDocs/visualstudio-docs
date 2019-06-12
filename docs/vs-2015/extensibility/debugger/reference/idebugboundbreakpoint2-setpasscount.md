---
title: "IDebugBoundBreakpoint2::SetPassCount | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBoundBreakpoint2::SetPassCount"
helpviewer_keywords: 
  - "SetPassCount method"
  - "IDebugBoundBreakpoint2::SetPassCount method"
ms.assetid: b32c12f9-b34d-43bd-a1b9-61af6cf8e51b
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugBoundBreakpoint2::SetPassCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Sets or changes the pass count associated with this bound breakpoint.  
  
## Syntax  
  
```cpp#  
HRESULT SetPassCount(   
   BP_PASSCOUNT bpPassCount  
);  
```  
  
```csharp  
int SetPassCount(   
   BP_PASSCOUNT bpPassCount  
);  
```  
  
#### Parameters  
 `bpPassCount`  
 [in] The [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md) structure that specifies the pass count.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration).  
  
## Remarks  
 The pass count determines when the breakpoint is fired. The current pass or hit count can be obtained by calling the [GetHitCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-gethitcount.md) method.  
  
 Any pass count that was previously associated with this breakpoint is lost.  
  
## See Also  
 [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)   
 [GetHitCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-gethitcount.md)   
 [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md)   
 [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
