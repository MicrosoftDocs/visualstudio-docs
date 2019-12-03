---
title: "Get ASP.NET web app memory data using profiler command line"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - ".NET memory profiling method"
  - "profiling tools,.NET memory method"
ms.assetid: 57acf2b0-327a-4c0e-8078-ac2f6d99457d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "aspnet"
---
# Collect memory data from an ASP.NET web application by using the profiler command line
This section describes the procedures and options for collecting memory allocation and object lifetime data for an ASP.NET Web application by using the **VSPerfCmd** command-line tool.

> [!NOTE]
> The **VSPerfCmd** tool provides you with complete access to Profiling Tools functionality, including pausing and resuming profiling, and collecting additional data from processor and Windows performance counters. You can also use the  **VSPerfASPNETCmd** command-line tool when you do not need this functionality. Compared with the [VSPerfCmd](../profiling/vsperfcmd.md) command line tool, no environment variables need to be set, and rebooting the computer is not required. For more information, see [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).

## Common tasks

|Task|Related Content|
|----------|---------------------|
|**Attach the profiler to a running ASP.NET application**|-   [How to: Attach the profiler to an ASP.NET web application to collect memory data](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-memory-data-by-using-the-command-line.md)|
|**Instrument statically compiled binaries**|-   [How to: Instrument a statically compiled ASP.NET application and collect memory data](../profiling/how-to-instrument-a-statically-compiled-aspnet-app-and-collect-memory-data.md)|
|**Instrument dynamically compiled binaries**|-   [How to: Instrument a dynamically compiled ASP.NET application and collect memory data](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-web-application-and-collect-memory-data.md)|

## Related tasks

### Profile ASP.NET web applications

|Task|Related Content|
|----------|---------------------|
|**Profile by using the sampling method**|-   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-aspnet-using-the-profiler-sampling-method.md)|
|**Profile by using the instrumentation method**|-   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-aspnet-profiler-instrumentation-method.md)|
|**Profile resource contention and thread activity**|-   [Collect concurrency data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application.md)|

### Profile .NET Framework memory data

|Task|Related Content|
|----------|---------------------|
|**Profile stand-alone (client) applications**|-   [Collect .NET Framework memory data](../profiling/collecting-dotnet-framework-memory-data-for-stand-alone-applications.md)|
|**Profile services**|-   [Collect .NET memory data](../profiling/collecting-memory-data-from-dotnet-framework-services-by-using-the-profiler-command-line.md)|

### Analyze .NET memory data views and reports
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)

## Reference
- [Command-line profiling tools reference](../profiling/command-line-profiling-tools-reference.md)
