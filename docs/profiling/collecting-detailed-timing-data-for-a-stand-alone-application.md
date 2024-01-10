---
title: Profiler command line - Timing data detail for stand-alone app
description: Learn how to use the instrumentation method from the command line to collect detailed performance data for a stand-alone component.
ms.date: 06/28/2023
ms.topic: how-to
helpviewer_keywords: 
  - profiling tools,instrumentation method
  - instrumentation profiling method
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: debug-diagnostics
---
# Collect detailed timing data for a stand-alone application by using the profiler command line

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article describes the procedures and options for collecting detailed performance data for a client (stand-alone) component such as a DLL by using the instrumentation method from the command line. Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing I/O issues and for fine-grained analysis of application scenarios.

> [!NOTE]
> For .NET Core and .NET 5+, see [Measure application performance from the command line](../profiling/profile-apps-from-command-line.md) for command line instrumentation scenarios. VSInstr is not supported for .NET Core and .NET 5+ binaries. Starting in Visual Studio 2022 version 17.6, we recommend using [VSDiagnostics.exe](../profiling/profile-apps-from-command-line.md) for .NET Framework scenarios as well, since it provides dynamic instrumentation.

Using [VSInstr](../profiling/vsinstr.md), you can instrument DLLs for which you would like timing information and then use [VSPerfCmd](../profiling/vsperfcmd.md) to capture the trace. This will generate a *.vsp* file that can then be loaded and analyzed in Visual Studio.

## Common tasks

|Task|Related content|
|----------|---------------------|
|**Profile a .NET Framework application by using instrumentation**|-   [Instrument a .NET component and collect detailed timing data](../profiling/instrument-dotnet-framework-component-and-collect-timing-data.md)|
|**Profile a C/C++ application by using instrumentation**|-   [Instrument a native component and collect detailed timing data](../profiling/instrument-native-component-and-collect-timing-data.md)|

## Related content

- [VSIntr](../profiling/vsinstr.md)
- [VSPerfCmd](../profiling/vsperfcmd.md)
