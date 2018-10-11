---
title: "IDebugArrayField::GetNumberOfElements | Microsoft Docs"
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
  - "IDebugArrayField::GetNumberOfElements"
helpviewer_keywords: 
  - "IDebugArrayField::GetNumberOfElements method"
ms.assetid: a1961ef3-d69d-4022-b8c9-b9cfb9811345
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugArrayField::GetNumberOfElements
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Gets the number of elements in the array.  
  
## Syntax  
  
```cpp#  
HRESULT GetNumberOfElements(   
   DWORD* pdwNumElements  
);  
```  
  
```csharp  
int GetNumberOfElements(  
   out uint pdwNumElements  
);  
```  
  
#### Parameters  
 `pdwNumElements`  
 [out] Returns the number of elements in the array.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The value returned is the total number of elements in the array, regardless of the number of dimensions.  
  
## See Also  
 [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)

