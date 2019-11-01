---
title: "IActiveScript::GetCurrentScriptThreadID | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.GetCurrentScriptThreadID"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_GetCurrentScriptThreadID"
ms.assetid: b09e8b48-4209-480e-8b71-e99ee9ae2e17
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::GetCurrentScriptThreadID
Retrieves a scripting-engine-defined identifier for the currently executing thread. The identifier can be used in subsequent calls to script thread execution-control methods such as the [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md) method.  
  
## Syntax  
  
```cpp
HRESULT GetCurrentScriptThreadID(  
    SCRIPTTHREADID *pstidThread  // receives scripting thread identifier  
);  
```  
  
#### Parameters  
 `pstidThread`  
 [out] Address of a variable that receives the script thread identifier associated with the current thread. The interpretation of this identifier is left to the scripting engine, but it can be just a copy of the Windows thread identifier. If the Win32 thread terminates, this identifier becomes unassigned and can subsequently be assigned to another thread.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_POINTER` if an invalid pointer was specified.  
  
## Remarks  
 This method can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) interface.  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)