---
title: "IActiveScript::GetScriptThreadID | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.GetScriptThreadID"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_GetScriptThreadID"
ms.assetid: 2595d76e-30b5-429f-88b4-1d026645dd9b
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::GetScriptThreadID
Retrieves a scripting-engine-defined identifier for the thread associated with the given Win32 thread.  
  
## Syntax  
  
```cpp
HRESULT GetScriptThreadID(  
    DWORD dwWin32ThreadID,       // Win32 thread identifier.  
    SCRIPTTHREADID *pstidThread  // Receives scripting thread. identifier  
);  
```  
  
#### Parameters  
 `dwWin32ThreadID` ,  
 [in] Thread identifier of a running Win32 thread in the current process. Use the [IActiveScript::GetCurrentScriptThreadID](../../winscript/reference/iactivescript-getcurrentscriptthreadid.md) function to retrieve the thread identifier of the currently executing thread.  
  
 `pstidThread` ,  
 [out] Address of a variable that receives the script thread identifier associated with the given Win32 thread. The interpretation of this identifier is left to the scripting engine, but it can be just a copy of the Windows thread identifier. Note that if the Win32 thread terminates, this identifier becomes unassigned and may subsequently be assigned to another thread.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized) and therefore failed.|  
  
## Remarks  
 The retrieved identifier can be used in subsequent calls to script thread execution control methods such as the [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md) method.  
  
 This method can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md) interface.  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)