---
title: "IActiveScriptProfilerCallback3::SetWebWorkerId Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 47744746-1276-441e-ab60-2a78f550e8e2
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback3::SetWebWorkerId Method
Notifies the profiler about the worker ID to use for this profiling session. If the function is not executing in the context of the page, then this method is not invoked. The value of `webWorkerId` increments by 1 for every worker, starting at 1. The ID values are not intended to be stable beyond a session, and correspond only to the order in which the workers were created.  
  
## Syntax  
  
```cpp
HRESULT SetWebWorkerId([in] DWORD webWorkerId);  
```  
  
#### Parameters  
 `webWorkerId`  
 The web worker ID.  
  
## Return Value  
 The return value of this method is ignored by the scripting engine.