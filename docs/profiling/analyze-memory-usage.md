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
Use the debugger-integrated **Memory Usage** diagnostic tool to find memory leaks and inefficient memory usage. The Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap. You can collect snapshots of .NET, ASP.NET, native, or mixed mode (.NET and native) apps.

- You can analyze a single snapshot to understand the relative impact of the object types on memory use, and to find code in your app that uses memory inefficiently.

- You can also compare (diff) two snapshots of an app to find areas in your code that cause the memory use to increase over time.

For detailed instructions, see the [Analyze memory usage](../profiling/memory-usage.md) tutorial.  Currently, to measure memory usage for a .NET Core app, you need to use the tool with the debugger attached. For other managed and native apps, you can use the tool either with or without the debugger attached.

You can use the profiling tools without the debugger with Windows 7 and later. Windows 8 and later is required to run profiling tools with the debugger (**Diagnostic Tools** window).

## Blogs and videos

[Analyze CPU and memory while debugging](https://devblogs.microsoft.com/visualstudio/analyze-cpu-memory-while-debugging/)

[Visual C++ blog: Memory profiling in Visual C++ 2015](https://devblogs.microsoft.com/cppblog/memory-profiling-in-visual-c-2015/)

## See also

- [Profiling in Visual Studio](../profiling/index.yml)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)