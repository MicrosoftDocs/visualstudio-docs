---
title: "IActiveScriptProfilerCallback3 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: dbd39a4a-457e-4866-a86c-fa4da208121b
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback3 Interface
Provides a method to notify the profiler that the profiled executions are happening in the context of a web worker.  
  
## Syntax  
  
```cpp
interface IActiveScriptProfilerCallback3 : IActiveScriptProfilerCallback2  
```  
  
## Methods  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptProfilerCallback3::SetWebWorkerId Method](../../winscript/reference/iactivescriptprofilercallback3-setwebworkerid-method.md)|Notifies the profiler about the worker ID to use for this profiling session.|  
  
## See also  
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)   
 [IActiveScriptProfilerCallback2 Interface](../../winscript/reference/iactivescriptprofilercallback2-interface.md)