---
title: "IDebugDocumentHost::GetFileName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHost.GetFileName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentHost::GetFileName"
ms.assetid: b814a848-8a3d-468d-9282-c5c0354b22a1
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHost::GetFileName
Returns the name of the document without path information.  
  
## Syntax  
  
```cpp
HRESULT GetFileName(  
   BSTR*  pbstrShortName  
);  
```  
  
#### Parameters  
 `pbstrShortName`  
 [out] A string containing the short name of the document.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the short name of the document without path information. The short name is typically used in situations such as the **Save As...** dialog box.  
  
## See also  
 [IDebugDocumentHost Interface](../../winscript/reference/idebugdocumenthost-interface.md)