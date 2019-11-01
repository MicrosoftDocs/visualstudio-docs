---
title: "IActiveScript::SetScriptSite | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.SetScriptSite"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_SetScriptSite"
ms.assetid: 47d94c32-09f8-4539-ac56-0236026f627b
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::SetScriptSite
Informs the scripting engine of the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) interface site provided by the host. Call this method before any other [IActiveScript](../../winscript/reference/iactivescript.md) interface methods is used.  
  
## Syntax  
  
```cpp
HRESULT SetScriptSite(  
    IActiveScriptSite *pScriptSite  // address of host script site  
);  
```  
  
#### Parameters  
 `pScriptSite`  
 [in] Address of the host-supplied script site to be associated with this instance of the scripting engine. The site must be uniquely assigned to this scripting engine instance; it cannot be shared with other scripting engines.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_FAIL`|An unspecified error occurred; the scripting engine was unable to finish initializing the site.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, a site was already set).|  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)