---
title: "IActiveScriptSiteDebug::GetApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteDebug.GetApplication"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteDebug::GetApplication"
ms.assetid: 4400f1b1-3108-4a71-b1f1-43586fe1227c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebug::GetApplication
Returns the debug application object associated with this script site.  
  
## Syntax  
  
```cpp
HRESULT GetApplication(  
   IDebugApplication**  ppda  
);  
```  
  
#### Parameters  
 `ppda`  
 [out] Pointer to the debug application object associated with the script site.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_NOTIMPL`|The host does not directly support debugging.|  
  
## Remarks  
 The `GetApplication` method provides a way for a smart host to define the application object to which each script belongs. Script engines should attempt to call this method to get their containing application and resort to `IProcessDebugManager::GetDefaultApplication` if this fails.  
  
## See also  
 [IActiveScriptSiteDebug Interface](../../winscript/reference/iactivescriptsitedebug-interface.md)   
 [IProcessDebugManager::GetDefaultApplication](../../winscript/reference/iprocessdebugmanager-getdefaultapplication.md)