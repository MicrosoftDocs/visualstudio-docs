---
title: "Which performance tool should I use?"
description: "Learn how to choose a performance tool in Visual Studio."
ms.date: 01/10/2023
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

|Performance Tool|Description|When to use it|
|----------------------|---------------------|-------------|-------------|
|[CPU Usage](../profiling/beginners-guide-to-performance-profiling.md)|Shows where the CPU is spending time.|- When your server CPU is extremely high and you have no idea why.</br>- DevOps scenarios, such as when orders are not getting through to the retail website.</br>- Optimize CPU usage.</br>- Latency in API calls.|
|[Flame graph](../profiling/flame-graph.md)|View within the CPU Usage tool that can be used instead of a calltree.|Latency in API calls.|
|[Hot path](../profiling/cpu-insights,md)|View within the CPU Usage tool, based on an algorithm for digging into a calltree.|Latency in API calls.|
|[PerfTips](../profiling/perftips.md)|||
|[Memory Usage](../profiling/memory-usage.md)|Shows your app’s memory to find issues such as memory leaks.|- Optimize memory usage.</br>- UI freeze|
|[.NET Object Allocation](../profiling/dotnet-alloc-tool.md)|Shows where .NET Objects are allocated and information about garbage collection||
|[Events viewer](../profiling/events-viewer.md)|Shows HTTP requests, log messages, and exceptions.|- Latency in API calls</br>- Slow application running on a remote web server|
|[.NET Async](../profiling/analyze-async.md)|Shows async/await usage in .NET apps|When you suspect performance issues with asynchronous code.|
|[.NET Counters](../profiling/dotnet-counters-tool.md)|Visualization for .NET counters|When you want a visualization for .NET counter-based metrics such as exceptions per second, garbage collection, CPU utilization.|
|[Instrumentation](../profiling/instrumentation-overview.md)|Shows exact call counts and call times.|When you need more precise CPU utilization information than is provided in the CPU usage tool.|
|[File I/O](../profiling/use-file-io.md)|Shows your File I/O operations and how long they take and how much data they process.|UI freeze|
|[Database](../profiling/analyze-database.md)|Shows performance of your database queries using either ADO.NET or Entity Framework Core.||
|[GPU Usage](./gpu-usage.md)|Shows high-level hardware usage of your Direct3D app||
|[Application Timeline](../profiling/application-timeline.md)|Shows UI performance for XAML apps.|When you want to analyze UI performance in XAML apps, such as time spent rendering frames.|
|[IntelliTrace](../debugger/intellitrace.md)|||

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
|[Performance Explorer](#analyze-performance-legacy-tools)|no|no|no|
|[IntelliTrace](../debugger/intellitrace.md)|.NET with Visual Studio Enterprise only|.NET with Visual Studio Enterprise only|.NET with Visual Studio Enterprise only|

## See also

- [Debugging in Visual Studio](../debugger/debugger-feature-tour.md)
