---
title: "IRemoteDebugApplicationThreadEx:EnumGlobalContexts | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationThreadEx:EnumGlobalContexts"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationThreadEx:EnumGlobalContexts"
ms.assetid: a6c0bc3f-4afc-41e1-b734-06e252c5b171
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationThreadEx:EnumGlobalContexts
Enumerates the global expression contexts for all languages running in this thread.  
  
## Syntax  
  
```cpp
HRESULT EnumGlobalExpressionContexts(  
   IEnumDebugExpressionContexts**  ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Enumerator that lists the global expression contexts for all languages running in this thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks