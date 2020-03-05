---
title: "IActiveScriptSite::OnLeaveScript | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.OnLeaveScript"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_OnLeaveScript"
ms.assetid: 79af0e22-fbe3-4fae-8a5f-7af8b857678d
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::OnLeaveScript
Informs the host that the scripting engine has returned from executing script code.  
  
## Syntax  
  
```cpp
HRESULT OnLeaveScript(void);  
```  
  
## Return Value  
 Returns `S_OK` if successful.  
  
## Remarks  
 The scripting engine must call this method before returning control to a calling application that entered the scripting engine. For example, if the script calls an object that then fires an event handled by the scripting engine, the scripting engine must call the [IActiveScriptSite::OnEnterScript](../../winscript/reference/iactivescriptsite-onenterscript.md) method before executing the event, and must call `IActiveScriptSite::OnLeaveScript` after executing the event before returning to the object that fired the event. Calls to this method can be nested. Every call to `IActiveScriptSite::OnEnterScript` requires a corresponding call to this method.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)