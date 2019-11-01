---
title: "IDebugDocumentText::GetPositionOfLine | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentText.GetPositionOfLine"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentText::GetPositionOfLine"
ms.assetid: d1e6e81b-ddec-4a7c-9b6a-d199e3debfc2
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentText::GetPositionOfLine
Returns the character-position corresponding to the first character of a line.  
  
## Syntax  
  
```cpp
HRESULT GetPositionOfLine(  
   ULONG   cLineNumber,  
   ULONG*  pcCharacterPosition  
);  
```  
  
#### Parameters  
 `cLineNumber`  
 [in] The line number.  
  
 `pcCharacterPosition`  
 [out] The character position within the document of the start of line `cLineNumber`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the character position corresponding to the first character of a line.  
  
## See also  
 [IDebugDocumentText Interface](../../winscript/reference/idebugdocumenttext-interface.md)