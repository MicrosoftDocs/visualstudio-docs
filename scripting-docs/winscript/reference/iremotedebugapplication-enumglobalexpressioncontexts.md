---
title: "IRemoteDebugApplication::EnumGlobalExpressionContexts | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplication.EnumGlobalExpressionContexts"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplication::EnumGlobalExpressionContexts"
ms.assetid: 61598a34-f409-42a2-810d-a9e92e2f4861
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication::EnumGlobalExpressionContexts
Enumerates the global expression contexts for all languages running in this application.  
  
## Syntax  
  
```cpp
HRESULT EnumGlobalExpressionContexts(  
   IEnumDebugExpressionContexts**  ppedec  
);  
```  
  
#### Parameters  
 `ppedec`  
 [out] Enumerator that lists the global expression contexts for all languages running in this application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method enumerates the global expression contexts for all languages running in this application.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)