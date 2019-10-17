---
title: "IActiveScriptProfilerCallback::OnFunctionEnter | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerCallback.OnFunctionEnter"
apilocation: 
  - "scrobj.dll"
ms.assetid: 12dab2b4-df4e-444d-99cb-25e1c278e6e8
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback::OnFunctionEnter
Notifies the profiler object that the scripting engine is about to execute a function call that is not a call into the Document Object Model (DOM).  
  
## Syntax  
  
```cpp
HRESULT OnFunctionEnter(  
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
 For DOM calls, the scripting engine calls [IActiveScriptProfilerCallback2::OnFunctionEnterByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionenterbyname.md) instead of `IActiveScriptProfilerCallback::OnFunctionEnter`. This is due to the large number of unique methods and properties in the DOM.  
  
## See also  
 [IActiveScriptProfilerCallback::OnFunctionExit](../../winscript/reference/iactivescriptprofilercallback-onfunctionexit.md)   
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)