---
title: "IDebugPointerObject3::GetPointerAddress | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "GetPointerAddress"
  - "IDebugPointerObject3::GetPointerAddress"
ms.assetid: 4cc5af04-9e70-420d-8230-ef3108df6d51
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugPointerObject3::GetPointerAddress
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the address of the pointer.  
  
## Syntax  
  
```cpp#  
HRESULT GetPointerAddress (  
   UINT64* puAddress  
);  
```  
  
```csharp  
int GetPointerAddress (  
   out ulong puAddress  
);  
```  
  
#### Parameters  
 `puAddress`  
 [out] Returns the address of the pointer.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPointerObject3](../../../extensibility/debugger/reference/idebugpointerobject3.md)
