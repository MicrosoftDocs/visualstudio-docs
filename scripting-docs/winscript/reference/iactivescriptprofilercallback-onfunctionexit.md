---
title: "IActiveScriptProfilerCallback::OnFunctionExit | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerCallback.OnFunctionExit"
apilocation: 
  - "scrobj.dll"
ms.assetid: a5d21715-2b0b-423e-8644-f04a9e7cde3d
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback::OnFunctionExit
Notifies the profiler object that the scripting engine finished executing a function call that is not a call into the Document Object Model (DOM).  
  
## Syntax  
  
```cpp
HRESULT OnFunctionExit(  
    [in] PROFILER_TOKEN scriptId,   
    [in] PROFILER_TOKEN functionId);  
```  
  
#### Parameters  
 `scriptId`  
 [in] The unique ID of the script that the function is part of. This ID is assigned by the scripting engine.  
  
 `functionId`  
 [in] The unique ID of the function. This ID is assigned by the scripting engine.  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.  
  
## Remarks  
 For DOM calls, the scripting engine calls [IActiveScriptProfilerCallback2::OnFunctionExitByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionexitbyname.md) instead of `IActiveScriptProfilerCallback::OnFunctionExit`. This is due to the large number of unique methods and properties in the DOM.  
  
## See also  
 [IActiveScriptProfilerCallback::OnFunctionEnter](../../winscript/reference/iactivescriptprofilercallback-onfunctionenter.md)   
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)