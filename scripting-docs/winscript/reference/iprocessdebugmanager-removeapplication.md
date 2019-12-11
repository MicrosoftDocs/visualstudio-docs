---
title: "IProcessDebugManager::RemoveApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IProcessDebugManager.RemoveApplication"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IProcessDebugManager::RemoveApplication"
ms.assetid: 334e869d-81ae-4d30-9e89-89763ad4f184
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProcessDebugManager::RemoveApplication
Removes an application from the running application list.  
  
## Syntax  
  
```cpp
HRESULT RemoveApplication(  
   DWORD  dwAppCookie  
);  
```  
  
#### Parameters  
 `dwAppCookie`  
 [in] The cookie provided by `IProcessDebugManager::AddApplication` when the application was added to the application list.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method removes an application from the running application list.  
  
## See also  
 [IProcessDebugManager::AddApplication](../../winscript/reference/iprocessdebugmanager-addapplication.md)   
 [IProcessDebugManager Interface](../../winscript/reference/iprocessdebugmanager-interface.md)