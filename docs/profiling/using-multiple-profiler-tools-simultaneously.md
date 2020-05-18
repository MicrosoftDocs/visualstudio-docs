---
title: "Using multiple profiler tools simultaneously | Microsoft Docs"
ms.date: "4/29/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiler, multiple tools"
author: "Sagar-S-S"
ms.author: "sashe"
manager: AndSter
ms.workload:
  - "multiple"
---

# Using multiple profiler tools simultaneously

The Performance Profiler was designed with the idea that multiple tools can be used in the same session to aid in understanding performance issues. Most tools in the Performance Profiler support running concurrently such as the [CPU Usage](../profiling/cpu-usage.md), [.NET Async Tool](../profiling/analyze-async.md), and [Database](../profiling/analyze-database.md) tool. To run tools simultaneously in the same diagnostic session simply click the check box next to them and then start the diagnostic session.

![Diag Hub All Tools Selected](../profiling/media/diaghuballtoolsselected.png "Diag Hub All Tools Selected")

>[!NOTE]
>Certain tools such as the [.NET Object Allocation](../profiling/dotnet-alloc-tool.md) tool cannot be run with other tools due to the high overhead that they have or due to other technical limitations.

During analysis time filtering operations are applied across tools, thus you can use information in one tool to narrow down a time range and filter data in another tool. This helps guide analysis to specific points in a trace and understand the state of the application.

![Diag Hub Time Filtering](../profiling/media/diaghubtimefiltering.png "Diag Hub Time Filtering")

## See also

- [Optimizing profiler settings](../profiling/optimizing-profiler-settings.md)
- [Running profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md)
- [Understanding performance collection methods](../profiling/understanding-performance-collection-methods.md)

