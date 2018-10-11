---
title: "IEnumDebugFrameInfo2::Skip | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugFrameInfo2::Skip"
helpviewer_keywords: 
  - "IEnumDebugFrameInfo2::Skip"
ms.assetid: 68cd3948-022a-41ad-bd9f-9ab776cf6248
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugFrameInfo2::Skip
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugFrameInfo2::Skip](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugframeinfo2-skip).  
  
Skips over the specified number of elements.  
  
## Syntax  
  
```cpp#  
HRESULT Skip(  
   ULONG celt  
);  
```  
  
```csharp  
int Skip(  
   uint celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] Number of elements to skip.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.  
  
## Remarks  
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.  
  
## See Also  
 [IEnumDebugFrameInfo2](../../../extensibility/debugger/reference/ienumdebugframeinfo2.md)

