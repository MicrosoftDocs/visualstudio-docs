---
title: "IMachineDebugManager::AddApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IMachineDebugManager.AddApplication"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IMachineDebugManager::AddApplication"
ms.assetid: 7cd591b6-718c-4e77-acb7-a6dd147ddf57
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IMachineDebugManager::AddApplication
Adds an application to the running application list.  
  
## Syntax  
  
```cpp
HRESULT AddApplication(  
   IRemoteDebugApplication*  pda,  
   DWORD*                    pdwAppCookie  
);  
```  
  
#### Parameters  
 `pda`  
 [in] Application to the running application list.  
  
 `pdwAppCookie`  
 [out] A cookie that is used to remove the application from the machine debug manager.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method is called by the process debug manager whenever `IProcessDebugManager::AddApplication` is called.  
  
## See also  
 [IMachineDebugManager Interface](../../winscript/reference/imachinedebugmanager-interface.md)   
 [IMachineDebugManager::RemoveApplication](../../winscript/reference/imachinedebugmanager-removeapplication.md)   
 [IProcessDebugManager::AddApplication](../../winscript/reference/iprocessdebugmanager-addapplication.md)