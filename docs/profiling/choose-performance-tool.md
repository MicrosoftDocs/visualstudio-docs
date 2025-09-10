---
title: "Which performance tool should I use?"
description: Explore profiling tools in Visual Studio that can help you diagnose different kinds of application performance issues and find the right tool for your scenario.
ms.date: 09/09/2025
ms.topic: conceptual
ms.custom: "profiling-seo"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "diagnostic tools"
  - "profiling tools"
  - "performance tools"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Which performance tool should I use? (C#, Visual Basic, C++, F#)

Visual Studio provides a variety of profiling tools to help you diagnose different kinds of app performance issues depending on your app type. In this article, we provide information to help you find the right tool for your scenario and application type.

For a general approach to optimizing code using the profiling tools, see [Case study: Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md).

## Which tool should I use?

The following table lists the different tools Visual Studio offers and provides common scenarios for choosing the tool.

|Performance Tool|Description|When to use the tool?|
|----------------------|---------------------|-------------|-------------|
|[CPU Usage](../profiling/beginners-guide-to-performance-profiling.md)|Shows where the CPU is spending time.|&#x2022; Begin an investigation for general performance issues.</br>&#x2022; Investigate high server CPU usage.</br>&#x2022; Investigate DevOps scenarios, such as when orders are not getting through to the retail website.</br>&#x2022; Optimize CPU usage.</br>&#x2022; Investigate latency in API calls.|
|[Flame graph](../profiling/flame-graph.md)|View within the CPU Usage tool that provides an alternate visualization of the call tree.|Investigate latency in API calls|
|[Hot path](../profiling/cpu-insights.md)|View within the CPU Usage tool that shows where most of the CPU time was spent in your application.|Investigate latency in API calls|
|[Memory Usage](../profiling/memory-usage.md)|Shows your app’s memory to find issues such as memory leaks.|&#x2022; Optimize memory usage</br>&#x2022; Investigate UI freeze</br>&#x2022; Investigate suspected memory leak (native code)|
|[.NET Object Allocation](../profiling/dotnet-alloc-tool.md)|Shows where .NET Objects are allocated and information about garbage collection.|&#x2022; Optimize .NET memory usage</br>&#x2022; Analyze garbage collection|
|[Instrumentation](../profiling/instrumentation-overview.md)|Shows exact call counts and call times.|&#x2022; You need a tool like CPU Usage, but you want exact call counts and time spent in functions based on wall clock time.</br>&#x2022; You want to see blocked time, such as time spent waiting for locks.</br>&#x2022; Note: This tool requires extra overhead.|
|[.NET Counters](../profiling/dotnet-counters-tool.md)|Live report for .NET counters.|&#x2022; Begin an investigation for general performance issues.</br>&#x2022; You want a trace for .NET counter-based metrics such as exceptions per second, garbage collection, and CPU utilization.|
|[BenchmarkDotNet](../profiling/profiling-with-benchmark-dotnet.md)|Report for benchmarks based on BenchmarkDotNet.|&#x2022; Get different visualizations of BenchmarkDotNet collected data, such as CPU usage or memory allocations, based on the diagnoser in use.|
|[File I/O](../profiling/use-file-io.md)|Shows your File I/O operations and how long they take and how much data they process.|Investigate UI freeze|
|[PerfTips](../profiling/perftips.md)|Shows a quick measurement of performance information while interacting with your code.|While debugging, you want to see the elapsed time between the previous step operation (or breakpoint) to the current step or breakpoint.|
|[Events viewer](../profiling/events-viewer.md)|Shows HTTP requests, log messages, and exceptions.|&#x2022; Investigate latency in API calls</br>&#x2022; Investigate slow application running on a remote web server|
|[.NET Async](../profiling/analyze-async.md)|Shows async/await usage in .NET apps.|Investigate suspected performance issue with asynchronous code.|
|[Database](../profiling/analyze-database.md)|Shows performance of your database queries.|Investigate performance for database queries that use either ADO.NET or Entity Framework Core.|
|[GPU Usage](./gpu-usage.md)|Shows high-level hardware usage of your Direct3D app.|Check whether the performance of your app is CPU-bound or GPU-bound.|
|[Application Timeline](../profiling/application-timeline.md)|Shows UI performance for XAML apps.|Investigate UI performance in XAML apps, such as time spent rendering frames.|
|[IntelliTrace](../debugger/intellitrace.md)|Debugger tool that lets you record events and examine your application state at various points of execution.|You want a tool to examine application state at various points, not just the current application state.|

## Which tools are supported for my project?

The following table lists the different tools Visual Studio offers and the different project types you can use them with:

|Performance Tool|.NET|C/C++|UWP|ASP.NET/ASP.NET Core|
|----------------------|-----------|--------------|-------------|-------------|
|[CPU Usage](../profiling/beginners-guide-to-performance-profiling.md)|yes|yes|yes|yes|
|[Memory Usage](../profiling/memory-usage.md)|yes|yes|yes|yes|
|[.NET Object Allocation](../profiling/dotnet-alloc-tool.md)|yes|no|yes|yes|
|[Instrumentation](../profiling/instrumentation-overview.md)|yes|yes|yes|yes|
|[.NET Counters](../profiling/dotnet-counters-tool.md)|yes (.NET Core/5+ only)|no|no|yes (ASP.NET Core only)|
|[BenchmarkDotNet](../profiling/profiling-with-benchmark-dotnet.md)|yes|no|no|partial|
|[File I/O](../profiling/use-file-io.md)|yes|yes|yes|yes|
|[PerfTips](../profiling/perftips.md)|yes|yes|yes|yes|
|[Events viewer](../profiling/events-viewer.md)|yes|yes|yes|yes|
|[.NET Async](../profiling/analyze-async.md)|yes|no|yes|yes|
|[Database](../profiling/analyze-database.md)|yes (.NET Core/5+ only)|no|no|yes (ASP.NET Core only)|
|[GPU Usage](./gpu-usage.md)|yes|yes|yes|no|
|[Application Timeline](../profiling/application-timeline.md)|yes (XAML)|no|yes|no|
|[Performance Explorer](../profiling/profiling-feature-tour.md#analyze-performance-legacy-tools)|no|no|no|no|
|[IntelliTrace](../debugger/intellitrace.md)|.NET with Visual Studio Enterprise only|no|.NET with Visual Studio Enterprise only|.NET with Visual Studio Enterprise only|

::: moniker range=">=visualstudio"
Support for CMake projects are the same as C++. For CPU Usage, Memory Usage, File I/O, and the Events viewer, you can run profiling tools against the startup project. However, for Instrumentation and GPU Usage, you must set the executable as the target in the Performance Profiler (**Alt** + **F2**) by selecting **Executable** as the **Startup Project**.
::: moniker-end
::: moniker range="<=vs-2022"
Support for CMake projects are the same as C++. However, you must set the executable as the target in the Performance Profiler (**Alt** + **F2**) by selecting **Executable** as the **Startup Project**.
::: moniker-end

## Which tools are supported on Linux?

The following tools are supported with Linux or WSL as the target platform as well as Windows:

- CPU Usage
- .NET Object Allocation Tracking
- .NET Async
- .NET Counters
- BenchmarkDotNet
- Events Viewer
- Database

## Learn to use the profilers

The following articles and blog posts provide more information to help you learn to use the Visual Studio performance tools effectively.

- [Case study: Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md)
- [Case study: Isolate a performance issue](../profiling/isolate-performance-issue.md)
- [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/)
- [Case Study: Double performance in under 30 minutes](https://devblogs.microsoft.com/visualstudio/case-study-double-performance-in-under-30-minutes/)

## Related content

- [Profiling feature tour](../profiling/choose-performance-tool.md)
- [Run profiling tools on release or debug builds](../profiling/running-profiling-tools-with-or-without-the-debugger.md)