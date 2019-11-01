---
title: "IActiveScriptSiteDebugEx::OnCanNotJITScriptErrorDebug | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteDebugEx.OnCanNotJITScriptErrorDebug"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteDebugEx::OnCanNotJITScriptErrorDebug"
ms.assetid: 83f81476-bf12-47f2-897d-1d37d21137d4
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebugEx::OnCanNotJITScriptErrorDebug
Informs the host about a script run-time error when the Process Debug Manager does not find a Just In Time script debugger.  
  
 To implement a debugger in your host, you should handle [IActiveScriptSiteDebug::OnScriptErrorDebug](../../winscript/reference/iactivescriptsitedebug-onscripterrordebug.md). Based on a user action, the host can either attach the debugger and return, or return the starting of the debugger in the OnScriptErrorDebug `pfEnterDebugger` parameter. You should also implement this interface to get the notification about the run-time error even if there are no external debuggers that can be interpreted by the Process Debug Manager.  
  
## Syntax  
  
```cpp
HRESULT OnCanNotJITScriptErrorDebug(  
   IActiveScriptErrorDebug*  pErrorDebug  
   BOOL *pfCallOnScriptErrorWhenContinuing  
);  
```  
  
#### Parameters  
 `pErrorDebug`  
 [in] The run-time error that occurred.  
  
 `pfCallOnScriptErrorWhenContinuingt`  
 [out] Whether to call [IActiveScriptSiteDebug::OnScriptErrorDebug](../../winscript/reference/iactivescriptsitedebug-onscripterrordebug.md) if the user decides to continue without debugging.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 You should also implement this interface to get a notification.  
  
## See also  
 [IActiveScriptSiteDebugEx Interface](../../winscript/reference/iactivescriptsitedebugex-interface.md)