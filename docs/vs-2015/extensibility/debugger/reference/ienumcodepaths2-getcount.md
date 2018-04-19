---
title: "IEnumCodePaths2::GetCount | Microsoft Docs"
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
  - "IEnumCodePaths2::GetCount"
helpviewer_keywords: 
  - "IEnumCodePaths2::GetCount"
ms.assetid: 988c5092-fcc5-43a1-a94c-c261edd56ebf
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumCodePaths2::GetCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumCodePaths2::GetCount](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumcodepaths2-getcount).  
  
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
 [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md)

