---
title: "IDebugObject::GetMemoryContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugObject::GetMemoryContext"
helpviewer_keywords: 
  - "IDebugObject::GetMemoryContext method"
ms.assetid: 6760a0d3-a898-4e81-b68f-c45c584b225b
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugObject::GetMemoryContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the memory context that represents the address of the value of the object.  
  
## Syntax  
  
```cpp#  
HRESULT GetMemoryContext(   
   IDebugMemoryContext2** pContext  
);  
```  
  
```csharp  
int GetMemoryContext(  
   ref IDebugMemoryContext2 pContext  
);  
```  
  
#### Parameters  
 `pContext`  
 [out] Returns an [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object representing the address of the value of the object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The returned memory context specifies the address of the value as represented by this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object.  
  
## See Also  
 [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
