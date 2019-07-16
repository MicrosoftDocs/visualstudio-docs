---
title: "IDebugDocumentContext2::GetDocument | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentContext2::GetDocument"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetDocument"
ms.assetid: c6d46c5d-ade8-4dc8-9862-8fc7876658c4
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentContext2::GetDocument
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the document that contains this document context.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocument(   
   IDebugDocument2** ppDocument  
);  
```  
  
```csharp  
int GetDocument(   
   out IDebugDocument2 ppDocument  
);  
```  
  
#### Parameters  
 `ppDocument`  
 [out] Returns an [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the document that contains this document context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is for those debug engines that supply documents directly to the IDE. Otherwise, this method should return `E_NOTIMPL`.  
  
## See Also  
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)   
 [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
