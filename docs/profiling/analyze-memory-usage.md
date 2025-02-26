---
title: "Choose a memory analysis tool"
description: Learn about the tools you can use to find memory leaks and inefficient memory usage, tools such as the Memory Usage tool and the .NET Object Allocation tool.
ms.date: "01/06/2024"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Choose a memory analysis tool in Visual Studio (C#, Visual Basic, C++, F#)

To find memory leaks and inefficient memory usage, you can use tools such as the debugger-integrated Memory Usage diagnostic tool or tools in the Performance Profiler such as the .NET Object Allocation tool and the post-mortem Memory Usage tool. Performance Profiler tools are intended primarily for release builds. For more information, see [Run profiling tools on release or debug builds](../profiling/running-profiling-tools-with-or-without-the-debugger.md).

The Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap. You can collect snapshots of .NET, ASP.NET, C++, or mixed mode (.NET and native) apps. The **Memory Usage** tool can run on an open Visual Studio project, on an installed Microsoft Store app, or attached to a running app or process.

.NET developers may choose between either the .NET Object Allocation tool or the Memory Usage tool.

- The [.NET Object Allocation tool](../profiling/dotnet-alloc-tool.md) helps you identify allocation patterns and anomalies in your .NET code, and helps identify common issues with garbage collection. This tool runs only as a post-mortem tool. You can run this tool on local or remote machines.
- The [Memory Usage tool](../profiling/memory-usage-without-debugging2.md) is helpful in identifying memory leaks, which aren't typically common in .NET apps. If you need to use debugger features while checking memory, such as stepping through code, the [debugger-integrated Memory usage](../profiling/memory-usage.md) tool is recommended. In the debugger, you can turn memory profiling on and off, and see a per-object breakdown of memory usage. You can view memory usage results when execution is paused, for example at a breakpoint.

C++ developers can use Memory Usage tool on debug or release builds:

- [Measure memory usage on debug builds](../profiling/memory-usage.md)
- [Analyze memory usage on release builds](../profiling/memory-usage-without-debugging2.md)

## Blogs and videos

[Analyze CPU and memory while debugging](https://devblogs.microsoft.com/visualstudio/analyze-cpu-memory-while-debugging/)

[Visual C++ blog: Memory profiling in Visual C++ 2015](https://devblogs.microsoft.com/cppblog/memory-profiling-in-visual-c-2015/)

## Related content

- [Profiling in Visual Studio](../profiling/index.yml)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
- [Troubleshoot Profiler errors](../profiling/troubleshoot-profiler-errors.md)
