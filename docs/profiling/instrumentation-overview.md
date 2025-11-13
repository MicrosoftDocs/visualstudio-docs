---
title: Explore instrumentation tools for your apps
description: Explore the tools you can use to instrument your applications in Visual Studio, including dynamic and static instrumentation.
ms.date: "05/01/2024"
ms.topic: article
ms.custom: "profiling-seo"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Instrumentation in Visual Studio (C#, Visual Basic, C++, F#)

This article describes the instrumentation tools in Visual Studio, which are used for collecting exact call counts and call times.

There are two types of instrumentation:

- Static, which modifies the program’s files before it runs (VSInstr)

- Dynamic, which uses a dynamic process where it doesn’t change the files. It loads the files to memory and then modifies them to collect the instrumentation info. Using the dynamic instrumentation tool, you get more accurate information, but for a smaller part of the program. You can investigate small sections of code.

Dynamic instrumentation is helpful because:

- Static instrumentation breaks strong name signing. With dynamic instrumentation, this issue is avoided because instrumentation happens at runtime.

- With static instrumentation, files need to be deployed in a specific order and the tool may not know where the files are. You need to manually run VSInstr. With the new instrumentation tool, you don’t have to go find the files. On a complicated program, finding all the files can be a difficult, manual process.

## Instrumentation versus sampling

When it comes to profiling, there's two mechanisms of collecting data. Collection using instrumentation or collection using sampling. For detailed information, see [Understanding performance collection methods](../profiling/understanding-performance-collection-methods-perf-profiler.md).

## Dynamic instrumentation tool

::: moniker range=">=vs-2022"

**Instrumentation** - Starting in Visual Studio 2022 version 17.5, the Instrumentation tool provides dynamic instrumentation for .NET Core, .NET 5+, and .NET Framework. This tool provides the best performance for instrumentation scenarios. Access this tool using the Performance Profiler (Alt + F2). For more information, see the following article:

- [Instrument your application](../profiling/instrumentation.md)

Starting in Visual Studio 2022 version 17.6, the Instrumentation tool also supports C/C++, but uses static instrumentation (VSInstr).

To use this tool from the command-line, see the following article:

- [Profiling apps from the command-line](../profiling/profile-apps-from-command-line.md).
::: moniker-end

::: moniker range="vs-2019"

**Instrumentation** - Starting in Visual Studio 2019 version 16.9, the Instrumentation tool provides dynamic instrumentation for .NET Core, .NET 5+, and .NET Framework (not C/C++). This tool uses a version of VSInstr.exe that supports dynamic instrumentation. Access this tool using the Performance Profiler (Alt + F2). For DLLs, you need to use the command-line tool (VSInstr) instead.
::: moniker-end

## Static instrumentation tool

**VSInstr** - Starting in Visual Studio 2022 version 17.6, the [Instrumentation tool](../profiling/instrumentation.md) uses VSInstr for C/C++ support. VSInstr is also used for command-line scenarios and works for .NET Framework and C/C++ apps. For more information, see the following article:

- [Collect detailed timing data for a stand-alone application by using the profiler command line](/visualstudio/profiling/profile-apps-from-command-line).

## Related content

- [Case study: Isolate a performance issue](../profiling/isolate-performance-issue.md)
- [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/).
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
