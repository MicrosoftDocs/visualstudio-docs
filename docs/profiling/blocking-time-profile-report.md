---
title: "Blocking Time Profile Report | Microsoft Docs"
description: "The blocking time profile reports provide aggregate blocking time data. There are six report types: Synchronization, Sleep, I/O, Memory, Preemption, and UI."
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.report.blocking"
helpviewer_keywords:
  - "Concurrency Visualizer, Blocking Time Profile Report"
ms.assetid: 3bc45af0-3ba6-4fa3-a336-be8e9ae95107
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Blocking time profile report
The Profile Reports provide aggregate blocking time data for call stacks that are specific to each blocking category (for example "I/O" or "Synchronization"). The Preemption report lists the processes that preempted the current process together with the number of preemption instances. To build the blocking profile report, the tool collects blocking API calls and accumulates them into a tree of call stacks. Data that's shown in these reports varies by the current time range, by hidden threads, and by the following two filters that may be applied:

- If Just My Code is selected, only stack frames that have user code are presented, plus one level below the user code.

- If the Noise reduction value is set, collated stacks that have less than the specified frequency are skipped.

  Expand any call-tree entry to find the line of code in which blocking time is spent. To locate the line of source for an entry, on its shortcut menu, choose **View Source**. To locate the line of code that called this one, on the shortcut menu, choose **View Call Sites**. If only one call site is available, the command connects to the highlighted line of code for the call site. If multiple call sites are available, the command opens a dialog box in which you can select an entry and then choose the **Go to source** button to locate the highlighted call site. It's often most useful to view source code for the call site that has the most instances, the most time, or both.

## Blocking time report columns
 The following table shows the columns for each blocking time report.

|Column name|Description|
|-----------------|-----------------|
|**Name**|The name of the function for each level of the call stack.|
|**Instances**|The number of instances of the blocking call for the visible time period.|
|**Inclusive Blocking Time**|The total blocking time that's spent for all stacks that roll up to this level of the call stack tree. The inclusive number is the sum of exclusive blocking time for this function and exclusive blocking time for all its child nodes.|
|**Exclusive Blocking Time**|The total blocking time that's spent during which this function is the lowest level of the call stack. A unique call stack entry that has a high exclusive blocking time may be a function of interest.|
|**API/Wait Category**|Shown only for functions at the lowest level of the call stack. Where the signature of the blocking call is recognized, the name of the blocking API is provided. If the signature is not recognized, the information that's reported by the kernel is provided.|
|**Details**|Fully qualified name of the function. This includes line count when it's available.|

### Synchronization
 The Synchronization report shows the calls that are responsible for segments that are blocking on synchronization, and the aggregate blocking times of each call stack. For more information, see [Synchronization time](../profiling/synchronization-time.md).

### Sleep
 The Sleep report shows the calls that are responsible for blocking time that was attributed to time that was spent sleeping, and the aggregate blocking times of each call stack. For more information, see [Sleep time](../profiling/sleep-time.md).

### I/O
 The I/O report shows the calls that are responsible for segments that are blocking on I/O, and the aggregate blocking times of each call stack. For more information, see [I/O time (threads view)](../profiling/i-o-time-threads-view.md).

### Memory management
 The Memory Management report shows the calls that are responsible for segments that are blocking on memory management operations, and the aggregate blocking times of each call stack. For more information, see [Memory management time](../profiling/memory-management-time.md).

### Preemption
 The Preemption report lists the processes that preempted the current process together with the number of instances.  You can expand each process to view the specific threads that replaced threads in the current process and to view a breakdown of preemption instances per thread. This blocking report is less actionable than the others because preemption is typically imposed on your process by the operating system, not by a problem in your code. For more information, see [Preemption time](../profiling/preemption-time.md).

### UI processing
 The UI Processing report shows the calls that are responsible for blocking segments that are blocking on UI processing blocks, and the aggregate blocking times of each call stack. For more information, see [UI processing time](../profiling/ui-processing-time.md).

## See also
- [Threads view](../profiling/threads-view-parallel-performance.md)