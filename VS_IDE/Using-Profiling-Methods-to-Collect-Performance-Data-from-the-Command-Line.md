---
title: "Using Profiling Methods to Collect Performance Data from the Command Line"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5613fafc-f298-4e7a-9a2d-a853b61cdf9c
caps.latest.revision: 14
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
# Using Profiling Methods to Collect Performance Data from the Command Line
Your choice of Visual Studio Profiling Tools command-line tools and options depends on factors such as the type of application that you are profiling, the profiling method that you want to use, and whether the target application is written in native or .NET Framework code.  
  
 This topic organizes the command-line procedural topics according to the profiling method that you choose.  
  
## In this topic  
 [Using the sampling method to collect performance statistics](#BKMK_Using_the_sampling_method_to_collect_performance_statistics)  
  
 [Using the instrumentation method to collect detailed timing data](#BKMK_Using_the_instrumentation_method_to_collect_detailed_timing_data)  
  
 [Using .NET memory methods to collect memory allocation and object lifetime data](#BKMK_Using__NET_memory_methods_to_collect_memory_allocation_and_object_lifetime_data)  
  
 [Using the concurrency method to collect resource contention and thread activity data](#BKMK_Using_the_concurrency_method_to_collect_resource_contention_and_thread_activity_data)  
  
 [Adding tier interaction data to a profiling run](#BKMK_Adding_tier_interaction_data_to_a_profiling_run)  
  
##  <a name="BKMK_Using_the_sampling_method_to_collect_performance_statistics"></a> Using the sampling method to collect performance statistics  
 The Profiling Tools sampling method collects performance data at specified intervals in a profiling run. Sampling data can provide insights into CPU-bound performance issues, and it can be a good way to start exploring the performance of an application.  
  
 You can start the profiler and the application at the same time, or you can attach the profiler to a running instance of an application.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone Applications](../VS_IDE/How-to--Launch-a-Stand-Alone-Application-with-the-Profiler-and-Collect-Application-Statistics-by-Using-the-Command-Line.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Applications](../VS_IDE/How-to--Attach-the-Profiler-to-a-.NET-Framework-Stand-Alone-Application-and-Collect-Application-Statistics-by-Using-the-Command-Line.md)<br />-   [Native Stand-Alone Applications](../VS_IDE/How-to--Attach-the-Profiler-to-a-Native-Stand-Alone-Application-and-Collect-Application-Statistics-by-Using-the-Command-Line.md)<br />-   [ASP.NET Web Applications](../VS_IDE/How-to--Attach-the-Profiler-to-an-ASP.NET-Web-Application-to-Collect-Application-Statistics-by-Using-the-Command-Line.md)<br />-   [.NET Services](../VS_IDE/How-to--Attach-the-Profiler-to-a-.NET-Service-to-Collect-Application-Statistics-by-Using-the-Command-Line.md)<br />-   [Native Services](../VS_IDE/How-to--Attach-the-Profiler-to-a-Native-Service-to-Collect-Application-Statistics-by-Using-the-Command-Line.md)|  
  
##  <a name="BKMK_Using_the_instrumentation_method_to_collect_detailed_timing_data"></a> Using the instrumentation method to collect detailed timing data  
 The Profiling Tools instrumentation method collects performance data from copies of application binaries that contain software probes to record performance information. Instrumentation data is collected at the start and end of each instrumented function and at every call to other functions from the instrumented function. The instrumentation method is useful for discovering performance issues with I/O issues such as disk usage.  
  
 You create the instrumented binary with the [VInstr.exe](../VS_IDE/VSInstr.md) tool. After you initialize the profiler, data is automatically collected from the instrumented binaries when you run the target application.  
  
 **Target Application Type**  
  
-   [.NET Framework Stand-Alone Components](../VS_IDE/How-to--Instrument-a-Stand-Alone-.NET-Framework-Component-and-Collect-Timing-Data-with-the-Profiler-from-the-Command-Line.md)  
  
-   [Native Stand-Alone Components](../VS_IDE/How-to--Instrument-a-Native-Stand-Alone-Component-and-Collect-Timing-Data-with-the-Profiler-from-the-Command-Line.md)  
  
-   [Statically Compiled ASP.NET Web Applications](../VS_IDE/How-to--Instrument-a-Statically-Compiled-ASP.NET-Web-Application-and-Collect-Detailed-Timing-Data-with-the-Profiler-by-Using-the-Command-Line.md)  
  
-   [Dynamically Compiled ASP.NET Web Applications](../VS_IDE/How-to--Instrument-a-Dynamically-Compiled-ASP.NET-Web-Application-and-Collect-Detailed-Timing-Data-with-the-Profiler-by-Using-the-Command-Line.md)  
  
-   [.NET Services](../VS_IDE/How-to--Instrument-a-.NET-Service-and-Collect-Detailed-Timing-Data-by-Using-the-Profiler-Command-Line.md)  
  
-   [Native Services](../VS_IDE/How-to--Instrument-a-Native-Service-and-Collect-Detailed-Timing-Data-by-Using-the-Profiler-Command-Line.md)  
  
##  <a name="BKMK_Using__NET_memory_methods_to_collect_memory_allocation_and_object_lifetime_data"></a> Using .NET memory methods to collect memory allocation and object lifetime data  
 The Profiling Tools .NET memory method enables you to collect .NET Framework memory allocation data and information about the lifetime of objects in the .NET Framework.  
  
 You can start the target application by using the profiler; you can attach the profiler to a running instance of an application; and you can create instrumented versions of the application to collect detailed timing information together with the .NET Framework memory data.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone .NET Framework Applications](../VS_IDE/How-to--Launch-a-Stand-Alone-.NET-Framework-Application-with-the-Profiler-to-Collect-Memory-Data-by-Using-the-Command-Line.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Applications](../VS_IDE/How-to--Attach-the-Profiler-to-a-.NET-Framework-Stand-Alone-Application-to-Collect-Memory-Data-by-Using-the-Command-Line.md)<br />-   [ASP.NET Web Applications](../VS_IDE/How-to--Attach-the-Profiler-to-an-ASP.NET-Web-Application-to-Collect-Memory-Data-by-Using-the-Command-Line.md)<br />-   [.NET Services](../VS_IDE/How-to--Attach-the-Profiler-to-a-.NET-Service-to-Collect-Memory-Data-by-Using-the-Command-Line.md)|  
|**Instrument modules**|-   [.NET Framework Stand-Alone Components](../VS_IDE/How-to--Instrument-a-Stand-Alone-.NET-Framework-Component-and-Collect-Memory-Data-with-the-Profiler-by-Using-the-Command-Line.md)<br />-   [Statically Compiled ASP.NET Web Applications](../VS_IDE/How-to--Instrument-a-Statically-Compiled-ASP.NET-Web-Application-and-Collect-Memory-Data-by-Using-the-Profiler-Command-Line.md)<br />-   [Dynamically Compiled ASP.NET Web Applications](../VS_IDE/How-to--Instrument-a-Dynamically-Compiled-ASP.NET-Web-Application-and-Collect-Memory-Data-by-Using-the-Profiler-Command-Line.md)<br />-   [.NET Services](../VS_IDE/How-to--Instrument-a-.NET-Framework-Service-and-Collect-Memory-Data-by-Using-the-Profiler-Command-Line.md)|  
  
##  <a name="BKMK_Using_the_concurrency_method_to_collect_resource_contention_and_thread_activity_data"></a> Using the concurrency method to collect resource contention and thread activity data  
 The Profiling Tools concurrency method enables you to collect resource contention and thread and process activity data from multithreaded applications.  
  
 You can start the application by using the profiler, or you can attach the profiler to a running instance of an application.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone .NET Framework Application](../VS_IDE/How-to--Launch-a-Stand-Alone-.NET-Framework-Application-with-the-Profiler-to-Collect-Concurrency-Data-by-Using-the-Command-Line.md)<br />-   [Stand-Alone Native Application](../VS_IDE/How-to--Launch-a-Stand-Alone-Native-Application-with-the-Profiler-to-Collect-Concurrency-Data-by-Using-the-Command-Line.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Application](../VS_IDE/How-to--Attach-the-Profiler-to-a-.NET-Framework-Stand-Alone-Application-to-Collect-Concurrency-Data-by-Using-the-Command-Line.md)<br />-   [Native Stand-Alone Application](../VS_IDE/How-to--Attach-the-Profiler-to-a-Native-Stand-Alone-Application-and-Collect-Concurrency-Data-by-Using-the-Command-Line.md)<br />-   [ASP.NET Web Application](../VS_IDE/How-to--Attach-the-Profiler-to-an-ASP.NET-Web-Application-to-Collect-Concurrency-Data-by-Using-the-Command-Line.md)<br />-   [.NET Service](../VS_IDE/How-to--Attach-the-Profiler-to-a-.NET-Service-to-Collect-Concurrency-Data-by-Using-the-Command-Line.md)<br />-   [Native Service](../VS_IDE/How-to--Attach-the-Profiler-to-a-Native-Service-to-Collect-Concurrency-Data-by-Using-the-Command-Line.md)|  
  
##  <a name="BKMK_Adding_tier_interaction_data_to_a_profiling_run"></a> Adding tier interaction data to a profiling run  
 Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collecting tier interaction data](../VS_IDE/Adding-tier-interaction-data-from-the-command-line.md)  
  
## See Also  
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)