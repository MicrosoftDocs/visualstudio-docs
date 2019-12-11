---
title: "IActiveScriptSite::OnScriptError | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.OnScriptError"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_OnScriptError"
ms.assetid: 5c9c85cc-21ad-4232-be83-a24cc7570108
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::OnScriptError
Informs the host that an execution error occurred while the engine was running the script.  
  
## Syntax  
  
```cpp
HRESULT OnScriptError(  
    IActiveScriptError *pase  // address of error interface  
);  
```  
  
#### Parameters  
 `pase`  
 [in] Address of the error object's [IActiveScriptError](../../winscript/reference/iactivescripterror.md) interface. A host can use this interface to obtain information about the execution error.  
  
## Return Value  
 Returns `S_OK` if the error was correctly handled, or an OLE defined error code otherwise.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)