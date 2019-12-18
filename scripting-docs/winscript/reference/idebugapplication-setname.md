---
title: "IDebugApplication::SetName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.SetName"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::SetName"
ms.assetid: 7b0ddc58-6f20-4ce3-9bdf-81a6c1d64256
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::SetName
Sets the name of the application.  
  
## Syntax  
  
```cpp
HRESULT SetName(  
   LPCOLESTR  pstrName  
);  
```  
  
#### Parameters  
 `pstrName`  
 [in] The name of the application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The name provided to this method is returned in subsequent calls to the `IRemoteDebugApplication::GetName` method.  
  
 This method should be called before calling the `IProcessDebugManager::AddApplication` method.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IProcessDebugManager::AddApplication](../../winscript/reference/iprocessdebugmanager-addapplication.md)