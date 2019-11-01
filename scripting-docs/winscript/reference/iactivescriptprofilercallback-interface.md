---
title: "IActiveScriptProfilerCallback Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 76f9164b-b086-4b29-ac79-76f9c76f1d11
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerCallback Interface
Provides methods that are used by the scripting engine to notify a profiler object when events occur. This interface is implemented by the profiler object.  
  
## Methods  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptProfilerCallback::Initialize](../../winscript/reference/iactivescriptprofilercallback-initialize.md)|Called to initialize the profiler object whenever profiling is started on a scripting engine.|  
|[IActiveScriptProfilerCallback::Shutdown](../../winscript/reference/iactivescriptprofilercallback-shutdown.md)|Called to free and release the profiler object whenever profiling is stopped on a scripting engine.|  
|[IActiveScriptProfilerCallback::ScriptCompiled](../../winscript/reference/iactivescriptprofilercallback-scriptcompiled.md)|Notifies the profiler object that the scripting engine compiled the script.|  
|[IActiveScriptProfilerCallback::FunctionCompiled](../../winscript/reference/iactivescriptprofilercallback-functioncompiled.md)|Notifies the profiler object that the scripting engine encountered a function when compiling a script.|  
|[IActiveScriptProfilerCallback::OnFunctionEnter](../../winscript/reference/iactivescriptprofilercallback-onfunctionenter.md)|Notifies the profiler object that the scripting engine is about to execute a function call that is not a call into the Document Object Model (DOM).|  
|[IActiveScriptProfilerCallback::OnFunctionExit](../../winscript/reference/iactivescriptprofilercallback-onfunctionexit.md)|Notifies the profiler object that the scripting engine finished executing a function call that is not a call into the DOM.|  
  
## Remarks  
 Notification of function calls into the Document Object Model (DOM) is provided by the [IActiveScriptProfilerCallback2 Interface](../../winscript/reference/iactivescriptprofilercallback2-interface.md).  
  
> [!NOTE]
> To add the ability to start and stop profiling when a script is running, call the following methods. By using these methods, you can obtain the complete call stack if [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is running when you start or stop profiling.  
> 
> - Call [IActiveScriptProfilerControl2::CompleteProfilerStart](../../winscript/reference/iactivescriptprofilercontrol2-completeprofilerstart.md) to notify the profiler that you have started profiling.  
>   - Call [IActiveScriptProfilerControl2::PrepareProfilerStop](../../winscript/reference/iactivescriptprofilercontrol2-prepareprofilerstop.md) to notify the profiler that you will soon stop profiling.  
  
## See also  
 [Active Script Profiler Interfaces](../../winscript/reference/active-script-profiler-interfaces.md)