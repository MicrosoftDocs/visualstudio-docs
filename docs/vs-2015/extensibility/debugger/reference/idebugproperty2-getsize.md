---
title: "IDebugProperty2::GetSize | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProperty2::GetSize"
helpviewer_keywords: 
  - "IDebugProperty2::GetSize"
ms.assetid: 0deb8ec5-d6fb-4622-bb14-0c46b9459cc6
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProperty2::GetSize
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the size, in bytes, of the property value.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize (   
   DWORD* pdwSize  
);  
```  
  
```csharp  
int GetSize (   
   out uint pdwSize  
);  
```  
  
#### Parameters  
 `pdwSize`  
 [out] Returns the size, in bytes, of the property value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETSIZE_NO_SIZE` if the property has no size.  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
