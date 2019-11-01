---
title: "IActiveScript::SetScriptState | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.SetScriptState"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_SetScriptState"
ms.assetid: f2b2700c-0c8d-40db-ad84-dc751c5d9bc2
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::SetScriptState
Puts the scripting engine into the given state. This method can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) interface.  
  
## Syntax  
  
```cpp
HRESULT SetScriptState(  
    SCRIPTSTATE ss  // identifier of new state  
);  
```  
  
#### Parameters  
 `ss`  
 [in] Sets the scripting engine to the given state. Can be one of the values defined in the [SCRIPTSTATE Enumeration](../../winscript/reference/scriptstate-enumeration.md) enumeration.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_FAIL`|The scripting engine does not support the transition back to the initialized state. The host must discard this scripting engine and create, initialize, and load a new scripting engine to achieve the same effect.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized) and therefore failed.|  
|`OLESCRIPT_S_PENDING`|The method was queued successfully, but the state has not changed yet. When the state changes, the site will be called back through the [IActiveScriptSite::OnStateChange](../../winscript/reference/iactivescriptsite-onstatechange.md) method.|  
|`S_FALSE`|The method succeeded, but the script was already in the given state.|  
  
## Remarks  
 For more information about scripting engine states, see the Script Engine States section of [Windows Script Engines](../../winscript/windows-script-engines.md) .  
  
## See also  
 [IActiveScript::Clone](../../winscript/reference/iactivescript-clone.md)   
 [IActiveScript::GetScriptDispatch](../../winscript/reference/iactivescript-getscriptdispatch.md)   
 [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md)   
 [IActiveScriptParse::ParseScriptText](../../winscript/reference/iactivescriptparse-parsescripttext.md)   
 [IActiveScriptSite::GetItemInfo](../../winscript/reference/iactivescriptsite-getiteminfo.md)