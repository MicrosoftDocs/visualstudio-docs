---
title: "IDebugDocumentInfo::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentInfo.GetName"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentInfo::GetName"
ms.assetid: c25d73da-99b6-4c9f-82af-182b4853f81c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentInfo::GetName
Returns the specified document name.  
  
## Syntax  
  
```cpp
HRESULT GetName(  
   DOCUMENTNAMETYPE  dnt,  
   BSTR*             pbstrName  
);  
```  
  
#### Parameters  
 `dnt`  
 [in] The type of document name to return.  
  
 `pbstrName`  
 [out] String containing the name.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|The specified document name is not known.|  
  
## Remarks  
 This method returns the specified document name.  
  
## See also  
 [IDebugDocumentInfo Interface](../../winscript/reference/idebugdocumentinfo-interface.md)   
 [DOCUMENTNAMETYPE Enumeration](../../winscript/reference/documentnametype-enumeration.md)