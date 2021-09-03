---
title: "Use command line profiling methods to get performance data"
description: Learn how choice of Visual Studio Profiling Tools command-line tools and options depends on factors such as the type of application that you are profiling.
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 5613fafc-f298-4e7a-9a2d-a853b61cdf9c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Use profiling methods to collect performance data from the command line
Your choice of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools and options depends on factors such as the type of application that you are profiling, the profiling method that you want to use, and whether the target application is written in native or .NET Framework code.

 This topic organizes the command-line procedural topics according to the profiling method that you choose.

## Use the sampling method to collect performance statistics
 The Profiling Tools sampling method collects performance data at specified intervals in a profiling run. Sampling data can provide insights into CPU-bound performance issues, and it can be a good way to start exploring the performance of an application.

 You can start the profiler and the application at the same time, or you can attach the profiler to a running instance of an application.

|Task|Target application type|
|----------|-----------------------------|
|**Launch an application**|-   [Stand-alone applications](../profiling/how-to-launch-a-stand-alone-app-and-collect-application-statistics.md)|
|**Attach to a running process**|-   [.NET Framework stand-alone applications](../profiling/how-to-attach-the-profiler-to-a-dotnet-app-and-collect-application-statistics.md)<br />-   [Native stand-alone applications](../profiling/how-to-attach-the-profiler-to-a-native-app-and-collect-application-statistics.md)<br />-   [ASP.NET web applications](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-application-statistics-by-using-the-command-line.md)<br />-   [.NET services](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-application-statistics-by-using-the-command-line.md)<br />-   [Native services](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-application-statistics-by-using-the-command-line.md)|

## Use the instrumentation method to collect detailed timing data
 The Profiling Tools instrumentation method collects performance data from copies of application binaries that contain software probes to record performance information. Instrumentation data is collected at the start and end of each instrumented function and at every call to other functions from the instrumented function. The instrumentation method is useful for discovering performance issues with I/O issues such as disk usage.

 You create the instrumented binary with the [VInstr.exe](../profiling/vsinstr.md) tool. After you initialize the profiler, data is automatically collected from the instrumented binaries when you run the target application.

 **Target Application Type**

- [.NET Framework stand-alone components](../profiling/how-to-instrument-a-dotnet-framework-component-and-collect-timing-data.md)

- [Native stand-alone components](../profiling/how-to-instrument-a-native-component-and-collect-timing-data.md)

- [Statically compiled ASP.NET web applications](../profiling/how-to-instrument-statically-compiled-aspnet-and-collect-detailed-timing-data.md)

- [Dynamically compiled ASP.NET web applications](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-app-and-collect-timing-data.md)

- [.NET services](../profiling/how-to-instrument-a-dotnet-service-and-collect-detailed-timing-data-by-using-the-profiler-command-line.md)

- [Native services](../profiling/how-to-instrument-a-native-service-and-collect-detailed-timing-data-by-using-the-profiler-command-line.md)

## Use .NET memory methods to collect memory allocation and object lifetime data
 The Profiling Tools .NET memory method enables you to collect .NET Framework memory allocation data and information about the lifetime of objects in the .NET Framework.

 You can start the target application by using the profiler; you can attach the profiler to a running instance of an application; and you can create instrumented versions of the application to collect detailed timing information together with the .NET Framework memory data.

|Task|Target application type|
|----------|-----------------------------|
|**Launch an application**|-   [Stand-alone .NET Framework applications](../profiling/how-to-launch-a-stand-alone-dotnet-framework-app-to-collect-memory-data.md)|
|**Attach to a running process**|-   [.NET Framework stand-alone applications](../profiling/how-to-attach-the-profiler-to-a-dotnet-framework-app-to-collect-memory-data.md)<br />-   [ASP.NET web applications](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-memory-data-by-using-the-command-line.md)<br />-   [.NET services](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-memory-data-by-using-the-command-line.md)|
|**Instrument modules**|-   [.NET Framework stand-alone components](../profiling/how-to-instrument-a-dotnet-framework-component-and-collect-memory-data.md)<br />-   [Statically compiled ASP.NET web applications](../profiling/how-to-instrument-a-statically-compiled-aspnet-app-and-collect-memory-data.md)<br />-   [Dynamically compiled ASP.NET web applications](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-web-application-and-collect-memory-data.md)<br />-   [.NET services](../profiling/how-to-instrument-a-dotnet-framework-service-and-collect-memory-data-by-using-the-profiler-command-line.md)|

## Use the concurrency method to collect resource contention and thread activity data
 The Profiling Tools concurrency method enables you to collect resource contention and thread and process activity data from multithreaded applications.

 You can start the application by using the profiler, or you can attach the profiler to a running instance of an application.

|Task|Target application type|
|----------|-----------------------------|
|**Launch an application**|-   [Stand-alone .NET Framework application](../profiling/how-to-launch-a-stand-alone-dotnet-framework-app-to-collect-concurrency-data.md)<br />-   [Stand-alone native application](../profiling/how-to-launch-a-stand-alone-native-application-to-collect-concurrency-data.md)|
|**Attach to a running process**|-   [.NET Framework stand-alone application](../profiling/how-to-attach-the-profiler-to-a-dotnet-app-and-collect-concurrency-data.md)<br />-   [Native stand-alone application](../profiling/how-to-attach-the-profiler-to-a-native-app-and-collect-concurrency-data.md)<br />-   [ASP.NET web application](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [.NET service](../profiling/how-to-attach-the-profiler-to-a-dotnet-service-to-collect-concurrency-data-by-using-the-command-line.md)<br />-   [Native service](../profiling/how-to-attach-the-profiler-to-a-native-service-to-collect-concurrency-data-by-using-the-command-line.md)|

## Add tier interaction data to a profiling run
 Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)

## See also
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
