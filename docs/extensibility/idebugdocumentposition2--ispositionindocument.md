---
title: "IDebugDocumentPosition2::IsPositionInDocument"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugDocumentPosition2::IsPositionInDocument"
helpviewer_keywords: 
  - "IDebugDocumentPosition2::IsPositionInDocument"
ms.assetid: d5cf57cb-b93b-4e1d-bec9-185f4fe8668d
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugDocumentPosition2::IsPositionInDocument
Determines if the document position is contained in the given document.  
  
## Syntax  
  
```cpp#  
HRESULT IsPositionInDocument(   
   IDebugDocument2* pDoc  
);  
```  
  
```c#  
int IsPositionInDocument(   
   IDebugDocument2 pDoc  
);  
```  
  
#### Parameters  
 `pDoc`  
 [in] The [IDebugDocument2](../extensibility/idebugdocument2.md) object that represents the containing document candidate.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is used primarily in setting breakpoints in [IDebugDocument2](../extensibility/idebugdocument2.md) interfaces. As documents are loaded, the breakpoint position is called to determine if the document contains this position.  
  
## See Also  
 [IDebugDocumentPosition2](../extensibility/idebugdocumentposition2.md)   
 [IDebugDocument2](../extensibility/idebugdocument2.md)