---
title: "Instrumentation"
description: Learn about the tools you can use to instrument your applications.

ms.date: "11/04/2022"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---

# Instrumentation in Visual Studio (C#, Visual Basic, C++, F#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article describes the instrumentation tools in Visual Studio, which are used for collecting exact call counts and call times.

There are two types of instrumentation:

- Static, which modifies the program’s files before it runs (VSInstr)

- Dynamic, which uses a dynamic process where it doesn’t change the files. It loads the files to memory and then modifies them to collect the instrumentation info. Using the dynamic instrumentation tool, you get more accurate information but for a smaller part of the program. You can investigate small sections of code.

Dynamic instrumentation is helpful because:

- Static instrumentation breaks strong name signing. With dynamic instrumentation, this issue is avoided because instrumentation happens at runtime.

- With static instrumentation, files need to be deployed in a specific order and the tool may not know where the files are. You need to manually run VSInstr. With the new instrumentation tool, you don’t have to go find the files. On a complicated program, finding all the files can be a difficult, manual process.

## Instrumentation versus sampling

When it comes to profiling, there's two mechanisms of collecting data. Collection using instrumentation or collection using sampling. For detailed information, see [Understanding performance collection methods](../profiling/understanding-performance-collection-methods-perf-profiler.md).

## Instrumentation tools and methods

::: moniker range=">=vs-2022"

- **.NET Instrumentation** Starting in Visual Studio 2022 version 17.5 Preview 1, the .NET Instrumentation tool provides dynamic instrumentation for .NET Core, .NET 5+, and .NET Framework (not C/C++). This tool provides the best performance for instrumentation scenarios. Access this tool using the Performance Profiler (Alt + F2). For more information, see [Instrument your application](../profiling/instrumentation.md). For DLLs, you need to use the command-line tool (VSInstr) instead.
::: moniker-end

- **Instrumentation** Starting in Visual Studio 2019 version 16.9, the Instrumentation tool provides dynamic instrumentation for .NET Core, .NET 5+, and .NET Framework (not C/C++). This tool uses a version of VSInstr.exe that supports dynamic instrumentation. Access this tool using the Performance Profiler (Alt + F2). For DLLs, you need to use the command-line tool (VSInstr) instead.

- **Command-line instrumentation** This tool provides static instrumentation using [VSInstr](../profiling/vsinstr.md) and works for .NET Framework, .NET 5+, and C/C++ apps. For instrumenting DLLs, the command-line tool is the only option. For more information, see [Collect detailed timing data for a stand-alone application by using the profiler command line](../profiling/collecting-detailed-timing-data-for-a-stand-alone-application.md).

## See Also

[First look at profiling tools](../profiling/profiling-feature-tour.md)
