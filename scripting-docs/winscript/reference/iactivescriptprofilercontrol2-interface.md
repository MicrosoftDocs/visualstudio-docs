---
title: "IActiveScriptProfilerControl2 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptProfilerControl2 interface"
ms.assetid: 89455276-5c23-420b-a7e0-804a32635291
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl2 Interface
Provides methods that add the ability to start or stop profiling when a script is running.  
  
## Methods  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptProfilerControl2::CompleteProfilerStart](../../winscript/reference/iactivescriptprofilercontrol2-completeprofilerstart.md)|Notifies the profiler that you have started profiling on all applicable scripting engines. This enables you to obtain the complete call stack if [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is running when you start profiling.|  
|[IActiveScriptProfilerControl2::PrepareProfilerStop](../../winscript/reference/iactivescriptprofilercontrol2-prepareprofilerstop.md)|Notifies the profiler that you are going to stop profiling on all applicable scripting engines. This enables you to obtain the complete call stack if [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is running when you stop profiling.|  
  
## See also  
 [IActiveScriptProfilerControl Interface](../../winscript/reference/iactivescriptprofilercontrol-interface.md)   
 [Active Script Profiler Interfaces](../../winscript/reference/active-script-profiler-interfaces.md)