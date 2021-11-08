---
title: "Understanding performance collection methods | Microsoft Docs"
description: Learn about the different scenarios in which collecting data with a particular method might be appropriate.
ms.date: "4/30/2020"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.wizard.methodpage"
helpviewer_keywords:
  - "Profiling tools, profiling methods"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---

# Understand performance collection methods

Visual Studio Profiling tools provide five methods for collecting performance data. This article describes the different methods and suggests scenarios in which collecting data with a particular method might be appropriate.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in how the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

|Method|Description|
|------------|-----------------|
|[Sampling](#sampling)|Collects statistical data about the work done by an app.|
|[Instrumentation](#instrumentation)|Collects detailed timing information about each function call.|
|[Concurrency](#concurrency)|Collects detailed information about multithreaded apps.|
|[.NET memory](#net-memory)|Collects detailed information about .NET memory allocation and garbage collection.|
|[Tier interaction](#tier-interaction)|Collects information about synchronous ADO.NET function calls to a SQL Server database.<br /><br /> Any edition of Visual Studio can collect tier-interaction profile data. However, you can view that data only in Visual Studio Enterprise.|

By using some of the profiling methods, you can also collect additional data like software and hardware performance counters. For more information, see [Collect additional performance data](../profiling/collecting-additional-performance-data.md).

## Sampling

The sampling profiling method collects statistical data about the work that an app does during a profiling run. The sampling method is lightweight and has little effect on the execution of app methods.

Sampling is the default method of the Visual Studio Profiling tools. It's useful for the following tasks:

- Initial explorations of your app's performance
- Investigating performance issues that involve the utilization of the microprocessor (CPU)

The sampling profiling method interrupts the computer CPU at set intervals and collects the function call stack. Exclusive sample counts are incremented for the function that is running. Inclusive counts are incremented for all the calling functions on the call stack. Sampling reports present the totals of these counts for the profiled modules, functions, source-code lines, and instructions.

By default, the profiler sets the sampling interval to CPU cycles. You can change the interval type to another CPU performance counter or set the number of counter events for the interval. You can also collect tier-interaction profiling (TIP) data. This data provides information about the queries made to a SQL Server database through ADO.NET.

[Collect performance statistics by using sampling](../profiling/collecting-performance-statistics-by-using-sampling.md)

[Understand sampling data values](../profiling/understanding-sampling-data-values.md)

[Sample method data views](../profiling/profiler-sampling-method-data-views.md)

## Instrumentation

The instrumentation profiling method collects detailed timing for the function calls in a profiled app. Instrumentation profiling is useful for these tasks:

- Investigating input/output bottlenecks such as disk I/O
- Close examination of a particular module or set of functions

The instrumentation method injects code into a binary file. The code captures timing information for all functions in the instrumented file and each function call those functions make. Instrumentation also identifies when a function calls into the operating system for operations like writing to a file.

Instrumentation reports use these four values to represent the total time spent in a function or source-code line:

- Elapsed Inclusive - The total time spent running the function or source-code line.

- Application Inclusive - The time spent running the function or source-code line. Calls to the operating system are excluded.

- Elapsed Exclusive - The time spent running the function or source-code line. Calls to other functions are excluded.

- Application Exclusive - The time spent running the function or source-code line. Calls to the operating system or other functions are excluded.

You can also collect both CPU and software-performance counters by using the instrumentation method.

[Understand instrumentation data values](../profiling/understanding-instrumentation-data-values.md)

[Collect detailed timing data by using instrumentation](../profiling/collecting-detailed-timing-data-by-using-instrumentation.md)

[Instrumentation method data views](../profiling/instrumentation-method-data-views.md)

## Concurrency

Concurrency profiling collects information about multithreaded apps. Resource-contention profiling collects detailed call-stack information whenever competing threads wait for access to a shared resource. Concurrency visualization also collects more general information about how your multithreaded app interacts with:

- Itself.
- The hardware.
- The operating system.
- Other processes on the host computer.

Resource-contention reports display the total number of contentions. They also report the total time that modules, functions, source-code lines, and instructions waited for a resource. Timeline graphs show the contentions as they occurred.

The concurrency visualizer displays graphical information to help you locate:

- Performance bottlenecks.
- CPU underutilization.
- Thread contention.
- Thread migration.
- Synchronization delays.
- Areas of overlapped I/O.

  When possible, the graphical output links to data from the call stack and source code. Concurrency visualization data can be collected only for command-line apps and Windows apps.

[Understand resource contention data values](../profiling/understanding-resource-contention-data-values.md)

[Collect thread and process concurrency data](../profiling/collecting-thread-and-process-concurrency-data.md)

[Resource contention data views](../profiling/resource-contention-data-views.md)

[Concurrency Visualizer](../profiling/concurrency-visualizer.md)

## .NET memory

The profiling method for .NET memory allocation interrupts the CPU at each allocation of a .NET Framework object in a profiled app. When the profiler also collects object-lifetime data, it interrupts the CPU after each .NET Framework garbage collection.

The profiler collects information about the type, size, and number of objects created in an allocation or destroyed in garbage collection.

- When an allocation event occurs, the profiler collects additional information about the function call stack. The profiler increments exclusive allocation counts for the currently running function. It also increments inclusive counts for all calling functions on the call stack. .NET reports present the totals of these counts for the profiled types, modules, functions, source-code lines, and instructions.

- When garbage collection occurs, the profiler collects data about the destroyed objects and about the objects in each garbage collection generation. At the end of the profiling run, the profiler records data about the objects that weren't explicitly destroyed. The Object Lifetime report displays the totals for each type allocated in the profiling run.

You can use .NET memory profiling in either sampling mode or instrumentation mode. The mode that you select doesn't affect the Allocation and Object Lifetime reports that are unique to .NET memory profiling.

- When you run .NET memory profiling in sampling mode, the profiler uses memory allocation events as the interval. It also displays the total number of allocated objects and bytes as the inclusive and exclusive values in the reports.

- When you run .NET memory profiling in instrumentation mode, the profiler collects detailed timing information together with the inclusive and exclusive allocation values.

[Understand memory allocation and object-lifetime data values](../profiling/understanding-memory-allocation-and-object-lifetime-data-values.md)

[Collect .NET memory allocation and lifetime data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)

[.NET memory data views](../profiling/dotnet-memory-data-views.md)

## Tier interaction

Tier-interaction profiling adds information to a profiling data file about synchronous [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] calls between an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] page or other app and a [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database. Data includes the number and time of calls and the maximum and minimum times. You can add tier-interaction data to profiling data that you collect with the sampling, instrumentation, .NET memory, or concurrency methods.

![Tier-interaction profiling dataflow](../profiling/media/tierinteraction_profilingtools.png "Tier-interaction profiling dataflow")

For information on tier-interaction data that is collected by profiling tools, see the following articles.

[Collect tier-interaction data](../profiling/collecting-tier-interaction-data.md)

[Tier-interaction views](../profiling/tier-interaction-views.md)

## See also

[How to: Collect performance data for a web site](../profiling/how-to-collect-performance-data-for-a-web-site.md)

[Beginner's guide to performance profiling](../profiling/beginners-guide-to-performance-profiling.md)
