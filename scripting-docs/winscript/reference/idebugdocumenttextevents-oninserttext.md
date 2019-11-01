---
title: "IDebugDocumentTextEvents::onInsertText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextEvents.onInsertText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents::onInsertText"
ms.assetid: 775881de-497a-47a9-86ab-823d77745a72
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextEvents::onInsertText
Indicates that new text has been added to the document.  
  
## Syntax  
  
```cpp
HRESULT onInsertText(  
   ULONG  cCharacterPosition,  
   ULONG  cNumToInsert  
);  
```  
  
#### Parameters  
 `cCharacterPosition`  
 [in] The character position where the new text was inserted.  
  
 `cNumToInsert`  
 [in] The number of characters that have been inserted.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method is typically called by a host that progressively loads content, such as a Web browser.  
  
## See also  
 [IDebugDocumentTextEvents Interface](../../winscript/reference/idebugdocumenttextevents-interface.md)   
 [IDebugDocumentTextEvents::onRemoveText](../../winscript/reference/idebugdocumenttextevents-onremovetext.md)