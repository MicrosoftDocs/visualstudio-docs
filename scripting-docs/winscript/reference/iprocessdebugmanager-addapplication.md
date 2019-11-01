---
title: "IProcessDebugManager::AddApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IProcessDebugManager.AddApplication"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IProcessDebugManager::AddApplication"
ms.assetid: 73828299-11eb-4c58-ad70-f80f2d0eede8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProcessDebugManager::AddApplication
Adds an application to the machine debug manager's list of running applications.  
  
## Syntax  
  
```cpp
HRESULT AddApplication(  
   IDebugApplication*  pda,  
   DWORD*              pdwAppCookie  
);  
```  
  
#### Parameters  
 `pda`  
 [in] The debug application to add to the list of running applications.  
  
 `pdwAppCookie`  
 [out] A cookie that is used to remove the application from the machine debug manager.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method adds an application to the running application list in the machine debug manager.  
  
## See also  
 [IProcessDebugManager Interface](../../winscript/reference/iprocessdebugmanager-interface.md)   
 [IProcessDebugManager::RemoveApplication](../../winscript/reference/iprocessdebugmanager-removeapplication.md)