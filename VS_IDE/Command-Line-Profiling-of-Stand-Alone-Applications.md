---
title: "Command-Line Profiling of Stand-Alone Applications"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a47f2bf2-186d-4120-bb79-34e2f3a1ee42
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Command-Line Profiling of Stand-Alone Applications
This section describes the procedures and options for collecting performance data for stand-alone (client) applications by using the Visual Studio Profiling Tools from the command line.  
  
## Common Tasks  
  
|Task|Related content|  
|----------|---------------------|  
|**Collect application statistics:** Use the sampling method to collect performance statistics. Sampling data is useful for analyzing CPU utilization issues and for understanding the general performance characteristics of an application.|-   [Collecting Application Statistics Using Sampling](../VS_IDE/Collecting-Application-Statistics-for-Stand-Alone-Applications-by-Using-the-Profiler-Command-Line.md)|  
|**Collect detailed timing data:** Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing I/O issues and for fine-grained analysis of application scenarios.|-   [Collecting Detailed Timing Data Using Instrumentation](../VS_IDE/Collecting-Detailed-Timing-Data-for-a-Stand-Alone-Application-by-Using-the-Profiler-Command-Line.md)|  
|**Collect .NET memory data:** Use sampling or instrumentation to collect .NET memory allocation data that shows you the size and number of allocated objects. You can also collect object lifetime data that shows you the size and number of objects that are reclaimed in each garbage collection generation.|-   [Collecting .NET Framework Memory Data](../VS_IDE/Collecting-.NET-Framework-Memory-Data-for-Stand-Alone-Applications-by-Using-the-Profiler-Command-Line.md)|  
|**Collect concurrency data:** Use the concurrency method to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped I/O, and other system events.|-   [Collecting Concurrency Data](../VS_IDE/Collecting-Concurrency-Data-for-Stand-Alone-Applications-by-Using-the-Profiler-Command-Line.md)|  
|**Add tier-interaction data:** You can add performance data about synchronous ADO.NET calls that the application made to a Microsoft SQL Server database. Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools.|-   [Collecting tier interaction data](../VS_IDE/Adding-tier-interaction-data-from-the-command-line.md)|  
|**Try it out:** Use step-by-step procedures to profile a sample client application by using the sampling or instrumentation method.|-   [Walkthrough: Command-Line Profiling Using Sampling](../VS_IDE/Walkthrough--Command-Line-Profiling-Using-Sampling.md)<br />-   [Walkthrough: Command-Line Profiling Using Instrumentation](../VS_IDE/Walkthrough--Command-Line-Profiling-Using-Instrumentation.md)|  
  
## Related Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile ASP.NET applications**|-   [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)|  
|**Profile services**|-   [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)|