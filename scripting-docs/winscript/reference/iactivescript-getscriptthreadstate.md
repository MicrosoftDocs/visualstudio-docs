---
title: "IActiveScript::GetScriptThreadState | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.GetScriptThreadState"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_GetScriptThreadState"
ms.assetid: 7cac94d0-436e-4c29-895b-0c4afa0b3ccc
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::GetScriptThreadState
Retrieves the current state of a script thread.  
  
## Syntax  
  
```cpp
HRESULT GetScriptThreadState(  
    SCRIPTTHREADID stidThread,    // identifier of script thread  
    SCRIPTTHREADSTATE *pstsState  // receives state flag  
);  
```  
  
#### Parameters  
 `stidThread`  
 [in] Identifier of the thread for which the state is desired, or one of the following special thread identifiers:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTTHREADID_BASE|The base thread; that is, the thread in which the scripting engine was instantiated.|  
|SCRIPTTHREADID_CURRENT|The currently executing thread.|  
  
 `pstsState`  
 [out] Address of a variable that receives the state of the indicated thread. The state is indicated by one of the named constant values defined by the [SCRIPTTHREADSTATE Enumeration](../../winscript/reference/scriptthreadstate-enumeration.md) enumeration. If this parameter does not identify the current thread, the state may change at any time.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
  
## Remarks  
 This method can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) interface.  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)