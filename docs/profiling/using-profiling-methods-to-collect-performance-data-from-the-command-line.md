---
title: "Using Profiling Methods to Collect Performance Data from the Command Line"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5613fafc-f298-4e7a-9a2d-a853b61cdf9c
caps.latest.revision: 14
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
# Using Profiling Methods to Collect Performance Data from the Command Line
Your choice of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools command-line tools and options depends on factors such as the type of application that you are profiling, the profiling method that you want to use, and whether the target application is written in native or [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] code.  
  
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
|**Launch an application**|-   [Stand-Alone Applications](../profiling/52dcee2b-f178-4a76-bddc-e36c50bfcb78.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Applications](../profiling/b62fcbc1-791f-474e-890a-a6c332e0c9ea.md)<br />-   [Native Stand-Alone Applications](../profiling/df44fe42-281b-4398-b3fc-277b62ae41f1.md)<br />-   [ASP.NET Web Applications](../profiling/3725ddbe-ce91-4469-991e-8c5ed048c618.md)<br />-   [.NET Services](../profiling/a0046c47-26c8-4bec-96a0-81da05e5104a.md)<br />-   [Native Services](../profiling/f783817f-77a0-4eb8-985b-ec3b77eadc42.md)|  
  
##  <a name="BKMK_Using_the_instrumentation_method_to_collect_detailed_timing_data"></a> Using the instrumentation method to collect detailed timing data  
 The Profiling Tools instrumentation method collects performance data from copies of application binaries that contain software probes to record performance information. Instrumentation data is collected at the start and end of each instrumented function and at every call to other functions from the instrumented function. The instrumentation method is useful for discovering performance issues with I/O issues such as disk usage.  
  
 You create the instrumented binary with the [VInstr.exe](../profiling/vsinstr.md) tool. After you initialize the profiler, data is automatically collected from the instrumented binaries when you run the target application.  
  
 **Target Application Type**  
  
-   [.NET Framework Stand-Alone Components](../profiling/b7dcc27b-45c6-4302-9552-6fa5b1e94b56.md)  
  
-   [Native Stand-Alone Components](../profiling/36883074-9be8-4e90-a66f-7e87f21fcd30.md)  
  
-   [Statically Compiled ASP.NET Web Applications](../profiling/b260ce68-76e6-4c3b-8062-3c00bd5cf7b8.md)  
  
-   [Dynamically Compiled ASP.NET Web Applications](../profiling/6c140ae2-ecdd-48c7-bd89-3dc1b88e19b0.md)  
  
-   [.NET Services](../profiling/9f73593a-69a7-41b7-a21c-81d3ab0eb8fe.md)  
  
-   [Native Services](../profiling/dfe58b39-63f8-4a87-ab3a-2b5b14faa8d0.md)  
  
##  <a name="BKMK_Using__NET_memory_methods_to_collect_memory_allocation_and_object_lifetime_data"></a> Using .NET memory methods to collect memory allocation and object lifetime data  
 The Profiling Tools .NET memory method enables you to collect [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] memory allocation data and information about the lifetime of objects in the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)].  
  
 You can start the target application by using the profiler; you can attach the profiler to a running instance of an application; and you can create instrumented versions of the application to collect detailed timing information together with the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] memory data.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone .NET Framework Applications](../profiling/3bc53041-91b7-4ad0-8413-f8bf2c4b3f5e.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Applications](../profiling/9a869fa4-3c98-4e08-b5d9-f43523059f0e.md)<br />-   [ASP.NET Web Applications](../profiling/d608f85a-41ae-4ca7-85e6-b96624dbc83c.md)<br />-   [.NET Services](../profiling/how-to--attach-the-profiler-to-a-.net-service-to-collect-memory-data-by-using-the-command-line.md)|  
|**Instrument modules**|-   [.NET Framework Stand-Alone Components](../profiling/d09cc46a-70f5-48f9-aa24-89913e67b359.md)<br />-   [Statically Compiled ASP.NET Web Applications](../profiling/ea1dcb7c-1dc3-49ff-9418-8795b5b3d3bc.md)<br />-   [Dynamically Compiled ASP.NET Web Applications](../profiling/2cdd9903-39db-47e8-93dd-5e6a21bc3435.md)<br />-   [.NET Services](../profiling/2fa072fc-05fe-4420-99c0-51d2ea3ac4ce.md)|  
  
##  <a name="BKMK_Using_the_concurrency_method_to_collect_resource_contention_and_thread_activity_data"></a> Using the concurrency method to collect resource contention and thread activity data  
 The Profiling Tools concurrency method enables you to collect resource contention and thread and process activity data from multithreaded applications.  
  
 You can start the application by using the profiler, or you can attach the profiler to a running instance of an application.  
  
|Task|Target application type|  
|----------|-----------------------------|  
|**Launch an application**|-   [Stand-Alone .NET Framework Application](../profiling/17a48848-bd3e-44ef-9971-e39836ff1df2.md)<br />-   [Stand-Alone Native Application](../profiling/e5aed651-afed-4b70-9a7e-1a6032cc614f.md)|  
|**Attach to a running process**|-   [.NET Framework Stand-Alone Application](../profiling/fdd41576-797e-4312-8520-fee7bb767e4a.md)<br />-   [Native Stand-Alone Application](../profiling/12d3e0f3-4b74-4e66-8fbf-8ac99bd4f91c.md)<br />-   [ASP.NET Web Application](../profiling/0e215fdd-55f8-43ef-9534-06542eefe223.md)<br />-   [.NET Service](../profiling/how-to--attach-the-profiler-to-a-.net-service-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [Native Service](../profiling/283a1ee1-b43e-4daf-95ae-1311925a42a8.md)|  
  
##  <a name="BKMK_Adding_tier_interaction_data_to_a_profiling_run"></a> Adding tier interaction data to a profiling run  
 Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collecting tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)  
  
## See Also  
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-asp.net-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)