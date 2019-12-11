---
title: "IDebugDocumentInfo::GetDocumentClassId | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentInfo.GetDocumentClassId"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentInfo::GetDocumentClassId"
ms.assetid: 3b858794-2c0c-42ba-b98c-cd820ebace20
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentInfo::GetDocumentClassId
Returns a `CLSID` identifying the document type.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentClassId(  
   CLSID*  pclsidDocument  
);  
```  
  
#### Parameters  
 `pclsidDocument`  
 [out] A `CLSID` identifying the document type.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method allows the debugger IDE to host custom viewers for this document.  
  
 If the document does not have viewable data, the return value of `pclsidDocument` is `CLSID_NULL`.  
  
## See also  
 [IDebugDocumentInfo Interface](../../winscript/reference/idebugdocumentinfo-interface.md)