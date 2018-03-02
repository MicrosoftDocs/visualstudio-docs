---
title: "IDebugMemoryContext2::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugMemoryContext2::GetName"
helpviewer_keywords: 
  - "IDebugMemoryContext2::GetName method"
  - "GetName method"
ms.assetid: 8c212556-7d9e-4d68-b2a9-8212f50d0287
caps.latest.revision: 13
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugMemoryContext2::GetName
Retrieves the user-displayable name for this context.  
  
## Syntax  
  
```cpp  
HRESULT GetName(   
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetName(  
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the memory context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The name of a memory context is not normally used.  
  
## See Also  
 [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)