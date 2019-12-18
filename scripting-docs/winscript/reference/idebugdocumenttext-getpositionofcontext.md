---
title: "IDebugDocumentText::GetPositionOfContext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentText.GetPositionOfContext"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentText::GetPositionOfContext"
ms.assetid: 90fec730-c3fb-45fb-92ef-05ecc90dca38
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentText::GetPositionOfContext
Returns the character-position range corresponding to a document context.  
  
## Syntax  
  
```cpp
HRESULT GetPositionOfContext(  
   IDebugDocumentContext*  psc,  
   ULONG*                  pcCharacterPosition,  
   ULONG*                  cNumChars  
);  
```  
  
#### Parameters  
 `psc`  
 [in] The document context object.  
  
 `pcCharacterPosition`  
 [out] Start location of the character position range.  
  
 `cNumChars`  
 [out] Number of characters in the range.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The document context provided to this method must be associated with this document.  
  
## See also  
 [IDebugDocumentText Interface](../../winscript/reference/idebugdocumenttext-interface.md)