---
title: "IDebugPendingBreakpoint2::SetPassCount | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugPendingBreakpoint2::SetPassCount"
helpviewer_keywords: 
  - "SetPassCount method"
  - "IDebugPendingBreakpoint2::SetPassCount method"
ms.assetid: 08ddd328-57eb-42e0-baa9-8424dcd1bf04
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
# IDebugPendingBreakpoint2::SetPassCount
Sets or changes the pass count associated with the pending breakpoint.  
  
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
 [in] A [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md) structure that contains the pass count.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.  
  
## Remarks  
 Any pass count that was previously associated with the pending breakpoint is lost. All breakpoints bound from this pending breakpoint are called to set their pass count to the `bpPassCount` parameter.  
  
## See Also  
 [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)   
 [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md)