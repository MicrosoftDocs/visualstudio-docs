---
title: "Command-Line Profiling of Services | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling toos,services"
  - "profiling services"
ms.assetid: f0d62318-b0e8-49c6-9a30-9f7a6adef2f6
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Command-line profiling of services
This section describes the procedures and options for collecting performance data for Windows services by using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools from the command line.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## Common tasks

| Task | Related Content |
| - | - |
| **Collect application statistics:** Use the sampling method to collect performance statistics. Sampling data is useful for analyzing CPU utilization issues and for understanding the general performance characteristics of an application. | -   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-services-by-using-the-profiler-sampling-method.md) |
| **Collect detailed timing data:** Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing IO issues and for fine-grained analysis of application scenarios. | -   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-for-services-by-using-the-instrumentation-method.md) |
| **Collect .NET memory data:** Use sampling or instrumentation to collect .NET memory allocation data that shows you the size and number of allocated objects. You can also collect object lifetime data that shows you the size and number of objects that are reclaimed in each garbage collection generation. | -   [Collect .NET memory data](../profiling/collecting-memory-data-from-dotnet-framework-services-by-using-the-profiler-command-line.md) |
| **Collect concurrency data:** Use the concurrency method to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped IO, and other system events. | -   [Collect concurrency data](../profiling/collecting-concurrency-data-for-a-service-by-using-the-profiler-command-line.md) |
| **Add tier interaction data:** You can add performance data about synchronous ADO.NET calls that the service made to a Microsoft [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database. | -   [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md) |

## Related tasks

|Task|Related Content|
|----------|---------------------|
|**Profile stand-alone (client) applications**|-   [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)|
|**Profile ASP.NET applications**|-   [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)|
