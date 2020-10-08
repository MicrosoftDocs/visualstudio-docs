---
title: "IDebugCodeContext2::GetDocumentContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCodeContext2::GetDocumentContext"
helpviewer_keywords: 
  - "IDebugCodeContext2::GetDocumentContext"
ms.assetid: d552cc92-963f-43c1-949f-ae6b63a427b8
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugCodeContext2::GetDocumentContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the document context that corresponds to this code context. The document context represents a position in the source file that corresponds to the source code that generated this instruction.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocumentContext(   
   IDebugDocumentContext2** ppSrcCxt  
);  
```  
  
```csharp  
int GetDocumentContext(   
   out IDebugDocumentContext2 ppSrcCxt  
);  
```  
  
#### Parameters  
 `ppSrcCxt`  
 [out] Returns the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) object that corresponds to the code context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Generally, the document context can be thought of as a position in a source file while the code context is a position of a code instruction in an execution stream.  
  
## See Also  
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)   
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
