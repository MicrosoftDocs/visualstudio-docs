---
title: "IDebugArrayField::GetRank"
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
  - "IDebugArrayField::GetRank"
helpviewer_keywords: 
  - "IDebugArrayField::GetRank method"
ms.assetid: 2364b876-5be1-4bab-9b8f-3b6121da35c6
caps.latest.revision: 9
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
# IDebugArrayField::GetRank
Gets the rank or number of dimensions of the array.  
  
## Syntax  
  
```cpp#  
HRESULT GetRank(   
   DWORD* pdwRank  
);  
```  
  
```c#  
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
 The rank of an array corresponds to the number of dimensions. In C++ and C#, multi-dimensional arrays are really arrays of arrays and can therefore be considered just a one-dimensional array (and the `GetRank` method always returns 1). In [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)], on the other hand, multi-dimensional arrays are handled differently and the rank of such an array reflects the number of dimensions (and the `GetRank` method always returns the number of dimensions).  
  
## See Also  
 [IDebugArrayField](../extensibility/idebugarrayfield.md)