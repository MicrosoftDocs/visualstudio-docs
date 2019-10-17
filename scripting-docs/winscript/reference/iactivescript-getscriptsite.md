---
title: "IActiveScript::GetScriptSite | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.GetScriptSite"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_GetScriptSite"
ms.assetid: 83a2a89d-93d0-4cbd-9244-91a730cb406b
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::GetScriptSite
Retrieves the site object associated with the Windows Script engine.  
  
## Syntax  
  
```cpp
HRESULT GetScriptSite(  
    REFIID iid,           // interface identifier  
    void **ppvSiteObject  // address of host site interface  
);  
```  
  
#### Parameters  
 `iid`  
 [in] Identifier of the requested interface.  
  
 `ppvSiteObject`  
 [out] Address of the location that receives the interface pointer to the host's site object.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_NOINTERFACE`|The specified interface is not supported.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`S_FALSE`|No site has been set; the `ppvSiteObject` parameter is set to `NULL`.|  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)