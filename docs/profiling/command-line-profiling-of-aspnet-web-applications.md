---
title: "Command-Line Profiling of ASP.NET Web Applications | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling ASP.NET applications"
  - "profling tools,ASP.NET applications"
ms.assetid: 897c00d5-5767-433b-a960-4a29c6023ede
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "aspnet"
---
# Command-line profiling of ASP.NET web applications
This section describes the procedures and options for collecting performance data for [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications by using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools from the command line.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## Common tasks

| Task | Related Content |
| - | - |
| **Collect basic ASP.NET profiling data easily:** Use the **VSPerfASPNETCmd** tool to collect sampling, instrumentation, .NET memory, contention, or tier interaction data without the configuration requirements and the Internet Information Services (IIS) restarts that are needed for **VSPerfCmd**. **VSPerfASPNETCmd** does not allow you to collect additional data or to control data collection. **Note:**  **VSPerfASPNETCmd** is the preferred tool to use you use the standalone profiler to profile ASP.NET Web sites. | -   [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md) |
| **Collect application statistics:** Use the sampling method to collect performance statistics. Sampling data is useful for analyzing CPU usage issues and for understanding the general performance characteristics of an application. | -   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-aspnet-using-the-profiler-sampling-method.md) |
| **Collect detailed timing data:** Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing IO issues and for fine-grained analysis of application scenarios. | -   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-aspnet-profiler-instrumentation-method.md) |
| **Collect .NET memory data:** Use sampling or instrumentation to collect .NET memory allocation data that shows you the size and number of allocated objects. You can also collect object lifetime data that shows you the size and number of objects that are reclaimed in each garbage collection generation. | -   [Collect memory data](../profiling/collecting-memory-data-from-an-aspnet-web-application.md) |
| **Collect concurrency data:** Use the concurrency method to collect resource contention data. **Note:**  Collecting thread activity and visualization data is not supported for Web applications. | -   [Collect concurrency data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application.md) |
| **Add tier interaction data:** You can add performance data about synchronous [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] calls that the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application makes to a Microsoft [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database. | -   [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md) |

## Related tasks

|Task|Related Content|
|----------|---------------------|
|**Profile stand-alone (client) applications**|-   [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)|
|**Profile services**|-   [Profile services](../profiling/command-line-profiling-of-services.md)|
