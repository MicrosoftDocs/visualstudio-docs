---
title: "SCRIPTTHREADID Constants | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "SCRIPTTHREADID"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "SCRIPTTHREADID"
ms.assetid: 1df9940c-ad0c-42d8-96b9-6a6abe2382e6
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTTHREADID Constants
Used to specify the type of thread.  
  
## Syntax  
  
```cpp
typedef DWORD SCRIPTTHREADID;  
```  
  
## Constants  
  
|Constant|Value|Meaning|  
|--------------|-----------|-------------|  
|SCRIPTTHREADID_CURRENT|0xFFFFFFFD|The currently executing thread.|  
|SCRIPTTHREADID_BASE|0xFFFFFFFE|The base thread; that is, the thread in which the scripting engine was instantiated.|  
|SCRIPTTHREADID_ALL|0xFFFFFFFF|All threads.|  
  
## Remarks  
 The `SCRIPTTHREADID` type is used by `IActiveScript::GetCurrentScriptThreadID`, `IActiveScript::GetScriptThreadID`, `IActiveScript::GetScriptThreadState`, and `IActiveScript::InterruptScriptThread`, but the constants can only be used by `IActiveScript::GetScriptThreadState` and `IActiveScript::InterruptScriptThread`.  
  
## See also  
 [IActiveScript::GetCurrentScriptThreadID](../../winscript/reference/iactivescript-getcurrentscriptthreadid.md)   
 [IActiveScript::GetScriptThreadID](../../winscript/reference/iactivescript-getscriptthreadid.md)   
 [IActiveScript::GetScriptThreadState](../../winscript/reference/iactivescript-getscriptthreadstate.md)   
 [IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md)