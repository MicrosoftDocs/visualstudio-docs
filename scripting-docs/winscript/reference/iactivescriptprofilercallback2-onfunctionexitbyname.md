---
title: "IActiveScriptProfilerCallback2::OnFunctionExitByName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptProfilerCallback2::OnFunctionExitByName"
ms.assetid: a6ddead4-e66d-4789-b778-84e5c343f908
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback2::OnFunctionExitByName
Notifies the profiler object that the scripting engine finished running a Document Object Model (DOM) function call.  
  
## Syntax  
  
```cpp
HRESULT OnFunctionExitByName(  
    [in] [string] const WCHAR *pwszFunctionName,  
    [in] PROFILER_SCRIPT_TYPE scriptType);  
  
```  
  
#### Parameters  
 `pwszFunctionName`  
 [in] The name of the function that the scripting engine finished running.  
  
 `scriptType`  
 [in] The type of the function. For descriptions of valid values, see [PROFILER_SCRIPT_TYPE Enumeration](../../winscript/reference/profiler-script-type-enumeration.md).  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.  
  
## Remarks  
 For DOM calls, the scripting engine calls this method instead of calling [IActiveScriptProfilerCallback::OnFunctionExit](../../winscript/reference/iactivescriptprofilercallback-onfunctionexit.md). This is due to the large number of unique methods and properties in the DOM.  
  
## See also  
 [IActiveScriptProfilerCallback2::OnFunctionEnterByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionenterbyname.md)   
 [IActiveScriptProfilerCallback2 Interface](../../winscript/reference/iactivescriptprofilercallback2-interface.md)