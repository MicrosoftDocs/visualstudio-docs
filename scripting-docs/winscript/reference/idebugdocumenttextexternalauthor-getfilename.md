---
title: "IDebugDocumentTextExternalAuthor::GetFileName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextExternalAuthor.GetFileName"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextExternalAuthor::GetFileName"
ms.assetid: 87acdce6-acb2-4936-80dd-d624bb7dbd42
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextExternalAuthor::GetFileName
Returns the name of the document without path information.  
  
## Syntax  
  
```cpp
HRESULT GetFileName(  
   BSTR*  pbstrShortName  
);  
```  
  
#### Parameters  
 `pbstrShortName`  
 [out] String containing the short name of the document.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the name of the document without path information. The short name is typically used in dialog boxes.  
  
## See also  
 [IDebugDocumentTextExternalAuthor Interface](../../winscript/reference/idebugdocumenttextexternalauthor-interface.md)