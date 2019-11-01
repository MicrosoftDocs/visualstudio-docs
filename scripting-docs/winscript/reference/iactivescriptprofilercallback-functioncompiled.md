---
title: "IActiveScriptProfilerCallback::FunctionCompiled | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerCallback.FunctionCompiled"
apilocation: 
  - "scrobj.dll"
ms.assetid: a7e9ef17-3891-4731-9d08-c37bc489be61
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback::FunctionCompiled
Notifies the profiler object that the scripting engine encountered a function when compiling a script.  
  
## Syntax  
  
```cpp
HRESULT FunctionCompiled(  
    [in] PROFILER_TOKEN functionId,  
    [in] PROFILER_TOKEN scriptId,  
    [in] [string] const WCHAR *pwszFunctionName,  
    [in] [string] const WCHAR *pwszFunctionNameHint,  
    [in] IUnknown *pIDebugDocumentContext);  
```  
  
#### Parameters  
 `functionId`  
 [in] The unique ID of the function. This ID is assigned by the scripting engine.  
  
 `scriptId`  
 [in] The unique ID of the script that the function is part of.  
  
 `pwszFunctionName`  
 [in] The name of the function, or null for an anonymous function.  
  
 `pwszFunctionNameHint`  
 [in] The inferred name of the function, or null if the scripting engine does not infer any name.  
  
 `pIDebugDocumentContext`  
 [in] If available, the pointer to an `IUnknown` interface that the profiler must query for an [IDebugDocumentContext Interface](../../winscript/reference/idebugdocumentcontext-interface.md) pointer. Otherwise, null.  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.  
  
## Remarks  
 The scripting engine can provide the document context only if this is supported by the host.  
  
## See also  
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)