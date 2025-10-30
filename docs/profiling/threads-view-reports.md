---
title: "Threads view reports in the Concurrency Visualizer"
description: "Learn that in the Threads view, you can use reports to identify which threads are executing code during an execution segment."
ms.date: "05/06/2022"
ms.topic: article
f1_keywords:
  - "vs.cv.threads.report.blocking"
  - "vs.cv.threads.report.diskoperations"
  - "vs.cv.threads.report.execution"
  - "vs.cv.threads.report.markers"
  - "vs.cv.threads.report.executionbreakdown"
helpviewer_keywords:
  - "Concurrency Visualizer, Threads View Reports (Parallel Performance)"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Threads view reports in the Concurrency Visualizer

 This article provides information about the reports in the Threads view of the Concurrency Visualizer.

## Blocking time profile report

The Profile Reports provide aggregate blocking time data for call stacks that are specific to each blocking category (for example "I/O" or "Synchronization"). The Preemption report lists the processes that preempted the current process together with the number of preemption instances. To build the blocking profile report, the tool collects blocking API calls and accumulates them into a tree of call stacks. Data that's shown in these reports varies by the current time range, by hidden threads, and by the following two filters that may be applied:

- If Just My Code is selected, only stack frames that have user code are presented, plus one level below the user code.

- If the Noise reduction value is set, collated stacks that have less than the specified frequency are skipped.

  Expand any call-tree entry to find the line of code in which blocking time is spent. To locate the line of source for an entry, on its shortcut menu, choose **View Source**. To locate the line of code that called this one, on the shortcut menu, choose **View Call Sites**. If only one call site is available, the command connects to the highlighted line of code for the call site. If multiple call sites are available, the command opens a dialog box in which you can select an entry and then choose the **Go to source** button to locate the highlighted call site. It's often most useful to view source code for the call site that has the most instances, the most time, or both.

### Blocking time report columns
 The following table shows the columns for each blocking time report.

|Column name|Description|
|-----------------|-----------------|
|**Name**|The name of the function for each level of the call stack.|
|**Instances**|The number of instances of the blocking call for the visible time period.|
|**Inclusive Blocking Time**|The total blocking time that's spent for all stacks that roll up to this level of the call stack tree. The inclusive number is the sum of exclusive blocking time for this function and exclusive blocking time for all its child nodes.|
|**Exclusive Blocking Time**|The total blocking time that's spent during which this function is the lowest level of the call stack. A unique call stack entry that has a high exclusive blocking time may be a function of interest.|
|**API/Wait Category**|Shown only for functions at the lowest level of the call stack. Where the signature of the blocking call is recognized, the name of the blocking API is provided. If the signature is not recognized, the information that's reported by the kernel is provided.|
|**Details**|Fully qualified name of the function. This includes line count when it's available.|

#### Synchronization
 The Synchronization report shows the calls that are responsible for segments that are blocking on synchronization, and the aggregate blocking times of each call stack. For more information, see [Synchronization time](../profiling/threads-view-timeline-reports.md#synchronization-time).

#### Sleep
 The Sleep report shows the calls that are responsible for blocking time that was attributed to time that was spent sleeping, and the aggregate blocking times of each call stack. For more information, see [Sleep time](../profiling/threads-view-timeline-reports.md#sleep-time).

#### I/O
 The I/O report shows the calls that are responsible for segments that are blocking on I/O, and the aggregate blocking times of each call stack. For more information, see [I/O time (threads view)](../profiling/threads-view-timeline-reports.md#io-time-threads-view).

#### Memory management
 The Memory Management report shows the calls that are responsible for segments that are blocking on memory management operations, and the aggregate blocking times of each call stack. For more information, see [Memory management time](../profiling/threads-view-timeline-reports.md#memory-management-time).

#### Preemption
 The Preemption report lists the processes that preempted the current process together with the number of instances.  You can expand each process to view the specific threads that replaced threads in the current process and to view a breakdown of preemption instances per thread. This blocking report is less actionable than the others because preemption is typically imposed on your process by the operating system, not by a problem in your code. For more information, see [Preemption time](../profiling/threads-view-timeline-reports.md#preemption-time).

#### UI processing
 The UI Processing report shows the calls that are responsible for blocking segments that are blocking on UI processing blocks, and the aggregate blocking times of each call stack. For more information, see [UI processing time](../profiling/threads-view-timeline-reports.md#ui-processing-time).

## Disk Operations Report (Threads View)

The Disk Operations Report shows disk I/O operations in the disk channels.

 For each disk access that occurs on behalf of the process that's being profiled in the currently visible time window, this information is reported:

- The name and PID of the process that performed the disk access

- The ID of the thread that accessed the disk

- The name of the file that was accessed

- The number of reads per file

- The number of bytes read

- The read latency, in milliseconds

- The number of writes

- The number of bytes written

- The write latency, in milliseconds

## Execution Profile Report

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

 This report table can be seen in the [Execution time (Threads View)](../profiling/threads-view-timeline-reports.md#execution-time-threads-view) view.

## Markers Report

The Markers Report lists the markers in the displayed time frame.  Panning or zooming, or hiding lanes, might cause markers to appear or disappear. The report contains this information about each marker:

- The time when it began, relative to the start of the trace.

- Its duration. The duration is zero for flags and messages because they represent an instant.

- The ID of the thread that generated it.

- The Event Tracking for Windows (ETW) provider that generated it.

- The marker series from which it was written.

- The category of events it belongs to.

- Its importance level.

- Its type (span, flag, or message).

- A high-level description of what it represents

  Choose the **Export** button to save the Markers Report as a CSV file. You can use the data in the CSV file with other apps or tools.

> [!NOTE]
> The Markers Report can display 1,000 markers. To see all markers, export the full report to a CSV file.

## Per thread summary report

This bar graph shows the proportion of time each unhidden thread spends in each activity category during the currently visible time range. "Execution" means that the thread is executing; all other categories mean that the thread is waiting for something.

## Related content

- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
