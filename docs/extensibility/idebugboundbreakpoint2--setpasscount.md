---
title: "IDebugBoundBreakpoint2::SetPassCount"
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
  - "IDebugBoundBreakpoint2::SetPassCount"
helpviewer_keywords: 
  - "SetPassCount method"
  - "IDebugBoundBreakpoint2::SetPassCount method"
ms.assetid: b32c12f9-b34d-43bd-a1b9-61af6cf8e51b
caps.latest.revision: 10
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
# IDebugBoundBreakpoint2::SetPassCount
Sets or changes the pass count associated with this bound breakpoint.  
  
## Syntax  
  
```cpp#  
HRESULT SetPassCount(   
   BP_PASSCOUNT bpPassCount  
);  
```  
  
```c#  
int SetPassCount(   
   BP_PASSCOUNT bpPassCount  
);  
```  
  
#### Parameters  
 `bpPassCount`  
 [in] The [BP_PASSCOUNT](../extensibility/bp_passcount.md) structure that specifies the pass count.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../extensibility/bp_state.md) enumeration).  
  
## Remarks  
 The pass count determines when the breakpoint is fired. The current pass or hit count can be obtained by calling the [GetHitCount](../extensibility/idebugboundbreakpoint2--gethitcount.md) method.  
  
 Any pass count that was previously associated with this breakpoint is lost.  
  
## See Also  
 [IDebugBoundBreakpoint2](../extensibility/idebugboundbreakpoint2.md)   
 [GetHitCount](../extensibility/idebugboundbreakpoint2--gethitcount.md)   
 [BP_PASSCOUNT](../extensibility/bp_passcount.md)   
 [BP_STATE](../extensibility/bp_state.md)