---
title: "IDebugBoundBreakpoint2::SetHitCount"
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
  - "IDebugBoundBreakpoint2::SetHitCount"
helpviewer_keywords: 
  - "SetHitCount method"
  - "IDebugBoundBreakpoint2::SetHitCount method"
ms.assetid: 8145d875-26b1-4049-a2a2-e7d3d7f4735f
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
# IDebugBoundBreakpoint2::SetHitCount
Sets the hit count for the bound breakpoint.  
  
## Syntax  
  
```cpp#  
HRESULT SetHitCount(   
   DWORD dwHitCount  
);  
```  
  
```c#  
int SetHitCount(   
   uint dwHitCount  
);  
```  
  
#### Parameters  
 `dwHitCount`  
 [in] The hit count to set.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../extensibility/bp_state.md) enumeration).  
  
## Remarks  
 The hit count is the number of times this breakpoint has fired during the current run of the session.  
  
 This method is typically called by the debug engine to update the current hit count on this breakpoint.  
  
## See Also  
 [IDebugBoundBreakpoint2](../extensibility/idebugboundbreakpoint2.md)   
 [BP_STATE](../extensibility/bp_state.md)