---
title: "IDebugArrayObject2::HasBaseIndices | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "HasBaseIndices"
  - "IDebugArrayObject2::HasBaseIndices"
ms.assetid: 51a5d145-ea53-422c-b5cf-c800cf64b8e6
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugArrayObject2::HasBaseIndices
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines if the array has base indices (lower bounds) defined.  
  
## Syntax  
  
```cpp#  
HRESULT HasBaseIndices (  
   BOOL* pfHasBaseIndices  
);  
```  
  
```csharp  
int HasBaseIndices (  
   out bool pfHasBaseIndices  
);  
```  
  
#### Parameters  
 `pfHasBaseIndices`  
 [out] TRUE to specify that the array has base indices (lower bounds); otherwise, FALSE.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.
