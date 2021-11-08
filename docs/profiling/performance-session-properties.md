---
title: "Performance Session Properties | Microsoft Docs"
description: Learn how a Performance Session enables you to configure settings that determine how the application is profiled.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiling Tools,properties"
  - "property pages,Profiling Tools"
  - "performance tools, performance session properties"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Performance session properties

A **Performance Session** enables you to configure settings that determine how the application is profiled. It also stores reports that are generated for the profiling session.

You create a **Performance Session** by running the **Performance Wizard** or by manually creating a session. The **Performance Session** is displayed in the **Performance Explorer** after the **Performance Session** has been created.

To view **Performance Session** properties, select the session name in **Performance Explorer**, right-click it and then select **Properties**.

The performance session has the following property pages:

## General

These settings enable you to select the profiling method, to add .NET object collection and lifetime data, and to specify the default report location and naming conventions.

For more information, see:

[How to: Choose collection methods](../profiling/how-to-choose-collection-methods.md)

[Collect .NET memory allocation and lifetime data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)

- [How to: Set performance data file name options](../profiling/how-to-set-performance-data-file-name-options.md)

## Launch

These settings enable you to select from a list of binaries and specify the start order of the binaries.

For more information, see [How to: Specify the binary to start](../profiling/how-to-specify-the-binary-to-start.md)

## Sampling

These settings enable you to select the sample event and sampling interval when sampling is used as the profiling method. A sample event is used to collect profiling data at the specified interval. For example, if the sample event is clock cycles and the sampling interval is set to 10,000,000 then profiling data is collected after every 10 million clock cycles. The following four types of sample events are available:

- Clock Cycles - for CPU bound problems
- Page Faults - for memory related problems
- System Calls - for I/O related problems
- Performance Counters - for low-level performance problems
- Additional sample events can be specified based on available performance counters

For more information, see [How to: Choose sampling events](../profiling/how-to-choose-sampling-events.md)

## Binary
These settings enable you to specify whether you want to relocate the instrumented binary to another location. For example, if you are profiling *My.DLL* and choose not to relocate the instrumented binary, a backup copy of *My.DLL* named *My.Orig.DLL* is created. Subsequently, *My.DLL* is modified by inserting probes to collect data. If you decide to relocate the instrumented binary, the original binary is not renamed and the instrumented binary is copied to the specified location for use during instrumentation.

For more information, see [How to: Specify the binary to start](../profiling/how-to-specify-the-binary-to-start.md)

## Tier interactions

For more information, see [Collecting tier interaction data](../profiling/collecting-tier-interaction-data.md)

## Instrumentation

These settings enable you to collect performance data for JScript code in [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web pages and specify any **Pre-instrument** and **Post-instrument** events that you want to occur before or after the instrumentation process.

For more information, see:

[How to: Profile JavaScript code in web pages](../profiling/how-to-profile-javascript-code-in-web-pages.md)

[How to: Specify pre- and post-instrument commands](../profiling/how-to-specify-pre-and-post-instrument-commands.md)

## CPU counters

These settings enable you to collect data about CPU performance counters when you are using the instrumentation profiling method. Portable Performance counters are available regardless of the CPU design or manufacturer. Platform Events are specific to the CPU design and manufacturer. For more information about on-chip performance counters, see the specific processor documentation.

For more information, see [How to: Collect CPU counter data](../profiling/how-to-collect-cpu-counter-data.md)

## Windows events

During profiling, you can collect data from event trace providers. You can view the data by using the *VSPerfReport.exe* command line tool `/calltrace` option. For more information about Event Tracing for Windows (ETW), see [About Event Tracing](/windows/win32/etw/about-event-tracing).

For more information, see:

[How to: Collect event tracing for Windows (ETW) data](../profiling/how-to-collect-event-tracing-for-windows-etw-data.md)

[VSPerfReport](../profiling/vsperfreport.md).

## Windows counters

This option enables you to collect data from Windows Performance Monitor counters. To collect this data, select the check box labeled **Collect Windows Performance Counters**. The collection interval can be set in the **Collection Interval** box. **Counter Category** and **Instance** might be available also. Some default Windows Performance Monitor counters are available.

 For more information, see [How to: Collect Windows counter data](../profiling/how-to-collect-windows-counter-data.md).

## Advanced

These settings enable you to add options to the instrumentation process by specifying one or more options of the [VSInstr](../profiling/vsinstr.md) command line profiling tool. You can also specify the version of the Common Runtime to profile when the application is using more than one version.

For more information, see:

[How to: Specify the .NET Framework runtime](../profiling/how-to-specify-the-dotnet-framework-runtime.md)

[How to: Specify additional instrumentation options](../profiling/how-to-specify-additional-instrumentation-options.md)

## See also

[Overviews](../profiling/overviews-performance-tools.md)
[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[Control data collection](../profiling/controlling-data-collection.md)
