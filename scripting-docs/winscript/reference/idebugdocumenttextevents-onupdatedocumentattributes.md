---
title: "IDebugDocumentTextEvents::onUpdateDocumentAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextEvents.onUpdateDocumentAttributes"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents::onUpdateDocumentAttributes"
ms.assetid: 48fa909c-14c2-4ca4-af86-a5809c72dd39
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextEvents::onUpdateDocumentAttributes
Indicates that the document attributes changed.  
  
## Syntax  
  
```cpp
HRESULT onUpdateDocumentAttributes(  
   TEXT_DOC_ATTR  textdocattr  
);  
```  
  
#### Parameters  
 `textdocattr`  
 [in] The new document attributes.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method indicates that the document attributes have changed.  
  
## See also  
 [IDebugDocumentTextEvents Interface](../../winscript/reference/idebugdocumenttextevents-interface.md)   
 [TEXT_DOC_ATTR Constants](../../winscript/reference/text-doc-attr-constants.md)