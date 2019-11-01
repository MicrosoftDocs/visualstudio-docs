---
title: "IActiveScriptProfilerCallback::ScriptCompiled | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerCallback.ScriptCompiled"
apilocation: 
  - "scrobj.dll"
ms.assetid: 1bb8e9be-cbb1-4a61-b36c-805127a56ac7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback::ScriptCompiled
Notifies the profiler object that the scripting engine compiled a script. This method is called for every script that is compiled.  
  
## Syntax  
  
```cpp
HRESULT ScriptCompiled(  
    [in] PROFILER_TOKEN scriptId,  
    [in] PROFILER_SCRIPT_TYPE type,  
    [in] IUnknown *pIDebugDocumentContext);  
```  
  
#### Parameters  
 `scriptId`  
 [in] The unique ID of the script that was compiled. This ID is assigned by the scripting engine.  
  
 `type`  
 [in] The type of the script that was compiled. The values are defined in [PROFILER_SCRIPT_TYPE Enumeration](../../winscript/reference/profiler-script-type-enumeration.md).  
  
 `pIDebugDocumentContext`  
 [in] If available, a pointer to an `IUnknown` interface that the profiler must query for an [IDebugDocumentContext Interface](../../winscript/reference/idebugdocumentcontext-interface.md) pointer. Otherwise, this will be null.  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.  
  
## Remarks  
 The scripting engine can provide the document context only if this is supported by the host.  
  
## See also  
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)