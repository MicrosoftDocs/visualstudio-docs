---
title: "IDebugDocumentTextEvents::onUpdateTextAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextEvents.onUpdateTextAttributes"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents::onUpdateTextAttributes"
ms.assetid: 24a6d409-3137-4a7a-ac24-0955c109902f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextEvents::onUpdateTextAttributes
Indicates that the text attributes associated with the underlying character position range have changed.  
  
## Syntax  
  
```cpp
HRESULT onUpdateTextAttributes(  
   ULONG  cCharacterPosition,  
   ULONG  cNumToUpdate  
);  
```  
  
#### Parameters  
 `cCharacterPosition`  
 [in] The character position of the first character that the attributes have changed.  
  
 `cNumToUpdate`  
 [in] The number of characters in the range.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method indicates that the text attributes associated with the underlying character position range have changed.  
  
## See also  
 [IDebugDocumentTextEvents Interface](../../winscript/reference/idebugdocumenttextevents-interface.md)