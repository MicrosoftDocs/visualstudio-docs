---
title: "IActiveScriptProfilerCallback::Initialize | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProfilerCallback.Initialize"
apilocation: 
  - "scrobj.dll"
ms.assetid: a257111e-a50b-4962-9dd6-c893d40f6985
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback::Initialize
Called to initialize the profiler object whenever profiling is started on a scripting engine.  
  
## Syntax  
  
```cpp
HRESULT Initialize(  
    [in] DWORD dwContext);  
```  
  
#### Parameters  
 `dwContext`  
 [in] A 4-byte value that is passed to [IActiveScriptProfilerControl::StartProfiling](../../winscript/reference/iactivescriptprofilercontrol-startprofiling.md).  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 If the method cannot initialize the profiler object, it should return a failure HRESULT to notify the scripting engine. In this case, the scripting engine should directly call [IActiveScriptProfilerCallback::Shutdown](../../winscript/reference/iactivescriptprofilercallback-shutdown.md), passing the HRESULT in the parameter, and then release the profiler object.  
  
## See also  
 [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md)