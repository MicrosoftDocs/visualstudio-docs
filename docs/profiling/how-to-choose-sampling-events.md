---
title: Choose Sampling Events | Microsoft Docs
description: Learn how to set the sample event to meet your needs, and to set the number of cycles between samples. Available events include clock cycles and page faults.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.performance.property.sampling
helpviewer_keywords: 
  - clock cycles sample event
  - sample events, choosing
  - profiling tools, sample events
  - page faults sample event
  - system calls sample event
  - performance counter sample event
  - performance tools, sample events
ms.assetid: ce7cb734-80ac-4930-a4ef-e24395e1cc07
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Choose sampling events
By default, the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools collects performance data at an interval that is specified as a number of processor cycles that are used by the profiled process. The default number of cycles in an interval is 10,000,000, which is approximately 0.01 seconds on a 1 GH computer. You can change the number of cycles in an interval, and you can change the sample event. The following sample events are available:

- Clock cycles - for CPU-bound problems.

- Page faults - for memory-related problems.

- System calls - for I/O-related problems.

- Performance counter - CPU counters for low-level performance problems.

> [!IMPORTANT]
> If you are collecting .NET memory data (allocations or object lifetimes, or both) by using the sampling method, all user-specified sampling events are ignored and the appropriate memory allocations or garbage collection events, or both, are used to collect data.

### To select a sample event

1. In **Performance Explorer**, right-click the performance session, and then click **Properties**.

2. In the **Property Pages**, click the **Sampling** properties.

3. From the **Sample event** drop-down list, select the sample event you want to use to profile your application.

    > [!NOTE]
    > The **Available performance counters** are enabled only if you select **Performance counter** from the **Sample event** drop-down list.

4. If you select **Performance counter**, select a specific CPU counter from the **Available performance counters** tree view control.

    - Counters in the **Portable Events** node are available on all types of processors.

    - Counters in the **Platform Events** node are specific to the processor on the current computer and might not be available on other types of processors.

5. When you select a sample event, a default sampling interval value is displayed in the **Sampling interval** text box. If necessary, you can enter the value that you want in the text box.

## See also
- [Configure performance sessions](../profiling/configuring-performance-sessions.md)
- [How to: Choose collection methods](../profiling/how-to-choose-collection-methods.md)
- [CPU and Windows counters](../profiling/cpu-and-windows-counters.md)
- [Understand sampling data values](../profiling/understanding-sampling-data-values.md)
- [Profile from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md)
