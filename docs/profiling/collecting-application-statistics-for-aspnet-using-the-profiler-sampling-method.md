---
title: "Collect statistics for ASP.NET web apps | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools, sampling method"
  - "sampling profling method"
ms.assetid: f8383ab1-eb49-4d3f-8608-d8b4d51a81be
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "aspnet"
---
# Collect statistics for ASP.NET web apps

This section describes the procedures and options for collecting performance statistics for an ASP.NET Web application by using the **VSPerfASPNETCmd** and **VSPerfCmd** command-line tool and the sampling profiling method.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

> [!NOTE]
> Although the **VSPerfCmd** tool gives you complete access to Profiling Tools functionality, including pausing and resuming profiling, and collecting additional data from processor and Windows performance counters, you should use the  **VSPerfASPNETCmd** command line tool when you do not need this functionality. The **VSPerfASPNETCmd** command line tool is the preferred method when your are profiling ASP.NET Web sites using the stand-alone profiler. Compared with the [VSPerfCmd](../profiling/vsperfcmd.md) command line tool, no environment variables need to be set, and rebooting the computer is not required. For more information, see [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).

## Common tasks

|Task|Related Content|
|----------|---------------------|
|**Attach the profiler to an ASP.NET application**|-   [How to: Attach the profiler to an ASP.NET web application to collect application statistics](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-application-statistics-by-using-the-command-line.md)|

## Related tasks

### Profile ASP.NET web applications

|Task|Related Content|
|----------|---------------------|
|**Profile by using the instrumentation method**|-   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-aspnet-profiler-instrumentation-method.md)|
|**Profile memory allocation and garbage collection**|-   [Collect memory data](../profiling/collecting-memory-data-from-an-aspnet-web-application.md)|
|**Profile resource contention and thread activity**|-   [Collect concurrency data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application.md)|

### Sample method

|Task|Related Content|
|----------|---------------------|
|**Profile stand-alone (client) applications**|-   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-stand-alone-applications.md)|
|-   **Profile services**|-   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-services-by-using-the-profiler-sampling-method.md)|

### Analyze sampling data views and reports
- [Sampling method data views](../profiling/profiler-sampling-method-data-views.md)
