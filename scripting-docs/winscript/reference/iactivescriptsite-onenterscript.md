---
title: "IActiveScriptSite::OnEnterScript | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.OnEnterScript"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_OnEnterScript"
ms.assetid: 1ed9178c-fe80-41c4-b74d-23b85f9cddbf
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::OnEnterScript
Informs the host that the scripting engine has begun executing the script code.  
  
## Syntax  
  
```cpp
HRESULT OnEnterScript(void);  
```  
  
## Return Value  
 Returns `S_OK` if successful.  
  
## Remarks  
 The scripting engine must call this method on every entry or reentry into the scripting engine. For example, if the script calls an object that then fires an event handled by the scripting engine, the scripting engine must call `IActiveScriptSite::OnEnterScript` before executing the event, and must call the [IActiveScriptSite::OnLeaveScript](../../winscript/reference/iactivescriptsite-onleavescript.md) method after executing the event but before returning to the object that fired the event. Calls to this method can be nested. Every call to this method requires a corresponding call to `IActiveScriptSite::OnLeaveScript`.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)