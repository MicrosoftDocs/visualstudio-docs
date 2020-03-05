---
title: "IActiveScriptProfilerControl Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 1448b394-9743-41b5-8eb9-5026a45773a4
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl Interface
Implemented by the scripting engine that supports profiling. Typically, an object that implements the `IActiveScriptProfilerControl` also implements the [IActiveScript](../../winscript/reference/iactivescript.md) interface. In this case, you can obtain a handle to the `IActiveScriptProfilerControl` interface by calling the `IUnknown::QueryInterface` method on the object. The interface provides the necessary methods for stopping and starting profiling on the scripting engine.  
  
## Methods  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptProfilerControl::StartProfiling](../../winscript/reference/iactivescriptprofilercontrol-startprofiling.md)|Starts profiling on the scripting engine.|  
|[IActiveScriptProfilerControl::SetProfilerEventMask](../../winscript/reference/iactivescriptprofilercontrol-setprofilereventmask.md)|Sets the profiler event mask in the scripting engine.|  
|[IActiveScriptProfilerControl::StopProfiling](../../winscript/reference/iactivescriptprofilercontrol-stopprofiling.md)|Stops profiling on the scripting engine.|  
  
## See also  
 [Active Script Profiler Interfaces](../../winscript/reference/active-script-profiler-interfaces.md)