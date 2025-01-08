---
title: Using multiple profiler tools simultaneously
description: Learn how the Performance Profiler was designed with the idea that multiple tools can be used in the same session to aid in understanding performance issues.
ms.date: 4/29/2020
ms.topic: how-to
helpviewer_keywords: 
  - Profiler, multiple tools
author: MikeJo5000
ms.author: mikejo 
manager: AndSter
ms.subservice: debug-diagnostics
---
# Using multiple profiler tools simultaneously

The Performance Profiler was designed with the idea that multiple tools can be used in the same session to aid in understanding performance issues. Most tools in the Performance Profiler support running concurrently such as the [CPU Usage](../profiling/cpu-usage.md), [.NET Async Tool](../profiling/analyze-async.md), and [Database](../profiling/analyze-database.md) tool. To run tools simultaneously in the same diagnostic session, click the check box next to them and then start the diagnostic session.

![Diag Hub All Tools Selected](../profiling/media/diaghuballtoolsselected.png "Diag Hub All Tools Selected")

>[!NOTE]
>Certain tools such as the [.NET Object Allocation](../profiling/dotnet-alloc-tool.md) tool cannot be run with other tools due to their high overhead or due to other technical limitations.

## Time filtering 

During analysis, time filtering operations are applied across tools, so you can use information in one tool to narrow down a time range and filter data in another tool. This feature helps guide analysis to specific points in a trace and helps you understand the state of the application.

![Diag Hub Time Filtering](../profiling/media/diaghubtimefiltering.png "Diag Hub Time Filtering")

## Related content

- [Optimizing profiler settings](../profiling/optimize-profiler-settings.md)
- [Running profiling tools on release or debug builds](../profiling/running-profiling-tools-with-or-without-the-debugger.md)
- [Understanding performance collection methods](../profiling/understanding-performance-collection-methods-perf-profiler.md)
