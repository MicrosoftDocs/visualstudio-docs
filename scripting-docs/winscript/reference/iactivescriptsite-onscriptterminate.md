---
title: "IActiveScriptSite::OnScriptTerminate | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.OnScriptTerminate"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_OnScriptTerminate"
ms.assetid: 3301ddf4-5929-404c-81d3-1a720e589008
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::OnScriptTerminate
Informs the host that the script has completed execution.  
  
## Syntax  
  
```cpp
HRESULT OnScriptTerminate(  
    VARIANT *pvarResult,   // address of script results  
    EXCEPINFO *pexcepinfo  // address of structure with exception information  
);  
```  
  
#### Parameters  
 `pvarResult`  
 [in] Address of a variable that contains the script result, or `NULL` if the script produced no result.  
  
 `pexcepinfo`  
 [in] Address of an `EXCEPINFO` structure that contains exception information generated when the script terminated, or `NULL` if no exception was generated.  
  
## Return Value  
 Returns `S_OK` if successful.  
  
## Remarks  
 The scripting engine calls this method before the call to the [IActiveScriptSite::OnStateChange](../../winscript/reference/iactivescriptsite-onstatechange.md) method, with the SCRIPTSTATE_INITIALIZED flag set, is completed. This method can be used to return completion status and results to the host. Note that many script languages, which are based on sinking events from the host, have life spans that are defined by the host. In this case, this method may never be called.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)