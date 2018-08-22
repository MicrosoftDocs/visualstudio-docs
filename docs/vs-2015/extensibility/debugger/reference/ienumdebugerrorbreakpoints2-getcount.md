---
title: "IEnumDebugErrorBreakpoints2::GetCount | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugErrorBreakpoints2::GetCount"
helpviewer_keywords: 
  - "IEnumDebugErrorBreakpoints2::GetCount"
ms.assetid: 56f7bb70-d55b-471c-8c65-09a9e7f4938e
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugErrorBreakpoints2::GetCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugErrorBreakpoints2::GetCount](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugerrorbreakpoints2-getcount).  
  
Returns the number of elements in the enumeration.  
  
## Syntax  
  
```cpp#  
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
 [IEnumDebugErrorBreakpoints2](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md)

