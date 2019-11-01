---
title: "IActiveScriptProfilerControl::StopProfiling | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerControl.StopProfiling"
apilocation: 
  - "scrobj.dll"
ms.assetid: 23b46ed6-a398-44c0-bc49-bf122e697cfe
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl::StopProfiling
Stops profiling on the scripting engine. This method calls [IActiveScriptProfilerCallback::Shutdown](../../winscript/reference/iactivescriptprofilercallback-shutdown.md) on the profiler object and then releases it.  
  
## Syntax  
  
```cpp
HRESULT StopProfiling(  
    [in] HRESULT hrShutdownReason);  
```  
  
#### Parameters  
 `hrShutdownReason`  
 [in] The HRESULT to be passed as a parameter to the [IActiveScriptProfilerCallback::Shutdown](../../winscript/reference/iactivescriptprofilercallback-shutdown.md) method of the profiler object.  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|The method succeeded.|  
|`ACTIVPROF_E_PROFILER_ABSENT`|Profiling is not enabled.|  
  
## See also  
 [IActiveScriptProfilerControl Interface](../../winscript/reference/iactivescriptprofilercontrol-interface.md)