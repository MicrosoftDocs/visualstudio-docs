---
title: "IProcessDebugManager::CreateApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IProcessDebugManager.CreateApplication"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IProcessDebugManager::CreateApplication"
ms.assetid: d6b646f2-8af0-445c-ae7e-a9772042b3a1
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProcessDebugManager::CreateApplication
Creates a new debug application object for this application.  
  
## Syntax  
  
```cpp
HRESULT CreateApplication(  
   IDebugApplication**  ppda  
);  
```  
  
#### Parameters  
 `ppda`  
 [out] The debug application object for this application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The object created by this method has no name and is not added to the running application list. Use the `IProcessDebugManager::AddApplication` to add the debug application to the application list.  
  
## See also  
 [IProcessDebugManager Interface](../../winscript/reference/iprocessdebugmanager-interface.md)   
 [IProcessDebugManager::AddApplication](../../winscript/reference/iprocessdebugmanager-addapplication.md)