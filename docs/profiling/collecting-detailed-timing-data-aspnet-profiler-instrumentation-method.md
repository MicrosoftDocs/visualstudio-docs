---
title: "VSPerfCmd: Get timing data for ASP.NET web app using instrumentation"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools,instrumentation method"
  - "instrumentation profiling method"
ms.assetid: 29f2fc55-aaf7-4e18-a672-8815455fba73
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "aspnet"
---
# Collect detailed timing data for an ASP.NET web application using the profiler instrumentation method from the command line
This section describes the procedures and options for collecting detailed performance data for an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application by using the **VSPerfCmd** command line tool and the instrumentation method.

> [!NOTE]
> The **VSPerfCmd** tool provides you with complete access to Profiling Tools functionality, including pausing and resuming profiling, and collecting additional data from processor and Windows performance counters. You can also use the  **VSPerfASPNETCmd** command-line tool when you do not need this functionality. In comparison to the [VSPerfCmd](../profiling/vsperfcmd.md) command-line tool, no environment variables have to be set, and rebooting the computer is not required. For more information, see [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).

## Common tasks

|Task|Related Content|
|----------|---------------------|
|**Profile statically compiled binaries**|-   [How to: Instrument a statically compiled ASP.NET application and collect detailed timing data](../profiling/how-to-instrument-statically-compiled-aspnet-and-collect-detailed-timing-data.md)|
|**Profile dynamically compiled binaries**|-   [How to: Instrument a dynamically compiled ASP.NET application and collect detailed timing data](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-app-and-collect-timing-data.md)|

## Related tasks

### Profile ASP.NET web applications

|Task|Related Content|
|----------|---------------------|
|**Profile by using the sampling method**|-   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-aspnet-using-the-profiler-sampling-method.md)|
|**Profile memory allocation and garbage collection**|-   [Collect memory data](../profiling/collecting-memory-data-from-an-aspnet-web-application.md)|
|**Profile resource contention and thread activity**|-   [Collect concurrency data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application.md)|

### Profile by using the instrumentation method

|Task|Related Content|
|----------|---------------------|
|**Profile stand-alone (client) applications**|-   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-for-a-stand-alone-application.md)|
|**Profile services**|-   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-for-services-by-using-the-instrumentation-method.md)|

### Analyze instrumentation data views and reports
- [Instrumentation method data views](../profiling/instrumentation-method-data-views.md)
