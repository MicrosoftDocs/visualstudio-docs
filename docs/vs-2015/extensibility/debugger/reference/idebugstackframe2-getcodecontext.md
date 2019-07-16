---
title: "IDebugStackFrame2::GetCodeContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugStackFrame2::GetCodeContext"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetCodeContext"
ms.assetid: 93d66159-a41d-49ef-982f-91bb4d073b74
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugStackFrame2::GetCodeContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the code context for this stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT GetCodeContext (   
   IDebugCodeContext2** ppCodeCxt  
);  
```  
  
```csharp  
int GetCodeContext (   
   out IDebugCodeContext2 ppCodeCxt  
);  
```  
  
#### Parameters  
 `ppCodeCxt`  
 [out] Returns an [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that represents the current instruction pointer in this stack frame.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)   
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
