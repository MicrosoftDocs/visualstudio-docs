---
title: "Using Profiling Methods to Collect Performance Data from the Command Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 5613fafc-f298-4e7a-9a2d-a853b61cdf9c
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Using Profiling Methods to Collect Performance Data from the Command Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Your choice of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools command-line tools and options depends on factors such as the type of application that you are profiling, the profiling method that you want to use, and whether the target application is written in native or [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] code.  
  
 This topic organizes the command-line procedural topics according to the profiling method that you choose.  
  
## In this topic  
 [Using the sampling method to collect performance statistics](#BKMK_Using_the_sampling_method_to_collect_performance_statistics)  
  
 [Using the instrumentation method to collect detailed timing data](#BKMK_Using_the_instrumentation_method_to_collect_detailed_timing_data)  
  
 [Using .NET memory methods to collect memory allocation and object lifetime data](#BKMK_Using__NET_memory_methods_to_collect_memory_allocation_and_object_lifetime_data)  
  
 [Using the concurrency method to collect resource contention and thread activity data](#BKMK_Using_the_concurrency_method_to_collect_resource_contention_and_thread_activity_data)  
  
 [Adding tier interaction data to a profiling run](#BKMK_Adding_tier_interaction_data_to_a_profiling_run)  
  
## <a name="BKMK_Using_the_sampling_method_to_collect_performance_statistics"></a> Using the sampling method to collect performance statistics  
 The Profiling Tools sampling method collects performance data at specified intervals in a profiling run. Sampling data can provide insights into CPU-bound performance issues, and it can be a good way to start exploring the performance of an application.  
  
 You can start the profiler and the application at the same time, or you can attach the profiler to a running instance of an application.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone Applications](../profiling/how-to-launch-a-stand-alone-application-with-the-profiler-and-collect-application-statistics-by-using-the-command-line.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Applications](../profiling/how-to-attach-the-profiler-to-a-dotnet-framework-stand-alone-application-and-collect-application-statistics-by-using-the-command-line.md)<br />-   [Native Stand-Alone Applications](../profiling/how-to-attach-the-profiler-to-a-native-stand-alone-application-and-collect-application-statistics-by-using-the-command-line.md)<br />-   [ASP.NET Web Applications](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-application-statistics-by-using-the-command-line.md)<br />-   [.NET Services](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-application-statistics-by-using-the-command-line.md)<br />-   [Native Services](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-application-statistics-by-using-the-command-line.md)|  
  
## <a name="BKMK_Using_the_instrumentation_method_to_collect_detailed_timing_data"></a> Using the instrumentation method to collect detailed timing data  
 The Profiling Tools instrumentation method collects performance data from copies of application binaries that contain software probes to record performance information. Instrumentation data is collected at the start and end of each instrumented function and at every call to other functions from the instrumented function. The instrumentation method is useful for discovering performance issues with I/O issues such as disk usage.  
  
 You create the instrumented binary with the [VInstr.exe](../profiling/vsinstr.md) tool. After you initialize the profiler, data is automatically collected from the instrumented binaries when you run the target application.  
  
 **Target Application Type**  
  
- [.NET Framework Stand-Alone Components](../profiling/how-to-instrument-a-stand-alone-dotnet-framework-component-and-collect-timing-data-with-the-profiler-from-the-command-line.md)  
  
- [Native Stand-Alone Components](../profiling/how-to-instrument-a-native-stand-alone-component-and-collect-timing-data-with-the-profiler-from-the-command-line.md)  
  
- [Statically Compiled ASP.NET Web Applications](../profiling/how-to-instrument-a-statically-compiled-aspnet-web-application-and-collect-detailed-timing-data-with-the-profiler-by-using-the-command-line.md)  
  
- [Dynamically Compiled ASP.NET Web Applications](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-web-application-and-collect-detailed-timing-data-with-the-profiler-by-using-the-command-line.md)  
  
- [.NET Services](../profiling/how-to-instrument-a-dotnet-service-and-collect-detailed-timing-data-by-using-the-profiler-command-line.md)  
  
- [Native Services](../profiling/how-to-instrument-a-native-service-and-collect-detailed-timing-data-by-using-the-profiler-command-line.md)  
  
## <a name="BKMK_Using__NET_memory_methods_to_collect_memory_allocation_and_object_lifetime_data"></a> Using .NET memory methods to collect memory allocation and object lifetime data  
 The Profiling Tools .NET memory method enables you to collect [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] memory allocation data and information about the lifetime of objects in the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].  
  
 You can start the target application by using the profiler; you can attach the profiler to a running instance of an application; and you can create instrumented versions of the application to collect detailed timing information together with the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] memory data.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone .NET Framework Applications](../profiling/how-to-launch-a-stand-alone-dotnet-framework-application-with-the-profiler-to-collect-memory-data-by-using-the-command-line.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Applications](../profiling/how-to-attach-the-profiler-to-a-dotnet-framework-stand-alone-application-to-collect-memory-data-by-using-the-command-line.md)<br />-   [ASP.NET Web Applications](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-memory-data-by-using-the-command-line.md)<br />-   [.NET Services](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-memory-data-by-using-the-command-line.md)|  
|**Instrument modules**|-   [.NET Framework Stand-Alone Components](../profiling/how-to-instrument-a-stand-alone-dotnet-framework-component-and-collect-memory-data-with-the-profiler-by-using-the-command-line.md)<br />-   [Statically Compiled ASP.NET Web Applications](../profiling/how-to-instrument-a-statically-compiled-aspnet-web-application-and-collect-memory-data-by-using-the-profiler-command-line.md)<br />-   [Dynamically Compiled ASP.NET Web Applications](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-web-application-and-collect-memory-data-by-using-the-profiler-command-line.md)<br />-   [.NET Services](../profiling/how-to-instrument-a-dotnet-framework-service-and-collect-memory-data-by-using-the-profiler-command-line.md)|  
  
## <a name="BKMK_Using_the_concurrency_method_to_collect_resource_contention_and_thread_activity_data"></a> Using the concurrency method to collect resource contention and thread activity data  
 The Profiling Tools concurrency method enables you to collect resource contention and thread and process activity data from multithreaded applications.  
  
 You can start the application by using the profiler, or you can attach the profiler to a running instance of an application.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone .NET Framework Application](../profiling/how-to-launch-a-stand-alone-dotnet-framework-application-with-the-profiler-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [Stand-Alone Native Application](../profiling/how-to-launch-a-stand-alone-native-application-with-the-profiler-to-collect-concurrency-data-by-using-the-command-line.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Application](../profiling/how-to-attach-the-profiler-to-a-dotnet-framework-stand-alone-application-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [Native Stand-Alone Application](/visualstudio/profiling/how-to-attach-the-profiler-to-a-native-app-and-collect-concurrency-data?view=vs-2015)<br />-   [ASP.NET Web Application](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [.NET Service](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [Native Service](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-concurrency-data-by-using-the-command-line.md)|  
  
## <a name="BKMK_Adding_tier_interaction_data_to_a_profiling_run"></a> Adding tier interaction data to a profiling run  
 Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collecting tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)  
  
## See Also  
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
