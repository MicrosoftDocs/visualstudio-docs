---
title: "IDebugTypeFieldBuilder2::CreateArrayOfType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugTypeFieldBuilder2::CreateArrayOfType"
  - "CreateArrayOfType"
ms.assetid: 85166ac9-0bff-49a0-b2fd-ca7f7a8eae4b
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugTypeFieldBuilder2::CreateArrayOfType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates an array of the specified type and size.  
  
## Syntax  
  
```cpp#  
HRESULT CreateArrayOfType (  
   IDebugField*  pTypeField,  
   DWORD         rank,  
   IDebugField** pArrayOfTypeField  
);  
```  
  
```csharp  
int CreateArrayOfType (  
   IDebugField     pTypeField,  
   uint            rank,  
   out IDebugField pArrayOfTypeField  
);  
```  
  
#### Parameters  
 `pTypeField`  
 [in] Type of elements the array will hold.  
  
 `rank`  
 [in] Number of elements in the array.  
  
 `pArrayOfTypeField`  
 [out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) objects that represent the new array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugTypeFieldBuilder2](../../../extensibility/debugger/reference/idebugtypefieldbuilder2.md)
