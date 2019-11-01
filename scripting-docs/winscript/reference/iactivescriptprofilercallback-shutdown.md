---
title: "IActiveScriptProfilerCallback::Shutdown | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerCallback.Shutdown"
apilocation: 
  - "scrobj.dll"
ms.assetid: 1281bf3c-d7d8-4ff5-9d8a-d1761fdb262e
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback::Shutdown
Called to inform the profiler object whenever profiling is stopped on a scripting engine. This way, the profiler object can call its cleanup routines, if required. This method is also called by the scripting engine when the scripting engine is shutting down, or when a call to [IActiveScriptProfilerCallback::Initialize](../../winscript/reference/iactivescriptprofilercallback-initialize.md) fails.  
  
## Syntax  
  
```cpp
HRESULT Shutdown(  
    [in] HRESULT hrReason);  
```  
  
#### Parameters  
 `hrReason`  
 [in] The reason for shutting down. If the scripting engine is shutting down, `S_OK` is passed. If the call to [IActiveScriptProfilerCallback::Initialize](../../winscript/reference/iactivescriptprofilercallback-initialize.md) returns a failure HRESULT, the HRESULT is passed. Otherwise, this value is retrieved from [IActiveScriptProfilerControl::StopProfiling](../../winscript/reference/iactivescriptprofilercontrol-stopprofiling.md).  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.  
  
## See also  
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)