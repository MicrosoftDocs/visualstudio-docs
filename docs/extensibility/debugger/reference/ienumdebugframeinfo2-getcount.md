---
title: "IEnumDebugFrameInfo2::GetCount | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugFrameInfo2::GetCount"
helpviewer_keywords: 
  - "IEnumDebugFrameInfo2::GetCount"
ms.assetid: d02a08e3-f34f-461e-8195-5157e154c481
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IEnumDebugFrameInfo2::GetCount
Returns the number of elements in the enumeration.  
  
## Syntax  
  
```cpp  
HRESULT GetCount(  
   ULONG* pcelt  
);  
```  
  
```csharp  
int GetCount(  
   out uint pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of elements in the enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is not part of the customary COM enumeration interface which specifies that only the `Next`, `Clone`, `Skip`, and `Reset` methods need to be implemented.  
  
## See Also  
 [IEnumDebugFrameInfo2](../../../extensibility/debugger/reference/ienumdebugframeinfo2.md)