---
title: "IActiveScriptProfilerControl2::PrepareProfilerStop | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptProfilerControl2::PrepareProfilerStop"
ms.assetid: e43a63bc-c44f-44a8-9db4-29062b9e6a16
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl2::PrepareProfilerStop
Notifies the profiler that you are going to stop profiling on all applicable scripting engines. By using this method, you can obtain the complete call stack if [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is running when you stop profiling.  
  
## Syntax  
  
```cpp
HRESULT PrepareProfilerStop();  
```  
  
#### Parameters  
 The method does not take any parameters.  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return value|Meaning|  
|------------------|-------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|Profiling could not be started.|  
|`S_FALSE`|Profiling was stopped when a script was not running.|  
|`ACTIVPROF_E_PROFILER_ABSENT`|Profiling is not enabled.|  
  
## Remarks  
 Calling `IActiveScriptProfilerControl2::PrepareProfilerStop` ensures that events for functions in the call stack are sent. This method has to be called before you stop profiling on any scripting engine that is on the current tab. The method can be called for any scripting engine.  
  
## See also  
 [IActiveScriptProfilerControl2::CompleteProfilerStart](../../winscript/reference/iactivescriptprofilercontrol2-completeprofilerstart.md)   
 [IActiveScriptProfilerControl2 Interface](../../winscript/reference/iactivescriptprofilercontrol2-interface.md)