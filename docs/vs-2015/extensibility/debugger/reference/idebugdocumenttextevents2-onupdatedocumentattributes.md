---
title: "IDebugDocumentTextEvents2::onUpdateDocumentAttributes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentTextEvents2::OnUpdateDocumentAttributes"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onUpdateDocumentAttributes"
ms.assetid: 31b7d151-9ce2-438e-b405-f8cc46b9f537
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentTextEvents2::onUpdateDocumentAttributes
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Notifies receiver of the event that the document attributes have been updated.  
  
## Syntax  
  
```cpp#  
HRESULT onUpdateDocumentAttributes(   
   TEXT_DOC_ATTR_2 textdocattr  
);  
```  
  
```csharp  
int onUpdateDocumentAttributes(   
   enum_TEXT_DOC_ATTR_2 textdocattr  
);  
```  
  
#### Parameters  
 `textdocattr`  
 [in] A combination of flags from the [TEXT_DOC_ATTR_2](../../../extensibility/debugger/reference/text-doc-attr-2.md) enumeration that specifies the updated attributes of the document.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)   
 [TEXT_DOC_ATTR_2](../../../extensibility/debugger/reference/text-doc-attr-2.md)
