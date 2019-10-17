---
title: "IDebugDocumentTextAuthor::ReplaceText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextAuthor.ReplaceText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextAuthor::ReplaceText"
ms.assetid: f89304e6-5be0-45a5-947d-2c59c3c0a05e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextAuthor::ReplaceText
Replaces text in the document.  
  
## Syntax  
  
```cpp
HRESULT ReplaceText(  
   ULONG    cCharacterPosition,  
   ULONG    cNumToReplace,  
   OLECHAR  pcharText[]  
);  
```  
  
#### Parameters  
 `cCharacterPosition`  
 [in] Start location of the character range to replace.  
  
 `cNumToReplace`  
 [in] Number of characters to replace.  
  
 `pcharText[]`  
 [in] A buffer containing the new characters to replace the old characters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method replaces text in the document.  
  
## See also  
 [IDebugDocumentTextAuthor Interface](../../winscript/reference/idebugdocumenttextauthor-interface.md)