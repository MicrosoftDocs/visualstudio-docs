---
title: "Threads view in the Concurrency Visualizer | Microsoft Docs"
ms.date: "11/04/2018"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.threadblocking"
helpviewer_keywords:
  - "Concurrency Visualizer, Threads View (Parallel Performance)"
ms.assetid: 2e441103-a266-407b-88c3-fb58716257a3
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Threads view in the Concurrency Visualizer

**Threads** view is the most detailed and feature-rich view in the Concurrency Visualizer. In the **Threads** view, you can identify which threads are executing code during an execution segment, and analyze whether threads are executing or blocking because of synchronization, I/O, or other reasons. **Threads** view reports also profile call-stack tree execution and unblocking threads.

While threads are executing, the Concurrency Visualizer collects samples. When a thread has stopped executing, the visualizer examines all operating system context-switch events for the thread. Context switches can occur because:

- A thread is blocked on a synchronization primitive.
- The quantum of a thread expires.
- A thread makes a blocking I/O request.

Concurrency Visualizer categorizes thread and context-switch events, and searches the call stacks of threads for well-known blocking APIs. It displays the thread categories in the active legend at lower-left in the **Threads** view. In most cases, you can identify the root cause of a blocking event by examining the call stacks that correspond to context-switch events.

If there's no call stack match, Concurrency Visualizer uses the wait reason provided by [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)]. However, the [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)] category may be based on an implementation detail, and may not reflect user intent. For example, [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)] reports the wait reason for blocking on a native slim reader-writer lock as I/O instead of Synchronization.

**Threads** view also shows dependencies between threads. For example, if you identify a thread that's blocked on a synchronization object, you can find the thread that unblocked it. You can examine the call stack for the unblocking thread at the point when it unblocked the other one.

You can use **Threads** view to:

- Identify reasons the user interface (UI) of an app is unresponsive during certain execution phases.
- Determine the amount of time that's spent blocking on synchronization, I/O, page faults, and other events.
- Discover the degree of interference from other processes that are executing on the system.
- Identify load-balancing issues for parallel execution.
- Find the reasons for suboptimal or nonexistent scalability. For example, why does the performance of a parallel app not improve when more logical cores are available.
- Understand the degree of concurrency in the app, to help in parallelization.
- Identify dependencies among worker threads and critical paths of execution.

## Use Threads view

To start Concurrency Visualizer, select **Analyze** > **Concurrency Visualizer**, and then select an option, such as **Launch New Process**.

Concurrency Visualizer starts the app and collects a trace until you select **Stop Collection**. The visualizer then analyzes the trace and displays the results on the trace report page.

Select the **Threads** tab at upper-left in the report to open the **Threads** view.

![Threads view](../profiling/media/threadsviewnarrowing.png "Threads view")

Select time intervals and threads to start a performance analysis.

## Timeline analysis

The upper part of the **Threads** view is a timeline. The timeline shows the activity of all threads in the process, and all physical disk devices on the host computer. It also displays GPU activity and marker events.

On the timeline, the x-axis is time, and on the y-axis are several channels:

- Two I/O channels for each disk drive on the system, one channel for reads and one for writes.
- A channel for each thread in the process.
- Marker channels, if there are marker events in the trace. Marker channels initially appear under the thread channels that generated those events.
- GPU channels.

Initially, threads are sorted in the order in which they're created, so the main app thread is first. Select another option in the **Sort by** dropdown to sort threads by another criterion, such as **Execution**.

The timeline colors indicate the state of a thread at a given time. Green segments are executing, red segments are blocked for synchronization, yellow segments are preempted, and purple segments are engaged in device I/O.

You can zoom in to view more detail, or zoom out to view a longer time interval. Select segments and points on the graph to get details about categories, start times, delays, and call stack states.

Use the timeline to examine the work balance among threads that are involved in a parallel loop, or in concurrent tasks. If one thread is taking longer to complete than the others, the work might be unbalanced. You might improve the performance of your app by distributing work more evenly among the threads.

If only one thread is executing at a point in time, the app may not be taking full advantage of concurrency on the system. You can use the timeline graph to examine dependencies between threads, and the temporal relationships between blocking and blocked threads. To rearrange threads, select a thread, and then select the up or down icon on the toolbar.

You can hide threads that are not doing work or are completely blocked, because their statistics are irrelevant and can clog the reports. Hide threads by selecting their names and then selecting the **Hide selected threads** or **Hide all except selected threads** icons on the toolbar. To identify threads to hide, select the **Per Thread Summary** link at lower left. You can hide the threads that have no activity in the **Per Thread Summary** graph.

### Thread execution details
To get more detailed information about an execution segment, select a point on a green segment of the timeline. The Concurrency Visualizer displays a black caret above the selected point, and shows its call stack on the **Current** tab of the bottom pane. You can select multiple points on the execution segment.

>[!NOTE]
>The Concurrency Visualizer might not be able to resolve a selection on an execution segment if the duration of the segment is less than one millisecond.

To get an execution profile for all unhidden threads in the currently selected time range, select **Execution** in the legend at lower left.

### Thread-blocking details
To get information about a particular region on a thread, hover over that region on the timeline to display a tooltip. The tooltip has information such as category, start time, and delay. Select the region to display the call stack at that point in time in the **Current** tab of the bottom pane. The pane also shows category, delay, blocking API if there is one, and unblocking thread if there is one. By examining the call stack, you can determine the underlying reasons for thread-blocking events.

An execution path may have several blocking events. To examine these by blocking category and find problem areas more quickly, select a blocking category in the legend on the left.

### Dependencies between threads
The Concurrency Visualizer shows dependencies between threads, so you can determine what a blocked thread was trying to do, and what other thread enabled it to execute.

To determine which thread unblocked another thread, select the blocking segment on the timeline. If the Concurrency Visualizer can determine the unblocking thread, it draws a line between the unblocking thread and the executing segment that follows the blocking segment. Select the **Unblocking Stack** tab in the bottom pane to see the relevant call stack.

## Profile reports
Below the timeline graph is a pane with **Profile Report**, **Current**, and **Unblocking Stack** report tabs. The reports automatically update as you change the timeline and threads selections. For large traces, the reports pane might be temporarily unavailable while updates are calculated.

### Profile Report tab

The **Profile Report** has two filters:

- To filter out call tree entries where little time was spent, type a filter value between 0 and 99 percent in the **Noise reduction at** field. The default value is 2 percent.
- To view call trees for only your code, select the **Just My Code** check box. To view all call trees, clear the check box.

The **Profile Report** tab shows reports for the categories and links in the legend. To display a report, select one of the entries on the left:

- **Execution**
  The **Execution** report shows the breakdown of the time the application spent in execution.

  To find the line of code in which execution time is spent, expand the call tree and on the shortcut menu for the call tree entry, select **View Source** or **View Call Sites**. **View Source** locates the executed line of code. **View Call Sites** locates the line of code that called the executed line. If only one call site line exists, its code is highlighted. If several call sites exist, select the one you want in the dialog box, and then select **Go to source**. It's often most useful to locate the call site that has the most instances, the most time, or both. For more information, see [Execution profile report](../profiling/execution-profile-report.md).

- **Synchronization**
  The **Synchronization** report shows the calls that are responsible for synchronization blocks, along with the total blocking times of each call stack. For more information, see [Synchronization time](../profiling/synchronization-time.md).

- **I/O**
  The **I/O** report shows the calls that are responsible for I/O blocks, along with the total blocking times of each call stack. For more information, see [I/O time (Threads view)](../profiling/i-o-time-threads-view.md).

- **Sleep**
  The **Sleep** report shows the calls that are responsible for sleep blocks, along with the total blocking times of each call stack. For more information, see [Sleep time](../profiling/sleep-time.md).

- **Memory Management**
  The **Memory Management** report shows the calls where memory management blocks occurred, along with the total blocking times of each call stack. Use this information to identify areas that have excessive paging or garbage collection issues.  For more information, see [Memory management time](../profiling/memory-management-time.md).

- **Preemption**
  The **Preemption** report shows where processes on the system preempted the current process, and individual threads that replaced threads in the current process. You can use this information to identify the processes and threads that are most responsible for preemption. For more information, see [Preemption time](../profiling/preemption-time.md).

- **UI Processing**
  The **UI Processing** report shows the calls that are responsible for UI processing blocks, along with the total blocking times of each call stack. For more information, see [UI processing time](../profiling/ui-processing-time.md).

- **Per Thread Summary**
  Select **Per Thread Summary** to display a graph showing the state of threads for the currently selected time interval. The color-coded columns show the total time each thread spent in run, blocked, I/O and other states. The threads are labeled at the bottom. When you adjust the zoom level in the timeline graph, this graph automatically updates.

  At some zoom levels, some threads might not show in the graph. When this happens, ellipses (**...**) appear at the right. If the thread you want does not appear, you can hide other threads. For more information, see [Per thread summary report](../profiling/per-thread-summary-report.md).

- **Disk Operations**
  Select **Disk Operations** to show processes and threads involved in disk I/O for the current process, files they touched (for example, DLLs they loaded), how many bytes they read, and other information. You can use this report to evaluate time spent accessing files during execution, especially when your process seems to be I/O-bound. For more information, see [Disk operations report](../profiling/disk-operations-report-threads-view.md).

### Current tab
This tab shows the call stack for a selected point on a thread segment in the timeline graph. The call stacks are trimmed to show only activity that is related to your app.

### Unblocking Stack tab
This tab shows which thread unblocked the selected thread, and the unblocking call stack.

## See also
- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
