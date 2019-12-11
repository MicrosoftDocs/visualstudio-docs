---
title: "IDebugDocumentText::GetDocumentAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentText.GetDocumentAttributes"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentText::GetDocumentAttributes"
ms.assetid: 8c544ca1-8db4-4bca-973e-09315d9a0ee5
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentText::GetDocumentAttributes
Returns the attributes of the document.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentAttributes(  
   TEXT_DOC_ATTR*  ptextdocattr  
);  
```  
  
#### Parameters  
 `ptextdocattr`  
 [out] The text attributes of the document.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the attributes of the document.  
  
## See also  
 [IDebugDocumentText Interface](../../winscript/reference/idebugdocumenttext-interface.md)   
 [TEXT_DOC_ATTR Constants](../../winscript/reference/text-doc-attr-constants.md)