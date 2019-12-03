---
title: "IActiveScriptSiteDebug32::GetApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 533d770d-06a4-4693-873e-255c9c6f0df0
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptSiteDebug32::GetApplication
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
 [IActiveScriptSiteDebug32 Interface](../../winscript/reference/iactivescriptsitedebug32-interface.md)   
 [IProcessDebugManager::GetDefaultApplication](../../winscript/reference/iprocessdebugmanager-getdefaultapplication.md)