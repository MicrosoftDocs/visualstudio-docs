---
title: "IActiveScript::InterruptScriptThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.InterruptScriptThread"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_InterruptScriptThread"
ms.assetid: 2304d035-6d39-4811-acd3-8a9640fdbef6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::InterruptScriptThread
Interrupts the execution of a running script thread (an event sink, an immediate execution, or a macro invocation). This method can be used to terminate a script that is stuck (for example, in an infinite loop). It can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) method.  
  
## Syntax  
  
```cpp
HRESULT InterruptScriptThread(  
    SCRIPTTHREADID   stidThread,  // identifier of thread  
    const EXCEPINFO *pexcepinfo,  // receives error information  
    DWORD dwFlags  
);  
```  
  
#### Parameters  
 `stidThread`  
 [in] Identifier of the thread to interrupt, or one of the following special thread identifier values:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTTHREADID_ALL|All threads. The interrupt is applied to all script methods currently in progress. Note that unless the caller has requested that the script be disconnected, the next scripted event causes script code to run again by calling the [IActiveScript::SetScriptState](../../winscript/reference/iactivescript-setscriptstate.md) method with the SCRIPTSTATE_DISCONNECTED or SCRIPTSTATE_INITIALIZED flag set.|  
|SCRIPTTHREADID_BASE|The base thread; that is, the thread in which the scripting engine was instantiated.|  
|SCRIPTTHREADID_CURRENT|The currently executing thread.|  
  
 `pexcepinfo`  
 [in] Address of an `EXCEPINFO` structure containing the error information that should be reported to the aborted script.  
  
 `dwFlags`  
 [in] Option flags associated with the interruption. Can be one of these values:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTINTERRUPT_DEBUG|If supported, enter the scripting engine's debugger at the current script execution point.|  
|SCRIPTINTERRUPT_RAISEEXCEPTION|If supported by the scripting engine's language, let the script handle the exception. Otherwise, the script method is aborted and the error code is returned to the caller; that is, the event source or macro invoker.|  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)