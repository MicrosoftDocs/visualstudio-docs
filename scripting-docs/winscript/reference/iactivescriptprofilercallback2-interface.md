---
title: "IActiveScriptProfilerCallback2 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptProfilerCallback2 interface"
ms.assetid: 8f2e62e4-c232-4dc3-a2c0-54dd06298306
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback2 Interface
Provides methods that are used by the scripting engine to notify a profiler object when Document Object Model (DOM) events occur. This interface is implemented by the profiler object.  
  
## Methods  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptProfilerCallback2::OnFunctionEnterByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionenterbyname.md)|Notifies the profiler object that the scripting engine is going to run a DOM function call.|  
|[IActiveScriptProfilerCallback2::OnFunctionExitByName](../../winscript/reference/iactivescriptprofilercallback2-onfunctionexitbyname.md)|Notifies the profiler object that the scripting engine finished running a DOM function call.|  
  
## Remarks  
 The `IActiveScriptProfilerCallback2` interface first released with Internet Explorer 9.  
  
 Notification of function calls that are not calls into the DOM is provided by the [IActiveScriptProfilerCallback Interface](../../winscript/reference/iactivescriptprofilercallback-interface.md).  
  
> [!NOTE]
> To add the ability to start and stop profiling when a script is running, call the following methods. By using these methods, you can obtain the complete call stack if [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is running when you start or stop profiling.  
> 
> - Call [IActiveScriptProfilerControl2::CompleteProfilerStart](../../winscript/reference/iactivescriptprofilercontrol2-completeprofilerstart.md) to notify the profiler that you have started profiling.  
>   - Call [IActiveScriptProfilerControl2::PrepareProfilerStop](../../winscript/reference/iactivescriptprofilercontrol2-prepareprofilerstop.md) to notify the profiler that you will soon stop profiling.  
  
## See also  
 [Active Script Profiler Interfaces](../../winscript/reference/active-script-profiler-interfaces.md)