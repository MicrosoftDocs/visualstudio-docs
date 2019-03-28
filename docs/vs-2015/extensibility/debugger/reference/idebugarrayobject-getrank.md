---
title: "IDebugArrayObject::GetRank | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugArrayObject::GetRank"
helpviewer_keywords: 
  - "IDebugArrayObject::GetRank method"
ms.assetid: 9948551a-e334-4ff6-979c-08dab633b9b6
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugArrayObject::GetRank
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the rank of the array, that is, the number of dimensions.  
  
## Syntax  
  
```cpp#  
HRESULT GetRank(   
   DWORD* pdwRank  
);  
```  
  
```csharp  
int GetRank(  
   out uint pdwRank  
);  
```  
  
#### Parameters  
 `pdwRank`  
 [out] Returns the rank.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Use the [GetDimensions](../../../extensibility/debugger/reference/idebugarrayobject-getdimensions.md) method to retrieve the size of each dimension of the array object.  
  
## See Also  
 [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)
