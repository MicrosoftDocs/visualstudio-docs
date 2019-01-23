---
title: "IDebugMemoryContext2::Add | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugMemoryContext2::Add"
helpviewer_keywords: 
  - "IDebugMemoryContext2::Add method"
  - "Add method"
ms.assetid: 3c47e646-ce9e-4dd3-8f1a-6dbd3827d407
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugMemoryContext2::Add
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Adds the specified value to the current context and returns a new context.  
  
## Syntax  
  
```cpp#  
HRESULT Add(   
   UINT64                 dwCount,  
   IDebugMemoryContext2** ppMemCxt  
);  
```  
  
```csharp  
int Add(  
   ulong                    dwCount,   
   out IDebugMemoryContext2 ppMemCxt  
);  
```  
  
#### Parameters  
 `dwCount`  
 [in] The value to add to the current context.  
  
 `ppMemCxt`  
 [out] Returns a new [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A memory context is an address, so adding a value to an address produces a new address that requires a new context interface.  
  
 This method must always produce a new context, even if the resulting address is outside the memory space associated with this context. The only exception to this is if no memory can be allocated for the new context or if `ppMemCxt` is a null value (which is an error).  
  
## See Also  
 [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
