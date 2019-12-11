---
title: "IDebugDocumentText::GetText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentText.GetText"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentText::GetText"
ms.assetid: 3c940a30-6c0f-4deb-aa4d-21a0bdef8461
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentText::GetText
Retrieves the characters and/or the character attributes associated with a character-position range.  
  
## Syntax  
  
```cpp
HRESULT GetText(  
   ULONG              cCharacterPosition,  
   WCHAR*             pcharText,  
   SOURCE_TEXT_ATTR*  pstaTextAttr,  
   ULONG*             pcNumChars,  
   ULONG              cMaxChars  
);  
```  
  
#### Parameters  
 `cCharacterPosition`  
 [in] Start location of the character position range.  
  
 `pcharText`  
 [in, out] A character text buffer. The buffer must be large enough to hold `cMaxChars` characters. If this parameter is NULL, the method does not return characters.  
  
 `pstaTextAttr`  
 [in, out] A character attribute buffer. The buffer must be large enough to hold `cMaxChars` characters. If this parameter is NULL, the method does not return attributes.  
  
 `pcNumChars`  
 [in, out] The number of characters/attributes returned. This parameter must be set to zero before calling this method.  
  
 `cMaxChars`  
 [in] Number of characters in the character position range. Also specifies the maximum number of characters to return.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method retrieves the characters and/or the character attributes associated with a character-position range. The character position range is specified by a character-position and a number of characters.  
  
## See also  
 [IDebugDocumentText Interface](../../winscript/reference/idebugdocumenttext-interface.md)   
 [SOURCE_TEXT_ATTR Enumeration](../../winscript/reference/source-text-attr-enumeration.md)