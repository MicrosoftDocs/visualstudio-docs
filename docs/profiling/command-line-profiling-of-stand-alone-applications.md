---
title: "Command-Line Profiling of Stand-Alone Applications | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profillng tools,stand-alone applications"
  - "profling stand-alone applications"
ms.assetid: a47f2bf2-186d-4120-bb79-34e2f3a1ee42
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Command-line profiling of stand-alone applications
This section describes the procedures and options for collecting performance data for stand-alone (client) applications by using the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools from the command line.

## Common tasks

| Task | Related content |
| - | - |
| **Collect application statistics:** Use the sampling method to collect performance statistics. Sampling data is useful for analyzing CPU utilization issues and for understanding the general performance characteristics of an application. | -   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-stand-alone-applications.md) |
| **Collect detailed timing data:** Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing I/O issues and for fine-grained analysis of application scenarios. | -   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-for-a-stand-alone-application.md) |
| **Collect .NET memory data:** Use sampling or instrumentation to collect .NET memory allocation data that shows you the size and number of allocated objects. You can also collect object lifetime data that shows you the size and number of objects that are reclaimed in each garbage collection generation. | -   [Collect .NET Framework memory data](../profiling/collecting-dotnet-framework-memory-data-for-stand-alone-applications.md) |
| **Collect concurrency data:** Use the concurrency method to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped I/O, and other system events. | -   [Collect concurrency data](../profiling/collecting-concurrency-data-for-stand-alone-applications.md) |
| **Add tier-interaction data:** You can add performance data about synchronous ADO.NET calls that the application made to a Microsoft [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database. Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. | -   [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md) |
| **Try it out:** Use step-by-step procedures to profile a sample client application by using the sampling or instrumentation method. | -   [Walkthrough: Command-line profiling using sampling](../profiling/walkthrough-command-line-profiling-using-sampling.md)<br />-   [Walkthrough: Command-line profiling using instrumentation](command-line-profiling-of-stand-alone-applications.md) |

## Related tasks

|Task|Related Content|
|----------|---------------------|
|**Profile ASP.NET applications**|-   [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)|
|**Profile services**|-   [Profile services](../profiling/command-line-profiling-of-services.md)|
