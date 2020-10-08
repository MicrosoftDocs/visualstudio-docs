---
title: "Collecting Detailed Timing Data by Using Instrumentation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Profiling Tools,instrumentation method"
  - "instrumentation profiling method"
ms.assetid: e9deb370-c459-45ac-84d3-14d646590d05
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Collecting Detailed Timing Data by Using Instrumentation
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools instrumentation method injects profiling code into a copy of a module. The code records each entry, exit, and function call of the functions in the module during a profiling run. The instrumentation method is useful for gathering detailed timing information about a section of your code and for understanding the impact of input and output operations on application performance.  
  
 You can specify the instrumentation method by using one of the following procedures:  
  
- On the first page of the Profiling Wizard, select **Instrumentation**.  
  
- On the **Performance Explorer** toolbar, in the **Method** list, click **Instrumentation**.  
  
- On the **General** page of the properties dialog box for the performance session, select **Instrumentation**.  
  
## Common Tasks  
 You can specify additional options in the _Performance Session_**Property Pages** dialog box of the performance session. To open this dialog box:  
  
- In **Performance Explorer**, right-click the performance session name, and then click **Properties**.  
  
  The tasks in the following table describe options that you can specify in the _Performance Session_**Property Pages** dialog box when you profile by using the instrumentation method.  
  
|Task|Related Content|  
|----------|---------------------|  
|On the **General** page, add .NET memory allocation and lifetime data, and specify naming details for the generated profiling data (.vsp) file.|-   [Collecting .NET Memory Allocation and Lifetime Data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)<br />-   [How to: Set Performance Data File Name Options](../profiling/how-to-set-performance-data-file-name-options.md)|  
|On the **Launch** page, if you have multiple .exe projects in your solution.specify the application to start and their start order.|-   [How to: Specify the Binary to Start](../profiling/how-to-specify-the-binary-to-start.md)|  
|On the **Binaries** page, specify a location for the instrumented copies of the modules. By default, the original binaries are moved to a backup folder.|-   [How to: Relocate Instrumented Binaries](../profiling/how-to-relocate-instrumented-binaries.md)|  
|On the **Tier Interaction** page, add ADO.NET call data to the profiling run.|-   [Collecting tier interaction data](../profiling/collecting-tier-interaction-data.md)|  
|On the **Instrumentation** page, exclude small functions from profiling to reduce the profiling overhead, profile JavaScript code in ASP.NET Web pages, and specify commands to run at a command prompt before and after the instrumentation process.|-   [How to: Exclude or Include Short Functions from Instrumentation](../profiling/how-to-exclude-or-include-short-functions-from-instrumentation.md)<br />-   [How to: Profile JavaScript Code in Web Pages](../profiling/how-to-profile-javascript-code-in-web-pages.md)<br />-   [How to: Specify Pre- and Post-Instrument Commands](../profiling/how-to-specify-pre-and-post-instrument-commands.md)|  
|On the **CPU Counters** page, specify one or more processor performance counters to add to the profiling data.|-   [How to: Collect CPU Counter Data](../profiling/how-to-collect-cpu-counter-data.md)|  
|On the **Windows Events** page, select one or more Event Tracing for Windows (ETW) events to collect with the sampling data.|-   [How to: Collect Event Tracing for Windows (ETW) Data](../profiling/how-to-collect-event-tracing-for-windows-etw-data.md)|  
|On the **Windows Counters** page, specify one or more operating system performance counters to add to the profiling data as marks.|-   [How to: Collect Windows Counter Data](../profiling/how-to-collect-windows-counter-data.md)|  
|On the **Advanced** page, specify any additional options that you want to pass to the VSInstr instrumentation program, such as options to include or exclude specific functions.|-   [How to: Specify Additional Instrumentation Options](../profiling/how-to-specify-additional-instrumentation-options.md)<br />-   [How to: Limit Instrumentation to Specific Functions](../profiling/how-to-limit-instrumentation-to-specific-functions.md)<br />-   [VSInstr](../profiling/vsinstr.md)|
