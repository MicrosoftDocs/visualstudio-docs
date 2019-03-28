---
title: "Command-Line Profiling of Stand-Alone Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "profillng tools,stand-alone applications"
  - "profling stand-alone applications"
ms.assetid: a47f2bf2-186d-4120-bb79-34e2f3a1ee42
caps.latest.revision: 21
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Command-Line Profiling of Stand-Alone Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This section describes the procedures and options for collecting performance data for stand-alone (client) applications by using the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools from the command line.  
  
## Common Tasks  
  
|Task|Related content|  
|----------|---------------------|  
|**Collect application statistics:** Use the sampling method to collect performance statistics. Sampling data is useful for analyzing CPU utilization issues and for understanding the general performance characteristics of an application.|-   [Collecting Application Statistics Using Sampling](../profiling/collecting-application-statistics-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Collect detailed timing data:** Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing I/O issues and for fine-grained analysis of application scenarios.|-   [Collecting Detailed Timing Data Using Instrumentation](../profiling/collecting-detailed-timing-data-for-a-stand-alone-application-by-using-the-profiler-command-line.md)|  
|**Collect .NET memory data:** Use sampling or instrumentation to collect .NET memory allocation data that shows you the size and number of allocated objects. You can also collect object lifetime data that shows you the size and number of objects that are reclaimed in each garbage collection generation.|-   [Collecting .NET Framework Memory Data](../profiling/collecting-dotnet-framework-memory-data-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Collect concurrency data:** Use the concurrency method to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped I/O, and other system events.|-   [Collecting Concurrency Data](../profiling/collecting-concurrency-data-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Add tier-interaction data:** You can add performance data about synchronous ADO.NET calls that the application made to a Microsoft [!INCLUDE[ssNoVersion](../includes/ssnoversion-md.md)] database. Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools.|-   [Collecting tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)|  
|**Try it out:** Use step-by-step procedures to profile a sample client application by using the sampling or instrumentation method.|-   [Walkthrough: Command-Line Profiling Using Sampling](../profiling/walkthrough-command-line-profiling-using-sampling.md)<br />-   [Walkthrough: Command-Line Profiling Using Instrumentation](../profiling/walkthrough-command-line-profiling-using-instrumentation.md)|  
  
## Related Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile ASP.NET applications**|-   [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)|  
|**Profile services**|-   [Profiling Services](../profiling/command-line-profiling-of-services.md)|
