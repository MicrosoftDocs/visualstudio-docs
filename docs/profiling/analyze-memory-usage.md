---
title: "Analyze memory usage"
ms.custom: "seodec18"
ms.date: "01/02/2018"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Analyze memory usage

to find memory leaks and inefficient memory usage, you can use tools such as the debugger-integrated Memory Usage diagnostic tool or tools in the Performance Profiler such as the .NET Object Allocation tool and the post-mortem Memory Usage tool. The debugger-integrated Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap. You can collect snapshots of .NET, ASP.NET, native, or mixed mode (.NET and native) apps. For more information on running memory tools with the debugger attached or post-mortem, see [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md).

- You can analyze a single snapshot to understand the relative impact of the object types on memory use, and to find code in your app that uses memory inefficiently.

- You can also compare (diff) two snapshots of an app to find areas in your code that cause the memory use to increase over time.

For detailed instructions, see the [Analyze memory usage](../profiling/memory-usage.md) tutorial and the [.NET Object Allocation tool](../profiling/dotnet-alloc-tool.md).

You can use the profiling tools without the debugger with Windows 7 and later. Windows 8 and later is required to run profiling tools with the debugger (**Diagnostic Tools** window).

## Blogs and videos

[Analyze CPU and memory while debugging](https://devblogs.microsoft.com/visualstudio/analyze-cpu-memory-while-debugging/)

[Visual C++ blog: Memory profiling in Visual C++ 2015](https://devblogs.microsoft.com/cppblog/memory-profiling-in-visual-c-2015/)

## See also

- [Profiling in Visual Studio](../profiling/index.yml)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
- [Analyze memory usage without the debugger](../profiling/memory-usage-without-debugging2.md)
