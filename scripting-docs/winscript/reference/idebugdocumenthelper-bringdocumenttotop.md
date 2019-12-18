---
title: "IDebugDocumentHelper::BringDocumentToTop | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.BringDocumentToTop"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::BringDocumentToTop"
ms.assetid: 91bdbb05-6f79-4b07-a707-838cb75a770f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::BringDocumentToTop
Brings this document to the top in the debugger user interface.  
  
## Syntax  
  
```cpp
HRESULT BringDocumentToTop();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method starts the debugger if it is not already started.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)