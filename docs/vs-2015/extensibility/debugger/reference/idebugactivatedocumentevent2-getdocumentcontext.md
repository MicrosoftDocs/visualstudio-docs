---
title: "IDebugActivateDocumentEvent2::GetDocumentContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugActivateDocumentEvent2::GetDocumentContext"
helpviewer_keywords: 
  - "GetDocumentContext method"
  - "IDebugActivateDocumentEvent2::GetDocumentContext method"
ms.assetid: e7472069-7337-4ef4-8f8a-8c027a2e22f4
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugActivateDocumentEvent2::GetDocumentContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the document context that describes the position in the document that is to be made active by the debug package.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocumentContext (   
   IDebugDocumentContext2** ppDocContext  
);  
```  
  
```csharp  
int GetDocumentContext (   
   out IDebugDocumentContext2 ppDocContext  
);  
```  
  
#### Parameters  
 `ppDocContext`  
 [out] Returns an [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) object that represents a position in a source file document.  
  
## Remarks  
 This position might be used to show the caret, for example.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugActivateDocumentEvent2](../../../extensibility/debugger/reference/idebugactivatedocumentevent2.md)   
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
