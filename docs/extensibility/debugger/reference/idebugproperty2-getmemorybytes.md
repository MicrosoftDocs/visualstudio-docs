---
title: "IDebugProperty2::GetMemoryBytes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProperty2::GetMemoryBytes"
helpviewer_keywords: 
  - "IDebugProperty2::GetMemoryBytes"
ms.assetid: b32042ed-7a06-4b4a-99ef-fe03b0aa61cc
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugProperty2::GetMemoryBytes
Gets the memory bytes that compose the value of a property.  
  
## Syntax  
  
```cpp  
HRESULT GetMemoryBytes (   
   IDebugMemoryBytes2** ppMemoryBytes  
);  
```  
  
```csharp  
int GetMemoryBytes (   
   out IDebugMemoryBytes2 ppMemoryBytes  
);  
```  
  
#### Parameters  
 `ppMemoryBytes`  
 [out] Returns an [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md) object that can be used to retrieve the memory that contains the value of the property.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETMEMORYBYTES_NO_MEMORY_BYTES` if there are no memory bytes to retrieve.  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md)