---
title: "IDebugDocumentPosition2::IsPositionInDocument | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugDocumentPosition2::IsPositionInDocument"
helpviewer_keywords: 
  - "IDebugDocumentPosition2::IsPositionInDocument"
ms.assetid: d5cf57cb-b93b-4e1d-bec9-185f4fe8668d
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugDocumentPosition2::IsPositionInDocument
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Determines if the document position is contained in the given document.  
  
## Syntax  
  
```cpp#  
HRESULT IsPositionInDocument(   
   IDebugDocument2* pDoc  
);  
```  
  
```csharp  
int IsPositionInDocument(   
   IDebugDocument2 pDoc  
);  
```  
  
#### Parameters  
 `pDoc`  
 [in] The [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the containing document candidate.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is used primarily in setting breakpoints in [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) interfaces. As documents are loaded, the breakpoint position is called to determine if the document contains this position.  
  
## See Also  
 [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)   
 [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)

