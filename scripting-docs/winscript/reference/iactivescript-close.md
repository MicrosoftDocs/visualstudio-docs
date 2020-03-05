---
title: "IActiveScript::Close | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.Close"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_Close"
ms.assetid: cc7dd63b-1d7e-410a-857b-09ea3aade275
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::Close
Causes the scripting engine to abandon any currently loaded script, lose its state, and release any interface pointers it has to other objects, thus entering a closed state. Event sinks, immediately executed script text, and macro invocations that are already in progress are completed before the state changes (use [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md) to cancel a running script thread). This method must be called by the creating host before the interface is released to prevent circular reference problems.  
  
## Syntax  
  
```cpp
HRESULT Close(void);  
```  
  
## Return Value  
 Returns one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|`S_OK`|Success.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine was already in the closed state).|  
|`OLESCRIPT_S_PENDING`|The method was queued successfully, but the state has not changed yet. When the state changes, the site is to be called back on the [IActiveScriptSite::OnStateChange](../../winscript/reference/iactivescriptsite-onstatechange.md) method.|  
|`S_FALSE`|The method succeeded, but the script has already been closed.|  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)