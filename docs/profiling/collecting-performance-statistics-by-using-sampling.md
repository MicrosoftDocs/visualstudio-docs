---
title: "Collecting Performance Statistics by Using Sampling | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiling Tools,sampling"
  - "sampling profiling method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Collect performance statistics by using sampling

By default, the Visual Studio Profiling Tools sampling method collects profiling information every 10,000,000 processor cycles (approximately every one-hundredth of a second on a 1 GHz computer). The sampling method is useful for finding processor utilization issues and is the suggested method for starting most performance investigations.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

You can specify the sampling method by using one of the following procedures:

- On the first page of the Profiling Wizard, click **CPU Sampling (recommended)**.
- On the **Performance Explorer** toolbar, in the **Method** list, click **Sampling**.
- On the **General** page of the properties dialog box for the performance session, click **Sampling**.

## Common tasks

You can specify additional options in the _Performance Session_**Property Pages** dialog box of the performance session. To open this dialog box:

- In **Performance Explorer**, right-click the performance session name, and then click **Properties**.

  The tasks in the following table describe options that you can specify in the _Performance Session_**Property Pages** dialog box when you profile by using the sampling method.

|Task|Related Content|
|----------|---------------------|
|On the **General** page, add .NET memory allocation and lifetime data collection, and specify naming details for the generated profiling data (.vsp) file.|- [Collecting .NET Memory Allocation and Lifetime Data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)<br />- [How to: Set Performance Data File Name Options](../profiling/how-to-set-performance-data-file-name-options.md)|
|On the **Sampling** page, change the sampling rate, change the sampling event from processor clock cycles to another processor performance counter, or change both..|- [How to: Choose Sampling Events](../profiling/how-to-choose-sampling-events.md)|
|On the **Launch** page, specify the application to start and the start order if you have multiple .exe projects in your code solution.|- [Collecting tier interaction data](../profiling/collecting-tier-interaction-data.md)|
|On the **Tier Interaction** page, add ADO.NET call information to the data collected in theprofiling run.|- [Collecting tier interaction data](../profiling/collecting-tier-interaction-data.md)|
|On the **Windows Events** page, specify one or more Event Tracing for Windows (ETW) events to collect with the sampling data.|- [How to: Collect Event Tracing for Windows (ETW) Data](../profiling/how-to-collect-event-tracing-for-windows-etw-data.md)|
|On the **Windows Counters** page, specify one or more operating system performance counters to add to the profiling data as marks.|- [How to: Collect Windows Counter Data](../profiling/how-to-collect-windows-counter-data.md)|
|On the **Advanced** page, specify the version of the .NET Framework runtime to profile if your application modules use multiple versions. By default, the first version loaded is profiled.|- [How to: Specify the .NET Framework Runtime](../profiling/how-to-specify-the-dotnet-framework-runtime.md)|
