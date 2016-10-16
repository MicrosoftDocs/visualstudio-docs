---
title: "Controlling Data Collection"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "advanced tasks for profiling tools"
  - "profiling tools, advanced tasks"
ms.assetid: e713ad63-b948-46f3-8db9-59b30922ebe5
caps.latest.revision: 27
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Controlling Data Collection
[!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools enable you to control when profiling data is collected during a performance session and to specify the functions that are profiled. This section describes how to start and stop data collection from the **Performance Explorer** and **Data Collection Control** windows and how to limit the objects for which profiling data is collected.  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Start and stop profiling:** You can start to profile an application when the application starts, or you can attach the profiler to a process that is already running. When the target application is running, you can pause and resume data collection. You end a profiling session by closing the target application or detaching the profiler from a running process.|-   [How to: Start and End Performance Data Collection](../profiling/how-to--start-and-end-performance-data-collection.md)<br />-   [How to: Attach and Detach Performance Tools to Running Processes](../profiling/how-to--attach-and-detach-performance-tools-to-running-processes.md)<br />-   [How to: Pause and Resume Performance Data Collection](../profiling/how-to--pause-and-resume-performance-data-collection.md)|  
|**Configure instrumentation profiling to limit the collected data:** You can use performance session configuration properties to limit the data that is collected in profiling runs that use the instrumentation method. You can include or exclude specific .dll files, namespaces, classes, and functions. You can also exclude functions that do not meet a size threshold that you specify.|-   [How to: Limit Instrumentation to Specific DLLs](../profiling/how-to--limit-instrumentation-to-specific-dlls.md)<br />-   [How to: Limit Instrumentation to Specific Functions](../profiling/how-to--limit-instrumentation-to-specific-functions.md)<br />-   [How to: Exclude or Include Short Functions from Instrumentation](../profiling/how-to--exclude-or-include-short-functions-from-instrumentation.md)|  
  
## Related Sections  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)  
  
## See Also  
 [Performance Explorer](../profiling/performance-explorer.md)