---
title: "IDebugProperty2::GetMemoryContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProperty2::GetMemoryContext"
helpviewer_keywords: 
  - "IDebugProperty2::GetMemoryContext"
ms.assetid: 91793d25-790f-4881-a5c0-d0458e534514
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# IDebugProperty2::GetMemoryContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the memory context of the property value.  
  
## Syntax  
  
```cpp#  
HRESULT GetMemoryContext (   
   IDebugMemoryContext2** ppMemory  
);  
```  
  
```csharp  
int GetMemoryContext(  
   out IDebugMemoryContext2 ppMemory  
);  
```  
  
#### Parameters  
 `ppMemory`  
 [out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object that represents the memory associated with this property.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETMEMORYCONTEXT_NO_MEMORY_CONTEXT` if there is no memory context to retrieve.  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
