---
title: "IDebugDocumentHost::GetPathName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHost.GetPathName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentHost::GetPathName"
ms.assetid: 8abe2a86-e467-4ac9-8ccb-8761141bfa0d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHost::GetPathName
Returns the full path and file name of the document's source file.  
  
## Syntax  
  
```cpp
HRESULT GetPathName(  
   BSTR*  pbstrLongName,  
   BOOL*  pfIsOriginalFile  
);  
```  
  
#### Parameters  
 `pbstrLongName`  
 [out] A string containing the long name.  
  
 `pfIsOriginalFile`  
 [out] A flag that is true if `pbstrLongName` refers to the original file for the document, false otherwise.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|No source file can be created or determined.|  
  
## Remarks  
 This method returns the full path and file name of the document's source file.  
  
## See also  
 [IDebugDocumentHost Interface](../../winscript/reference/idebugdocumenthost-interface.md)