---
title: "IActiveScript::GetScriptState | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.GetScriptState"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScript_GetScriptState"
ms.assetid: 59837f7c-755d-45c4-8194-bd57638fe2e1
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::GetScriptState
Retrieves the current state of the scripting engine. This method can be called from non-base threads without resulting in a non-base callout to host objects or to the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) interface.  
  
## Syntax  
  
```cpp
HRESULT GetScriptState(  
    SCRIPTSTATE *pss  // address of structure for state information  
);  
```  
  
#### Parameters  
 `pss`  
 [out] Address of a variable that receives a value defined in the [SCRIPTSTATE Enumeration](../../winscript/reference/scriptstate-enumeration.md) enumeration. The value indicates the current state of the scripting engine associated with the calling thread.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_POINTER` if an invalid pointer was specified.  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)