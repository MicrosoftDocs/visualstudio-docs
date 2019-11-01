---
title: "IDebugDocumentTextExternalAuthor::GetPathName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextExternalAuthor.GetPathName"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextExternalAuthor::GetPathName"
ms.assetid: 445152a1-9cf8-402e-93d6-3d4bf2b81d17
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextExternalAuthor::GetPathName
Returns the full path and file name of the document.  
  
## Syntax  
  
```cpp
HRESULT GetPathName(  
   BSTR*  pbstrLongName,  
   BOOL*  pfIsOriginalFile  
);  
```  
  
#### Parameters  
 `pbstrLongName`  
 [out] String containing the full path and file name.  
  
 `pfIsOriginalFile`  
 [out] Boolean that indicates if the path and file name refer to the original document.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|The source file cannot be created or determined.|  
  
## Remarks  
 This method returns the full path and file name of the document.  
  
 If `pfIsOriginalFile` is FALSE, the path and file name in `pbstrLongName` refer to a newly created temporary file.  
  
## See also  
 [IDebugDocumentTextExternalAuthor Interface](../../winscript/reference/idebugdocumenttextexternalauthor-interface.md)