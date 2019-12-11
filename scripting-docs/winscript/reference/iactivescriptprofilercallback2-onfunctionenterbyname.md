---
title: "IActiveScriptProfilerCallback2::OnFunctionEnterByName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptProfilerCallback2::OnFunctionEnterByName"
ms.assetid: 24b1593a-97fc-4d70-9b85-ec86fb59f987
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback2::OnFunctionEnterByName
Notifies the profiler object that the scripting engine is going to execute a Document Object Model (DOM) function call.  
  
## Syntax  
  
```cpp
HRESULT OnFunctionEnterByName(  
    [in] [string] const WCHAR *pwszFunctionName,  
    [in] PROFILER_SCRIPT_TYPE scriptType);  
```  
  
#### Parameters  
 `pwszFunctionName`  
 [in] The name of the function that the scripting engine is going to execute.  
  
 `scriptType`  
 [in] The type of the function. For descriptions of valid values, see [PROFILER_SCRIPT_TYPE Enumeration](../../winscript/reference/profiler-script-type-enumeration.md).  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.  
  
## Remarks  
 For DOM calls, the scripting engine calls this method instead of calling [IActiveScriptProfilerCallback::OnFunctionEnter](../../winscript/reference/iactivescriptprofilercallback-onfunctionenter.md). This is due to the large number of unique methods and properties in the DOM.  
  
## See also  
 [IActiveScriptProfilerCallback2::OnFunctionExitByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionexitbyname.md)   
 [IActiveScriptProfilerCallback2 Interface](../../winscript/reference/iactivescriptprofilercallback2-interface.md)