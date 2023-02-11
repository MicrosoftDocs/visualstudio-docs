---
title: "Which performance tool should I use?"
description: "Learn how to choose a performance tool in Visual Studio."
ms.date: 02/07/2023
ms.topic: conceptual
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "diagnostic tools"
  - "profiling tools"
  - "performance tools"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Which performance tool should I use? (C#, Visual Basic, C++, F#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Visual Studio provides a variety of profiling tools to help you diagnose different kinds of app performance issues depending on your app type. In this article, we provide information to help you get started with the right tool for your scenario and application type.

## Which tool should I use?

|Performance Tool|Description|When to use the tool?|
|----------------------|---------------------|-------------|-------------|
|[CPU Usage](../profiling/beginners-guide-to-performance-profiling.md)|Shows where the CPU is spending time.|- Begin an investigation for general performance issues.</br>- Server CPU is extremely high and you have no idea why.</br>- DevOps scenarios, such as when orders are not getting through to the retail website.</br>- Optimize CPU usage</br>- Experiencing latency in API calls|
|[Flame graph](../profiling/flame-graph.md)|View within the CPU Usage tool that provides an alternate visualization of the call tree.|Experiencing latency in API calls|
|[Hot path](../profiling/cpu-insights.md)|View within the CPU Usage tool that shows where most of the CPU time was spent in your application.|Experiencing latency in API calls|
|[PerfTips](../profiling/perftips.md)|Shows a quick measurement of performance information while interacting with your code.|While debugging, you want to see the elapsed time between the previous step operation (or breakpoint) to the current step or breakpoint.|
|[Memory Usage](../profiling/memory-usage.md)|Shows your app’s memory to find issues such as memory leaks.|- Optimize memory usage</br>- Experiencing UI freeze</br>- Suspected memory leak (native code)|
|[.NET Object Allocation](../profiling/dotnet-alloc-tool.md)|Shows where .NET Objects are allocated and information about garbage collection.|- Optimize .NET memory usage</br>- Analyze garbage collection|
|[Events viewer](../profiling/events-viewer.md)|Shows HTTP requests, log messages, and exceptions.|- Experiencing latency in API calls</br>- Slow application running on a remote web server|
|[.NET Async](../profiling/analyze-async.md)|Shows async/await usage in .NET apps.|Suspected performance issue with asynchronous code.|
|[.NET Counters](../profiling/dotnet-counters-tool.md)|Visualization for .NET counters.|You want a visualization for .NET counter-based metrics such as exceptions per second, garbage collection, and CPU utilization.|
|[Instrumentation](../profiling/instrumentation-overview.md)|Shows exact call counts and call times.|You need a more precise CPU utilization information than is provided in the CPU usage tool.|
|[File I/O](../profiling/use-file-io.md)|Shows your File I/O operations and how long they take and how much data they process.|Experiencing UI freeze|
|[Database](../profiling/analyze-database.md)|Shows performance of your database queries.|Investigate performance for database queries that use either ADO.NET or Entity Framework Core.|
|[GPU Usage](./gpu-usage.md)|Shows high-level hardware usage of your Direct3D app.|Check whether the performance of your app is CPU-bound or GPU-bound.|
|[Application Timeline](../profiling/application-timeline.md)|Shows UI performance for XAML apps.|Investigate UI performance in XAML apps, such as time spent rendering frames.|
|[IntelliTrace](../debugger/intellitrace.md)|Debugger tool that lets you record events and examine your application state at various points of execution.|You want a tool to examine application state at various points, not just the current application state.|

## Which tools are supported for my project?

Here is a table that lists the different tools Visual Studio offers and the different project types you can use them with:

|Performance Tool|Windows desktop|UWP|ASP.NET/ASP.NET Core|
|----------------------|---------------------|-------------|-------------|
|[CPU Usage](../profiling/beginners-guide-to-performance-profiling.md)|yes|yes|yes|
|[PerfTips](../profiling/perftips.md)|yes|yes|yes|
|[Memory Usage](../profiling/memory-usage.md)|yes|yes|yes|
|[.NET Object Allocation](../profiling/dotnet-alloc-tool.md)|yes (.NET only)|yes|yes|
|[Events viewer](../profiling/events-viewer.md)|yes|yes|yes|
|[.NET Async](../profiling/analyze-async.md)|yes (.NET only)|yes|yes|
|[.NET Counters](../profiling/dotnet-counters-tool.md)|yes (.NET Core only)|no|yes (ASP.NET Core only)|
|[Instrumentation](../profiling/instrumentation-overview.md)|yes|yes|yes|
|[File I/O](../profiling/use-file-io.md)|yes|yes|yes|
|[Database](../profiling/analyze-database.md)|yes (.NET Core only)|no|yes (ASP.NET Core only)|
|[GPU Usage](./gpu-usage.md)|yes|yes|no|
|[Application Timeline](../profiling/application-timeline.md)|yes (XAML)|yes|no|
|[Performance Explorer](../profiling/profiling-feature-tour.md#analyze-performance-legacy-tools)|no|no|no|
|[IntelliTrace](../debugger/intellitrace.md)|.NET with Visual Studio Enterprise only|.NET with Visual Studio Enterprise only|.NET with Visual Studio Enterprise only|

## See also

- [Profiling feature tour](../profiling/choose-performance-tool.md)
- [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md)

