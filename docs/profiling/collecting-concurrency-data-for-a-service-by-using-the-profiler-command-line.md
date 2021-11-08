---
title: Profiler command line - Get concurrency data for service
description: Collect resource contention data and thread activity data using the concurrency method of Visual Studio Profiling Tools.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 275aacba-b2af-4d34-8931-ee30d777a256
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# Collect concurrency data for a service by using the profiler command line
The concurrency method of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools enables you to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped IO, and other system events.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## Common tasks

|Task|Related Content|
|----------|---------------------|
|**Attach to a running .NET service**|-   [How to: Attach the profiler to a .NET service to collect concurrency data](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-concurrency-data-by-using-the-command-line.md)|
|**Add tier-interaction data**|-   [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)|
|**Attach to a running C/C++ service**|-   [How to: Attach the profiler to a native service to collect concurrency data](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-concurrency-data-by-using-the-command-line.md)|

## Related tasks

### Profile Windows services

|Task|Related Content|
|----------|---------------------|
|**Profile by using the sampling method**|-   [Collect application statistics using sampling](../profiling/collecting-application-statistics-for-services-by-using-the-profiler-sampling-method.md)|
|**Profile by using the instrumentation method**|-   [Collect detailed timing data using instrumentation](../profiling/collecting-detailed-timing-data-for-services-by-using-the-instrumentation-method.md)|
|**Profile.NET memory allocation and garbage collection**|-   [Collect .NET memory data](../profiling/collecting-memory-data-from-dotnet-framework-services-by-using-the-profiler-command-line.md)|

### Profile concurrency data

|Task|Related Content|
|----------|---------------------|
|**Profile stand-alone applications**|-   [Collect concurrency data](../profiling/collecting-concurrency-data-for-stand-alone-applications.md)|
|**Profile ASP.NET Web applications**|-   [Collect concurrency data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application.md)|

### Analyze concurrency data views and reports
- [Resource contention data views](../profiling/resource-contention-data-views.md)

- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)

## Reference
- [Command-line profiling tools reference](../profiling/command-line-profiling-tools-reference.md)
