---
title: "IDebugDocumentTextEvents2::onRemoveText | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentTextEvents2::OnRemoveText"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onRemoveText"
ms.assetid: 1ebeabb2-52a1-4ccc-83cd-9ae7c3541783
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentTextEvents2::onRemoveText
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Notifies the debug package that text has been removed from the document.  
  
## Syntax  
  
```cpp#  
HRESULT onRemoveText(   
   TEXT_POSITION pos,  
   DWORD         dwNumToRemove  
);  
```  
  
```csharp  
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
