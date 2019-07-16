---
title: "IDebugArrayField::GetRank | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugArrayField::GetRank"
helpviewer_keywords: 
  - "IDebugArrayField::GetRank method"
ms.assetid: 2364b876-5be1-4bab-9b8f-3b6121da35c6
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugArrayField::GetRank
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the rank or number of dimensions of the array.  
  
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
 The rank of an array corresponds to the number of dimensions. In C++ and C#, multi-dimensional arrays are really arrays of arrays and can therefore be considered just a one-dimensional array (and the `GetRank` method always returns 1). In [!INCLUDE[vbprvb](../../../includes/vbprvb-md.md)], on the other hand, multi-dimensional arrays are handled differently and the rank of such an array reflects the number of dimensions (and the `GetRank` method always returns the number of dimensions).  
  
## See Also  
 [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)
