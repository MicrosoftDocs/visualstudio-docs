---
title: "IDebugDocumentHelper::BringDocumentContextToTop | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.BringDocumentContextToTop"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::BringDocumentContextToTop"
ms.assetid: cf9751c5-e9b7-45c6-b084-3f3873dbf01d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::BringDocumentContextToTop
Brings a context of this document to the top in the debugger user interface.  
  
## Syntax  
  
```cpp
HRESULT BringDocumentContextToTop(  
   IDebugDocumentContext*  pddc  
);  
```  
  
#### Parameters  
 `pddc`  
 Document context to bring to the top in the debugger user interface.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method brings a context of this document to the top in the debugger user interface.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)