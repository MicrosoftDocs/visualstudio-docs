---
title: "Understanding Performance Collection Methods | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.wizard.methodpage"
helpviewer_keywords:
  - "Profiling Tools, profiling methods"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Understand performance collection methods

The Visual Studio Profiling Tools provide five methods that you can use to collect performance data. This topic describes the different methods and suggests some scenarios in which collecting data with a particular method can be appropriate.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

|Method|Description|
|------------|-----------------|
|[Sampling](#sampling)|Collects statistical data about the work performed by an application.|
|[Instrumentation](#instrumentation)|Collects detailed timing information about each function call.|
|[Concurrency](#concurrency)|Collects detailed information about multi-threaded applications.|
|[.NET memory](#net-memory)|Collects detailed information about .NET memory allocation and garbage collection.|
|[Tier interaction](#tier-interaction)|Collects information about synchronous ADO.NET function calls to a SqlServer database.<br /><br /> Tier interaction profiling can be collected using any edition of Visual Studio. However, tier interaction profiling data can be viewed only in Visual Studio Enterprise.|

By using some of the profiling methods, you can also collect additional data, such as software and hardware performance counters. For more information, see [Collect additional performance data](../profiling/collecting-additional-performance-data.md).

## Sampling

The sampling profiling method collects statistical data about the work that is performed by an application during a profiling run. The sampling method is lightweight and has little effect on the execution of the application methods.

Sampling is the default method of the Visual Studio Profiling Tools. It is useful for the following:

- Initial explorations of the performance of your application.
- Investigating performance issues that involve the utilization of the processor (CPU).

The sampling profiling method interrupts the computer processor at set intervals and collects the function call stack. Exclusive sample counts are incremented for the function that is executing and inclusive counts are incremented for all of the calling functions on the call stack. Sampling reports present the totals of these counts for the profiled module, function, source code line, and instruction.

By default, the profiler sets the sampling interval to CPU cycles. You can change the interval type to another CPU performance counter and you can set the number of counter events for the interval. You can also collect tier interaction profiling(TIP) data that provides information about the queries that are made to a SQL server database through ADO.NET.

[Collect performance statistics by using sampling](../profiling/collecting-performance-statistics-by-using-sampling.md)

[Understand sampling data values](../profiling/understanding-sampling-data-values.md)

[Sample method data views](../profiling/profiler-sampling-method-data-views.md)

## Instrumentation

The instrumentation profiling method collects detailed timing for the function calls in a profiled application. Instrumentation profiling is useful for the following:

- Investigating input/output bottlenecks such as disk I/O.
- Close examination of a particular module or set of functions.

The instrumentation method injects code into a binary file that captures timing information for each function in the instrumented file and each function call that is made by those functions. Instrumentation also identifies when a function calls into the operating for operations such as writing to a file. Instrumentation reports use four values to represent the total time spent in a function or source code line:

- Elapsed Inclusive - The total time that is spent executing the function or source line.

- Application Inclusive - The time that is spent executing the function or source line, but excluding time that is spent in calls to the operating system.

- Elapsed Exclusive - The time that is spent executing code in the body of the function or source code line. Time that is spent executing functions that are called by the function or source line is excluded.

- Application Exclusive - The time that is spent executing code in the body of the function or source code line. Time that is spent executing calls to the operating system and time that is spent executing functions that are called by the function or source line is excluded.

You can also collect both CPU and software performance counters by using the instrumentation method.

[Understand instrumentation data values](../profiling/understanding-instrumentation-data-values.md)

[Collect detailed timing data by using instrumentation](../profiling/collecting-detailed-timing-data-by-using-instrumentation.md)

[Instrumentation method data views](../profiling/instrumentation-method-data-views.md)

## Concurrency

Concurrency profiling collects information about multithreaded applications. Resource contention profiling collects detailed call stack information every  time that competing threads are forced to wait for access to a shared resource. Concurrency visualization also collects more general information about how your multithreaded application interacts with itself, the hardware, the operating system, and other processes on the host computer:

- Resource contention reports display the total number of contentions and the total time that was spent waiting for a resource for the modules, functions, source code lines, and instructions in which the waiting occurred. Timeline graphs also show the contentions as they occurred.

- The concurrency visualizer displays graphical information that you can use to locate performance bottlenecks, CPU underutilization, thread contention, thread migration, synchronization delays, areas of overlapped I/O, and other information. When possible, the graphical output links to call stack and source code data. Concurrency visualization data can be collected only for command line and Windows applications.

[Understand resource contention data values](../profiling/understanding-resource-contention-data-values.md)

[Collect thread and process concurrency data](../profiling/collecting-thread-and-process-concurrency-data.md)

[Resource contention data views](../profiling/resource-contention-data-views.md)

[Concurrency Visualizer](../profiling/concurrency-visualizer.md)

## .NET memory

The .NET memory allocation profiling method interrupts the computer processor at each allocation of a .NET Framework object in a profiled application. When object lifetime data is also collected, the profiler interrupts the processor after each .NET Framework garbage collection.

The profiler collects information about the type, size, and number of objects that were created in an allocation or were destroyed in a garbage collection.

- When an allocation event occurs, the profiler collects additional information about the function call stack. Exclusive allocation counts are incremented for the function that is currently executing and inclusive counts are incremented for all the calling functions on the call stack. .NET reports present the totals of these counts for the profiled types, modules, functions, source code lines, and instructions.

- When a garbage collection occurs, the profiler collects data about the objects that were destroyed and information about the objects in each garbage collection generation. At the end of the profiling run, the profiler records data about the objects that were not explicitly destroyed. The Object Lifetime report displays the totals for each type that was allocated in the profiling run.

.NET memory profiling can be used in either sampling or instrumentation mode. The mode that you select does not affect the Allocation and Object Lifetime reports that are unique to.NET memory profiling:

- When you run .NET memory profiling in sampling mode, the profiler.NET uses memory allocation events as the interval and displays the number of objects that were allocated and the total bytes that were allocated as the inclusive and exclusive values in the reports.

- When you run .NET memory profiling in instrumentation mode, detailed timing information is collected together with the inclusive and exclusive allocation values.

[Understand memory allocation and object lifetime data values](../profiling/understanding-memory-allocation-and-object-lifetime-data-values.md)

[Collect .NET memory allocation and lifetime data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)

[.NET memory data views](../profiling/dotnet-memory-data-views.md)

## Tier interaction

Tier-interaction profiling adds information to a profiling data file about synchronous [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] calls between an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] page or other application and a [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database. Data includes the number and time of calls, and the maximum and minimum times. Tier-interaction data can be added to profiling data that is collected with the sampling, instrumentation, .NET memory, or concurrency methods.

![Tier interaction profile data](../profiling/media/tierinteraction_profilingtools.png "TierInteraction_ProfilingTools")

Tier interaction data that is collected by Profiling Tools

[Collect tier interaction data](../profiling/collecting-tier-interaction-data.md)

[Tier interaction views](../profiling/tier-interaction-views.md)

## See also

[How to: Collect performance data for a web site](../profiling/how-to-collect-performance-data-for-a-web-site.md)
[Beginner's guide to performance profiling](../profiling/beginners-guide-to-performance-profiling.md)
