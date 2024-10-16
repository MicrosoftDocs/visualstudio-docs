---
title: Profiler command line - Instrument native component, get timing data
description: Learn how to use the Visual Studio Profiling Tools command-line tools to collect detailed timing data for a native component such as a C++ .exe or .dll file.
ms.date: 06/12/2024
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Instrument a native stand-alone component and collect timing data with the profiler from the command line

This article describes how to use Visual Studio command-line profiling tools to instrument a native component, such as a C++ .*exe* or .*dll* file, to collect detailed timing data.

To collect detailed timing data from a native component by using the instrumentation method, use the [VSInstr.exe](../profiling/vsinstr.md) tool to generate an instrumented version of the component. Next, start the profiler in the same way as the other [command line scenarios](../profiling/profile-apps-from-command-line.md) using the *PerfInstrumentation.json* agent configuration. When the instrumented component is executed, timing data is automatically collected to a *.diagsession* file.

The path to the profiling tools is *Microsoft Visual Studio\version\Enterprise\Team Tools\DiagnosticsHub\Collector*.

> [!NOTE]
> To use the profiler command-line tools, you must either use the Visual Studio Developer Command Prompt or add the tools path to the PATH environment variable of the Command Prompt window.

## Instrument with VSInstr

To instrument a native component such as a C++ .*exe* or .*dll* file run:

```cmd
VSInstr /d:new ModuleToProfile.dll
```

You can optionally pass `/EXCLUDESMALLFUNCS` to exclude small functions from instrumentation reducing the overhead of the tool and giving more accurate results.

> [!NOTE]
> Starting with Visual Studio 17.11 Preview 3 the `/d:new` flag isn't needed because it's set by default.

## Related content

- [VSInstr](../profiling/vsinstr.md)