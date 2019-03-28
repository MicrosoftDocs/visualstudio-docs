---
title: "IDebugDocumentTextEvents2::onReplaceText | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentTextEvents2::OnReplaceText"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onReplaceText"
ms.assetid: cb39f025-66d8-4dc0-bef6-1bdc8e07db92
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentTextEvents2::onReplaceText
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Notifies the debug package that text has been replaced in the document.  
  
## Syntax  
  
```cpp#  
HRESULT onReplaceText(   
   TEXT_POSITION pos,  
   DWORD         dwNumToReplace  
);  
```  
  
```csharp  
int onReplaceText(   
   enum_TEXT_POSITION pos,  
   uint               dwNumToReplace  
);  
```  
  
#### Parameters  
 `pos`  
 [in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) indicates where the text was replaced.  
  
 `dwNumToReplace`  
 [in] Specifies the number of characters of text that were replaced.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)   
 [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
