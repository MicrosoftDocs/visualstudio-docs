---
title: "IEnumDebugReferenceInfo2::Clone | Microsoft Docs"
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
  - "IEnumDebugReferenceInfo2::Clone"
helpviewer_keywords: 
  - "IEnumDebugReferenceInfo2::Clone"
ms.assetid: 49c5a301-a33a-428f-b83b-e734c71af4ef
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugReferenceInfo2::Clone
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp#  
HRESULT Clone(  
   IEnumDebugReferenceInfo2** ppEnum  
);  
```  
  
```csharp  
int Clone(  
   out IEnumDebugReferenceInfo2 ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugReferenceInfo2](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2.md)

