---
title: "IDebugDisassemblyStream2::GetScope | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDisassemblyStream2::GetScope"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetScope"
ms.assetid: 71c6e632-642a-42d8-a995-77e4ac190a5b
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDisassemblyStream2::GetScope
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the scope of the disassembly stream.  
  
## Syntax  
  
```cpp#  
HRESULT GetScope(   
   DISASSEMBLY_STREAM_SCOPE* pdwScope  
);  
```  
  
```csharp  
int GetScope(   
   out enum_ DISASSEMBLY_STREAM_SCOPE pdwScope  
);  
```  
  
#### Parameters  
 `pdwScope`  
 [out] Returns a value from the [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md) enumeration that describes the scope of this disassembly stream.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The scope of a disassembly could be a function or the whole module, for example.  
  
## See Also  
 [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md)   
 [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md)
