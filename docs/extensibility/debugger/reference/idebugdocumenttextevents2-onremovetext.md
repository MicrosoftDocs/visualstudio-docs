---
title: "IDebugDocumentTextEvents2::onRemoveText | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugDocumentTextEvents2::OnRemoveText"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onRemoveText"
ms.assetid: 1ebeabb2-52a1-4ccc-83cd-9ae7c3541783
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
# IDebugDocumentTextEvents2::onRemoveText
Notifies the debug package that text has been removed from the document.  
  
## Syntax  
  
```cpp#  
HRESULT onRemoveText(   
   TEXT_POSITION pos,  
   DWORD         dwNumToRemove  
);  
```  
  
```c#  
int onRemoveText(   
   enum_TEXT_POSITION pos,  
   uint               dwNumToRemove  
);  
```  
  
#### Parameters  
 `pos`  
 [in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that indicates where the text was removed.  
  
 `dwNumToRemove`  
 [in] Specifies the number of characters of text that were removed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)   
 [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)