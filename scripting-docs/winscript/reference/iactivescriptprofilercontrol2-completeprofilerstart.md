---
title: "IActiveScriptProfilerControl2::CompleteProfilerStart | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptProfilerControl2::CompleteProfilerStart"
ms.assetid: e14d94a2-39d3-40a1-84d9-6300fbe2b339
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl2::CompleteProfilerStart
Notifies the profiler that you have started profiling on all applicable scripting engines. By using this method, you can obtain the complete call stack if [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is running when you start profiling.  
  
## Syntax  
  
```cpp
HRESULT CompleteProfilerStart();  
```  
  
#### Parameters  
 The method does not take any parameters.  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return value|Meaning|  
|------------------|-------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|Profiling cannot be started.|  
|`S_FALSE`|Profiling was started when a script was not running.|  
|`ACTIVPROF_E_PROFILER_ABSENT`|Profiling is not enabled. No callback has been set.|  
|`E_OUTOFMEMORY`|The call stack cannot be obtained because of an out-of-memory condition.|  
  
## Remarks  
 Calling `IActiveScriptProfilerControl2::CompleteProfilerStart` ensures that events for functions already in the call stack are sent. This method has to be called after profiling starts on any scripting engine that is on the current tab. The method can be called for any scripting engine.  
  
## See also  
 [IActiveScriptProfilerControl2::PrepareProfilerStop](../../winscript/reference/iactivescriptprofilercontrol2-prepareprofilerstop.md)   
 [IActiveScriptProfilerControl2 Interface](../../winscript/reference/iactivescriptprofilercontrol2-interface.md)