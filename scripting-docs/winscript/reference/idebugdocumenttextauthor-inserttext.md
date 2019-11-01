---
title: "IDebugDocumentTextAuthor::InsertText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextAuthor.InsertText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextAuthor::InsertText"
ms.assetid: ef4e6a5b-8efa-4290-b498-c0f8a6aac09b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextAuthor::InsertText
Inserts new text into the document.  
  
## Syntax  
  
```cpp
HRESULT InsertText(  
   ULONG    cCharacterPosition,  
   ULONG    cNumToInsert,  
   OLECHAR  pcharText[]  
);  
```  
  
#### Parameters  
 `cCharacterPosition`  
 [in] Location to insert text.  
  
 `cNumToInsert`  
 [in] Number of characters to insert.  
  
 `pcharText[]`  
 [in] A buffer containing the characters to insert.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method inserts new text into the document.  
  
## See also  
 [IDebugDocumentTextAuthor Interface](../../winscript/reference/idebugdocumenttextauthor-interface.md)   
 [IDebugDocumentTextAuthor::RemoveText](../../winscript/reference/idebugdocumenttextauthor-removetext.md)