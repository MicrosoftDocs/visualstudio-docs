---
title: View thread-timing graphs in Concurrency Visualizer 
description: Use the Concurrency Visualizer to see graphs that show the thread timing in your multi-threaded app, helping you solve performance issues.
ms.date: "07/11/2017"
ms.topic: article
f1_keywords:
  - "vs.cv.performance.viewnavigation"
  - "vs.cv.overview"
  - "vs.cv.performance.gettingstarted"
  - "vs.cv.gettingstarted"
helpviewer_keywords:
  - "Concurrency Visualizer, Concurrency Visualizer"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Concurrency Visualizer

> [!NOTE]
> The Concurrency Visualizer is an optional extension to Visual Studio. Download the Concurrency Visualizer and the Concurrency Visualizer Collection Tools from the following links:
>
> - Download the [Concurrency Visualizer for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=Diagnostics.DiagnosticsConcurrencyVisualizer2022#overview) extension.
> - Download the [Concurrency Visualizer for Visual Studio 2019](https://marketplace.visualstudio.com/items?itemName=Diagnostics.DiagnosticsConcurrencyVisualizer2019#overview) extension.
> - Download the [Concurrency Visualizer for Visual Studio 2017](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.ConcurrencyVisualizer2017#overview) extension.
> - Download the [Concurrency Visualizer for Visual Studio 2015](https://marketplace.visualstudio.com/items?itemName=Diagnostics.ConcurrencyVisualizerforVisualStudio2015) extension.
>
> The [Concurrency Visualizer Command-Line Utility (CVCollectionCmd)](../profiling/concurrency-visualizer-command-line-utility-cvcollectioncmd.md) lets you collect traces from the command line that you can view in the Concurrency Visualizer for Visual Studio. The tool can be used on computers that do not have Visual Studio installed.

You can use the Concurrency Visualizer to see how your multithreaded app performs. The views in the Concurrency Visualizer provide graphical, tabular, and textual data that shows the temporal relationships between the threads in your program and the system as a whole. You can use the Concurrency Visualizer to locate performance bottlenecks, CPU underutilization, thread contention, cross-core thread migration, synchronization delays, DirectX activity, areas of overlapped I/O, and other information. The views provide data that you can act on by linking its graphical output to call stacks and source code.

> [!NOTE]
> The Concurrency Visualizer doesn't support Web projects.

The Concurrency Visualizer relies on [Event Tracing for Windows](/windows/win32/etw/event-tracing-portal) functionality.

## Related Topics

|Title|Description|
|-----------|-----------------|
|[Utilization View](../profiling/utilization-view.md)|Describes how to view and analyze system activity across all processors.|
|[Threads View](../profiling/threads-view-parallel-performance.md)|Describes how to analyze the interactions between threads in your program.|
|[Cores View](../profiling/cores-view.md)|Describes how to analyze thread migration across cores.|
|[Common patterns for poorly-behaved multithreaded applications](../profiling/common-patterns-for-poorly-behaved-multithreaded-applications.md)|Describes several common patterns and shows how they appear in the Concurrency Visualizer.|
|[Parallel Development in Visual Studio blog](/archive/blogs/visualizeparallel/)|Provides tips and best practices for the Concurrency Visualizer.|
|[Performance Report Views](../profiling/performance-report-views.md)|Provides reference information for the reports and views of Visual Studio Profiling Tools.|
|[Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md)|Describes how to instrument your source code to display additional information in the Concurrency Visualizer.|
|[Concurrency Visualizer command-line utility (CVCollectionCmd)](../profiling/concurrency-visualizer-command-line-utility-cvcollectioncmd.md)|Describes how to use the Concurrency Visualizer command line utility (CVCollectionCmd.exe) to collect and process traces on machines that don't have Visual Studio.|

## Related content

- [Profiling in Visual Studio](../profiling/index.yml)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
