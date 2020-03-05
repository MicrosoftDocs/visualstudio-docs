---
title: "IDebugDocumentHelper::SetDebugDocumentHost | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.SetDebugDocumentHost"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::SetDebugDocumentHost"
ms.assetid: b26a03c3-8a3f-47b0-b916-4c65d5500f10
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::SetDebugDocumentHost
Sets the `IDebugDocumentHost` for this document.  
  
## Syntax  
  
```cpp
HRESULT SetDebugDocumentHost(  
   IDebugDocumentHost*  pddh  
);  
```  
  
#### Parameters  
 `pddh`  
 [in] The debug document host.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `IDebugDocumentHost` interface is used for smart-host syntax coloring, fetching deferred text, and returning controlling objects for newly created document contexts.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)   
 [IDebugDocumentHost Interface](../../winscript/reference/idebugdocumenthost-interface.md)