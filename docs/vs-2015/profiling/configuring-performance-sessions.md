---
title: "Configuring Performance Sessions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "common tasks, performance"
  - "common tasks, profiling tools"
  - "profiling tools, common tasks"
  - "performance, gathering data"
ms.assetid: e1c3ba41-ffca-4edf-9a7f-8a5a9244ef9b
caps.latest.revision: 41
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Configuring Performance Sessions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools, you can collect a wide variety of performance data for a large number of application types. This section shows you how to use the Performance Wizardand properties of the performance session and target binary to configure Profiling Tools to collect the data that interests you. Profiling Tools configuration properties can also be used to control how much data is collected in a profiling run. For more information, see [Controlling Data Collection](../profiling/controlling-data-collection.md).  
  
> [!NOTE]
> In many cases, using the default properties of the Performance Wizard is an effective way of collecting profiling data. For more information, see [Beginners Guide to Performance Profiling](../profiling/beginners-guide-to-performance-profiling.md) and [Getting Started](../profiling/getting-started-with-performance-tools.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Set the basic profiling options:** You should configure [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] to use the Microsoft symbol server. This will make sure that you have access to symbols, such as function and parameter names, for the current version of Windows and other Microsoft applications. You can also specify other general options before a profiling session starts, such as system permissions to the profiling tools and the names of profiling data files.|-   [How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md)<br />-   [How to: Serialize Symbol Information](../profiling/how-to-serialize-symbol-information.md)<br />-   [How to: Set the Current Session](../profiling/how-to-set-the-current-session.md)<br />-   [How to: Set Permissions](../profiling/how-to-set-permissions.md)<br />-   [How to: Set Performance Data File Name Options](../profiling/how-to-set-performance-data-file-name-options.md)|  
|**Specify the data that you want to collect:** The procedures that you use to configure a profiling session depend on the type of target application that you want to profile and the type of performance data that you want to collect.|-   [How to: Choose Collection Methods](../profiling/how-to-choose-collection-methods.md)<br />-   [Collecting Performance Statistics by Using Sampling](../profiling/collecting-performance-statistics-by-using-sampling.md)<br />-   [Collecting .NET Memory Allocation and Lifetime Data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)<br />-   [Collecting Detailed Timing Data by Using Instrumentation](../profiling/collecting-detailed-timing-data-by-using-instrumentation.md)<br />-   [How to: Profile JavaScript Code in Web Pages](../profiling/how-to-profile-javascript-code-in-web-pages.md)<br />-   [Collecting Thread and Process Concurrency Data](../profiling/collecting-thread-and-process-concurrency-data.md)<br />-   [Collecting Additional Performance Data](../profiling/collecting-additional-performance-data.md)|  
|**Set advanced configuration options:** When you profile .NET Framework applications that load multiple versions of the common language run-time (CLR), you can specify which version to profile. When you have multiple .exe files in a performance session, you can set the start order of the binaries.|-   [How to: Specify the .NET Framework Runtime](../profiling/how-to-specify-the-dotnet-framework-runtime.md)<br />-   [How to: Specify the Binary to Start](../profiling/how-to-specify-the-binary-to-start.md)|  
  
## Related Sections  
 [Controlling Data Collection](../profiling/controlling-data-collection.md)  
  
## See Also  
 [Performance Explorer](../profiling/performance-explorer.md)
