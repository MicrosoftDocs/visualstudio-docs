---
title: "How to: Collect CPU Counter Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.property.cpucounters"
helpviewer_keywords:
  - "profiling tools, using portable CPU counters"
  - "performance tools, portable CPU counters"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Collect CPU counter data

A CPU event counter is used to collect hardware-specific performance data. This article shows you how to collect event counter data when you use the instrumentation profiling method.

Two types of CPU counter events occur:

- Portable events - CPU events that can be collected, regardless of the specific CPU.

- Platform events - CPU events that are coupled to a specific CPU.

  Portable events include general events, such as Instructions Retired and Non Halted Cycles, CPU buffer events, branching events, and L2 cache events. The available platform event counters are determined by the processor manufacturer.

  Categories of events can be shared between portable and platform counters. For example, the following categories of data are frequently common to both types:

- Memory events.

- Front end events.

- Branch events.

  You can collect performance counter data in two ways in the profiler:

- Collect data from one or more counters when you profile by instrumentation.

- Specify a counter event as the sampling interval when you profile by sampling. For more information, see [How to: Choose sampling events](../profiling/how-to-choose-sampling-events.md).

## To collect CPU performance counter data when you profile by instrumentation

1. On the performance session **Property Pages**, click **CPU Counters.**

2. Select the **Collect CPU Counters** check box.

3. Expand the **Available performance counters** tree until you find the sample events that you want to collect.

4. For each event that you want to collect, select the event and then click the right arrow to add the event to the **Selected Counters** list.

    > [!NOTE]
    > **Available performance counters** is enabled only if you select the **Collect CPU counters** check box.

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[Performance session properties](../profiling/performance-session-properties.md)
[CPU and Windows counters](../profiling/cpu-and-windows-counters.md)
[How to: Choose sampling events](../profiling/how-to-choose-sampling-events.md)
