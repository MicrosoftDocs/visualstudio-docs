---
title: "Concurrency Visualizer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.performance.viewnavigation"
  - "vs.cv.overview"
  - "vs.cv.performance.gettingstarted"
  - "vs.cv.gettingstarted"
helpviewer_keywords: 
  - "Concurrency Visualizer, Concurrency Visualizer"
ms.assetid: ae5879a0-1e1a-455a-ba72-148e57f59289
caps.latest.revision: 36
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Concurrency Visualizer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

NOTE]
> The Concurrency Visualizer is an optional extension to Visual Studio. Download the Concurrency Visualizer and the Concurrency Visualizer Collection Tools from the following links:  
> 
> - Download the              [Concurrency Visualizer](https://visualstudiogallery.msdn.microsoft.com/a6c24ce9-beec-4545-9261-293061436ee9) extension.  
>   - Download the              [Concurrency Visualizer Collection Tools for Visual Studio 2015](https://www.microsoft.com/download/details.aspx?id=49103).  
> 
>   The [Concurrency Visualizer Command-Line Utility (CVCollectionCmd)](../profiling/concurrency-visualizer-command-line-utility-cvcollectioncmd.md) lets you collect traces from the command line that you can view in the Concurrency Visualizer for Visual Studio 2015. The tool can be used on computers that do not have Visual Studio installed.  
  
 You can use the Concurrency Visualizer to see how your multithreaded app performs. The views in the Concurrency Visualizer provide graphical, tabular, and textual data that shows the temporal relationships between the threads in your program and the system as a whole. You can use the Concurrency Visualizer to locate performance bottlenecks, CPU underutilization, thread contention, cross-core thread migration, synchronization delays, DirectX activity, areas of overlapped I/O, and other information. The views provide data that you can act on by linking its graphical output to call stacks and source code.  
  
 The Concurrency Visualizer relies on [Event Tracing for Windows](https://go.microsoft.com/fwlink/?LinkId=234579) functionality.  
  
> [!NOTE]
> The Concurrency Visualizer doesn't support Web projects.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Utilization View](../profiling/utilization-view.md)|Describes how to view and analyze system activity across all processors.|  
|[Threads View](../profiling/threads-view-parallel-performance.md)|Describes how to analyze the interactions between threads in your program.|  
|[Cores View](../profiling/cores-view.md)|Describes how to analyze thread migration across cores.|  
|[Common Patterns for Poorly-Behaved Multithreaded Applications](../profiling/common-patterns-for-poorly-behaved-multithreaded-applications.md)|Describes several common patterns and shows how they appear in the Concurrency Visualizer.|  
|[Parallel Development in Visual Studio blog](https://go.microsoft.com/fwlink/?LinkId=235385)|Provides tips and best practices for the Concurrency Visualizer.|  
|[Performance Report Views](../profiling/performance-report-views.md)|Provides reference information for the reports and views of Visual Studio Profiling Tools.|  
|[Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md)|Describes how to instrument your source code to display additional information in the Concurrency Visualizer.|  
|[Concurrency Visualizer Command-Line Utility (CVCollectionCmd)](../profiling/concurrency-visualizer-command-line-utility-cvcollectioncmd.md)|Describes how to use the Concurrency Visualizer command line utility (CVCollectionCmd.exe) to collect and process traces on machines that don't have Visual Studio.|  
  
## See Also  
 [Profiling Tools](../profiling/profiling-tools.md)
