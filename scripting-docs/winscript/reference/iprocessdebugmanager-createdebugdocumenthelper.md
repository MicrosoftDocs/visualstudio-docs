---
title: "IProcessDebugManager::CreateDebugDocumentHelper | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IProcessDebugManager.CreateDebugDocumentHelper"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IProcessDebugManager::CreateDebugDocumentHelper"
ms.assetid: d644e192-1bcc-4768-a91e-239cd920adcd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProcessDebugManager::CreateDebugDocumentHelper
Creates a new debug document helper for this application.  
  
## Syntax  
  
```cpp
HRESULT CreateDebugDocumentHelper(  
   IUnknown*               punkOuter,  
   IDebugDocumentHelper**  pddh  
);  
```  
  
#### Parameters  
 `punkOuter`  
 [in] If the returned object is to be aggregated, `punkOuter` is an interface pointer to the controlling `IUnknown`. Otherwise, it is a null pointer.  
  
 `pddh`  
 [out] The debug document helper object for this application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates a new debug document helper for this application.  
  
## See also  
 [IProcessDebugManager Interface](../../winscript/reference/iprocessdebugmanager-interface.md)