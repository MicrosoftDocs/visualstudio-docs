---
title: "IDebugStackFrame2::GetDocumentContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugStackFrame2::GetDocumentContext"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetDocumentContext"
ms.assetid: 69e81439-1238-4f18-9028-6fd1c1ba5e4a
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugStackFrame2::GetDocumentContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the document context for this stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocumentContext (   
   IDebugDocumentContext2** ppCxt  
);  
```  
  
```csharp  
int GetDocumentContext (   
   out IDebugDocumentContext2 ppCxt  
);  
```  
  
#### Parameters  
 `ppCxt`  
 [out] Returns an [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) object that represents the current position in a source document.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is faster than calling the [GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md) method and then calling the [GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md) method on the code context. However, it is not guaranteed that every debug engine (DE) will implement this method.  
  
## See Also  
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)   
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)   
 [GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md)   
 [GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md)
