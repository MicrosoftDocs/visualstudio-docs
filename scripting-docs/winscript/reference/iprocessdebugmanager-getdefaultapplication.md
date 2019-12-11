---
title: "IProcessDebugManager::GetDefaultApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IProcessDebugManager.GetDefaultApplication"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IProcessDebugManager::GetDefaultApplication"
ms.assetid: 6c991faa-ea40-4d18-a1b8-6e7d0de6dd43
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProcessDebugManager::GetDefaultApplication
Returns a default application object for the current process.  
  
## Syntax  
  
```cpp
HRESULT GetDefaultApplication(  
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
 This method creates a new debug application object and adds it to the running application list, if necessary.  
  
 Language engines should use the application specified by the `GetDefaultApplication` method if they are running on a host that does not provide an application.  
  
## See also  
 [IProcessDebugManager Interface](../../winscript/reference/iprocessdebugmanager-interface.md)