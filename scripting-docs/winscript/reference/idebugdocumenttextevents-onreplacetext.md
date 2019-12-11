---
title: "IDebugDocumentTextEvents::onReplaceText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextEvents.onReplaceText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents::onReplaceText"
ms.assetid: 3cb053c4-1f7f-4aed-aee6-f8a9e9e69d29
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextEvents::onReplaceText
Indicates that text has been replaced.  
  
## Syntax  
  
```cpp
HRESULT onReplaceText(  
   ULONG  cCharacterPosition,  
   ULONG  cNumToReplace  
);  
```  
  
#### Parameters  
 `cCharacterPosition`  
 [in] The character position of the first character replaced.  
  
 `cNumToReplace`  
 [in] The number of characters replaced.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method indicates that text has been replaced.  
  
## See also  
 [IDebugDocumentTextEvents Interface](../../winscript/reference/idebugdocumenttextevents-interface.md)