---
title: "IDebugMemoryContext2::Subtract | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugMemoryContext2::Subtract"
helpviewer_keywords: 
  - "Subtract method"
  - "IDebugMemoryContext2::Subtract method"
ms.assetid: 63df14c7-8d7e-47c1-afa7-5a1ab5d8eaba
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugMemoryContext2::Subtract
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Subtracts the specified value from the current context and returns a new context.  
  
## Syntax  
  
```cpp#  
HRESULT Subtract(   
   UINT64                 dwCount,  
   IDebugMemoryContext2** ppMemCxt  
);  
```  
  
```csharp  
int Subtract(  
   ulong                    dwCount,   
   out IDebugMemoryContext2 ppMemCxt  
);  
```  
  
#### Parameters  
 `dwCount`  
 [in] The number of memory bytes to decrement.  
  
 `ppMemCxt`  
 [out] Returns a new [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A memory context is an address, so subtracting a value from an address produces a new address that requires a new context interface.  
  
 This method must always produce a new context, even if the resulting address is outside the memory space associated with this context. The only exception to this is if no memory can be allocated for the new context or if `ppMemCxt` is a null value (which is an error).  
  
## See also  
 [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
