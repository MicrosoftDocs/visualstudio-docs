---
title: "IActiveScript::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.Clone"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_Clone"
ms.assetid: aa000b2a-7085-448d-a422-f7adac7851cb
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::Clone
Clones the current scripting engine (minus any current execution state), returning a loaded scripting engine that has no site in the current thread. The properties of this new scripting engine will be identical to the properties the original scripting engine would be in if it were transitioned back to the initialized state.  
  
## Syntax  
  
```cpp
HRESULT Clone(  
    IActiveScript **ppscript  // receives pointer to IActiveScript  
);  
```  
  
#### Parameters  
 `ppscript`  
 [out] Address of a variable that receives a pointer to the [IActiveScript](../../winscript/reference/iactivescript.md) interface of the cloned scripting engine. The host must create a site and call the [IActiveScript::SetScriptSite](../../winscript/reference/iactivescript-setscriptsite.md) method on the new scripting engine before it will be in the initialized state and, therefore, usable.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_NOTIMPL`|This method is not supported.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
  
## Remarks  
 The `IActiveScript::Clone` method is an optimization of `IPersist*::Save`, `CoCreateInstance`, and `IPersist*::Load`, so the state of the new scripting engine should be the same as if the state of the original scripting engine were saved and loaded into a new scripting engine. Named items are duplicated in the cloned scripting engine, but specific object pointers for each item are forgotten and are obtained with the [IActiveScriptSite::GetItemInfo](../../winscript/reference/iactivescriptsite-getiteminfo.md) method. This allows an identical object model with per-thread entry points (an apartment model) to be used.  
  
 This method is used for multithreaded server hosts that can run multiple instances of the same script. The scripting engine may return `E_NOTIMPL`, in which case the host can achieve the same result by duplicating the persistent state and creating a new instance of the scripting engine with an `IPersist*` interface.  
  
 This method can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) interface.  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)