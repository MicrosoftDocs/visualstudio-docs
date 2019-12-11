---
title: "Execution Profile Report | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.report.execution"
helpviewer_keywords:
  - "Concurrency Visualizer, Execution Profile Report"
ms.assetid: c8128472-a8ed-46f4-b1c8-a25358d6f2c1
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Execution Profile Report
The Execution Profile Report is a traditional sampling profile. Samples are taken approximately every millisecond during periods when a thread is running on a logical core, and the Concurrency Visualizer builds a typical call tree by collating the accumulated set of sample stacks. Data in this table can be affected by the current time range and hidden threads, and by these filters that may be applied:

- If Just My Code is selected, only stack frames that have user code, plus one level below the user code, are shown.

- If the Noise reduction value is set, collated stacks that have less than the specified frequency are filtered out of the report

  The following table shows columns in the report.

|Column|Description|
|------------|-----------------|
|Name|The name of the function for each level of the call stack.|
|Inclusive samples|Total number of samples that are collected for all stacks that roll up into this level of the call stack tree. The inclusive number is the sum of exclusive samples for this function and inclusive counters for all its child nodes.|
|Exclusive Samples|Total number of collected samples for which this function is the lowest level of the call stack.|
|% Inclusive|The percentage of total samples that is shown in the inclusive samples column. Percentages are rounded to two decimal places.|
|% Exclusive|The percentage of total samples that is shown in the exclusive samples column. Percentages are rounded to two decimal places.|
|Details|Fully qualified name of the function. This includes line count when it is available.|

 This report table can be seen in the [Execution time (Threads View)](../profiling/execution-time-threads-view.md) view.

## See also
- [Threads View](../profiling/threads-view-parallel-performance.md)