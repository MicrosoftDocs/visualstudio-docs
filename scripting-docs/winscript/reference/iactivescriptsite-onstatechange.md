---
title: "IActiveScriptSite::OnStateChange | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.OnStateChange"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_OnStateChange"
ms.assetid: 3e9c5cbe-ca8e-426a-84fd-04e9c2daac7e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::OnStateChange
Informs the host that the scripting engine has changed states.  
  
## Syntax  
  
```cpp
HRESULT OnStateChange(  
    SCRIPTSTATE ssScriptState  // new state of engine  
);  
```  
  
#### Parameters  
 `ssScriptState`  
 [in] Value that indicates the new script state. See the [IActiveScript::GetScriptState](../../winscript/reference/iactivescript-getscriptstate.md) method for a description of the states.  
  
## Return Value  
 Returns `S_OK` if successful.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)