---
title: Profiler command line - Timing data detail for stand-alone app
description: Learn how to use the instrumentation method from the command line to collect detailed performance data for a stand-alone component.
ms.date: 11/01/2022
ms.topic: how-to
helpviewer_keywords: 
  - profiling tools,instrumentation method
  - instrumentation profiling method
ms.assetid: 4017d9d1-d609-4f41-8e4e-976abae746b3
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Collect detailed timing data for a stand-alone application by using the profiler command line

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article describes the procedures and options for collecting detailed performance data for a client (stand-alone) component such as a DLL by using the instrumentation method from the command line. Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing I/O issues and for fine-grained analysis of application scenarios.

Using [VSInstr](../profiling/vsinstr.md), you can instrument DLLs for which you would like timing information and then use [VSPerfCmd](../profiling/vsperfcmd.md) to capture the trace. This will generate a *.vsp* file that can then be loaded and analyzed in Visual Studio.

## Common tasks

|Task|Related content|
|----------|---------------------|
|**Profile a .NET Framework application by using instrumentation**|-   [How to: Instrument a .NET component and collect detailed timing data](../profiling/instrument-dotnet-framework-component-and-collect-timing-data.md)|
|**Profile a C/C++ application by using instrumentation**|-   [How to: Instrument a native component and collect detailed timing data](../profiling/instrument-native-component-and-collect-timing-data.md)|
|**Add tier-interaction data**|-   [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)|

## Reference

- [VSIntr](../profiling/vsinstr.md)
- [VSPerfCmd](../profiling/vsperfcmd.md)
