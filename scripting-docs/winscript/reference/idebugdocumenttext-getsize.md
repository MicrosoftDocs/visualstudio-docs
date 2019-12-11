---
title: "IDebugDocumentText::GetSize | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentText.GetSize"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentText::GetSize"
ms.assetid: 9da53856-613a-44b2-a84c-99454a2a1548
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentText::GetSize
Returns the number of lines and number of characters in the document.  
  
## Syntax  
  
```cpp
HRESULT GetSize(  
   ULONG*  pcNumLines,  
   ULONG*  pcNumChars  
);  
```  
  
#### Parameters  
 `pcNumLines`  
 [out] Number of lines in the document. If this parameter is NULL, the method does not return a value.  
  
 `pcNumChars`  
 [out] Number of characters in the document. If this parameter is NULL, the method does not return a value.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the number of lines and number of characters in the document.  
  
## See also  
 [IDebugDocumentText Interface](../../winscript/reference/idebugdocumenttext-interface.md)