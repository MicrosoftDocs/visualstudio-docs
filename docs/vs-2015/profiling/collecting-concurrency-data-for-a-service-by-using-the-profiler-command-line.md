---
title: "Collecting Concurrency Data for a Service by Using the Profiler Command Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 275aacba-b2af-4d34-8931-ee30d777a256
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Collecting Concurrency Data for a Service by Using the Profiler Command Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The concurrency method of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools enables you to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped IO, and other system events.  
  
> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Attach to a running .NET service**|-   [How to: Attach the Profiler to a .NET Service to Collect Concurrency Data](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-concurrency-data-by-using-the-command-line.md)|  
|**Add tier-interaction data**|-   [Collecting tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)|  
|**Attach to a running C/C++ service**|-   [How to: Attach the Profiler to a Native Service to Collect Concurrency Data](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-concurrency-data-by-using-the-command-line.md)|  
  
## Related Tasks  
  
### Profiling Windows Services  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile by using the sampling method**|-   [Collecting Application Statistics Using Sampling](../profiling/collecting-application-statistics-for-services-by-using-the-profiler-sampling-method.md)|  
|**Profile by using the instrumentation method**|-   [Collecting Detailed Timing Data Using Instrumentation](../profiling/collecting-detailed-timing-data-for-services-by-using-the-instrumentation-method-from-the-profiler-command-line.md)|  
|**Profile.NET memory allocation and garbage collection**|-   [Collecting .NET Memory Data](../profiling/collecting-memory-data-from-dotnet-framework-services-by-using-the-profiler-command-line.md)|  
  
### Profiling Concurrency Data  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile stand-alone applications**|-   [Collecting Concurrency Data](../profiling/collecting-concurrency-data-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Profile ASP.NET Web applications**|-   [Collecting Concurrency Data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application-using-the-profiler-command-line.md)|  
  
### Analyzing Concurrency Data Views and Reports  
 [Resource Contention Data Views](../profiling/resource-contention-data-views.md)  
  
 [Concurrency Visualizer](../profiling/concurrency-visualizer.md)  
  
## Reference  
 [Command-Line Profiling Tools Reference](../profiling/command-line-profiling-tools-reference.md)
