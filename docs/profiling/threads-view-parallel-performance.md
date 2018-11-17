---
title: "Threads view in the Concurrency Visualizer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
f1_keywords: 
  - "vs.performance.view.threadblocking"
helpviewer_keywords: 
  - "Concurrency Visualizer, Threads View (Parallel Performance)"
ms.assetid: 2e441103-a266-407b-88c3-fb58716257a3
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Threads view in the Concurrency Visualizer

**Threads** view is the most detailed and feature-rich view in the Concurrency Visualizer. Using this view, you can identify whether threads are executing or blocking because of synchronization, I/O, or some other reason.  
  
While threads are executing, the Concurrency Visualizer collects samples. 

When an app has stopped executing, the Concurrency Visualizer examines all operating system context-switch events for each app thread. Context switches can occur because:  
  
- A thread is blocked on a synchronization primitive.  
- The quantum of a thread expires.  
- A thread makes a blocking I/O request.  
  
During profile analysis, Concurrency Visualizer categorizes context-switch events by searching the call stack of the thread for well-known blocking APIs. It displays the categories in the lower-left part of the **Threads** view. 

If there is no call stack match, Concurrency Visualizer uses the wait reason provided by [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)]. However, the [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)] category may be based on an implementation detail, and may not reflect user intent. For example, [!INCLUDE[TLA#tla_mswin](../code-quality/includes/tlasharptla_mswin_md.md)] reports the wait reason for blocking on a native slim reader-writer lock as I/O instead of Synchronization. In most cases, you can identify the root cause of a blocking event by examining the call stacks that correspond to context-switch events.  
  
In the **Threads** view, you can analyze which code is executed by one or more threads during an execution segment. You can also examine blocking reports, and reports that profile call-stack tree execution.  
  
**Threads** view also shows dependencies between threads. For example, if you identify a thread that's blocked on a synchronization object, you can look for the thread that unblocked it, and you can examine the activity on the call stack for that thread at the point when it unblocked the other one.  

You can use **Threads** view to:  

- Identify reasons the user interface (UI) of an app is unresponsive during certain execution phases.  
- Determine the amount of time that's spent blocking on synchronization, I/O, page faults, and other events.  
- Discover the degree of interference from other processes that are executing on the system.  
- Identify load-balancing issues for parallel execution.  
- Find the reasons for suboptimal or nonexistent scalability. For example, why does the performance of a parallel app not improve when more logical cores are available.  
- Understand the degree of concurrency in the app, to help in parallelization.  
- Identify dependencies among worker threads and critical paths of execution.  
  
## Use Threads view 

To start Concurrency Visualizer, select **Analyze** > **Concurrency Visualizer**, and then select an option, such as **Launch New Process** to start an app. 

Concurrency Visualizer starts the app and collects a trace until you select **Stop Collection**. Concurrency Visualizer then analyzes the trace and shows the results on the trace report page. 

Select **Threads** at upper-left of the report to open **Threads* view. 

![Threads view](../profiling/media/threadsviewnarrowing.png "Threads view")  
  
Selected a time interval and some threads to start a performance analysis.  
  
## Timeline analysis  

The upper part of the **Threads** view displays a timeline. The timeline shows the activity of all threads in the process, and all physical disk devices on the host computer. It also displays GPU activity and marker events.  You can zoom in to view more detail, or zoom out to view a longer time interval. You can select segments and points on the graph to get details about categories, start times, delays, and call stack states.  

On the timeline, the x-axis is time, and on the y-axis are several channels:  
  
- Two I/O channels for each disk drive on the system, one channel for reads and one for writes.  
- A channel for each thread in the process.  
- Marker channels, if there are marker events in the trace. Marker channels initially appear under the thread channels that generated those events.  
- GPU channels.  
  
Initially, threads are sorted in the order in which they are created, so the main app thread is first. Select another option in the **Sort by** dropdown to sort threads by another criterion, such as **Execution**. 

The timeline colors indicate the state of a thread at a given time. Green segments were executing, red segments were blocked for synchronization, yellow segments were preempted, and purple segments were engaged in device I/O. You can use this view to examine the work balance among threads that are involved in a parallel loop or in concurrent tasks. If one thread is taking longer to complete than the others, the work might be unbalanced. You can use this information to improve the performance of your program, by distributing work more evenly among the threads.  
  
If only one thread is executing at a point in time, the app may not be taking full advantage of the concurrency on the system. You can use the timeline graph to examine dependencies between threads, and the temporal relationships between blocking and blocked threads. To rearrange threads, select a thread, and then select the up or down icon on the toolbar. 

You can hide threads that that are not performing work or are completely blocked, because their statistics are irrelevant and can clog the reports. Hide threads by selecting their names and then selecting the **Hide selected threads** or **Hide all except selected threads** icons on the toolbar. To identify threads to hide, select **Per Thread Summary** at lower left of the report, and hide the threads that have no activity. 

### Thread execution details  
To get more detailed information about an execution segment, select a point on a green segment of the timeline. The Concurrency Visualizer displays a black caret above the selected point, and shows the call stack at that point on the **Current** tab of the bottom pane. You can select multiple points on the execution segment.  
  
>[!NOTE]
>The Concurrency Visualizer might not be able to resolve a selection on an execution segment if the duration of the segment is less than one millisecond.  
  
To get an execution profile for all unhidden threads in the currently selected time range, select **Execution** button in the legend at lower left.  
  
### Thread-blocking details  
To get information about a particular region on a thread, hover over that region on the timeline to display a tooltip. The tooltip has information such as category, start time, and delay. Select the region to display the call stack at that point in time in the **Current** tab of the bottom pane. The pane also shows category, delay, blocking API if there is one, and unblocking thread if there is one. By examining the call stack, you can determine the underlying reason for thread-blocking events.  
  
An execution path may have several blocking events. To examine these by blocking category and find problem areas more quickly, select a blocking category in the legend on the left.  
  
### Dependencies between threads  
The Concurrency Visualizer shows dependencies between threads, so you can determine what a blocked thread was trying to do, and what other thread enabled it to execute. 

To determine which thread unblocked another thread, select the blocking segment on the timeline. If the Concurrency Visualizer can determine the unblocking thread, it draws a line between the unblocking thread and the executing segment that follows the blocking segment. Select the **Unblocking Stack** tab in the bottom pane to see the relevant call stack.  
  
## Profile reports 
Below the timeline graph is a pane with **Profile Report** **Current**, and **Unblocking Stack** report tabs. The reports automatically update as you change the timeline and threads selections. For large traces, the reports pane might be temporarily unavailable while updates are calculated. 

### Profile Report tab 

The **Profile Report** has two filters: **Noise reduction at** and **Just My Code**. To filter out call tree entries where little time was spent, type a filter value between 0 and 99 percent. The default value is 2 percent. To view the call tree for only your code, select the **Just My Code** check box. To view all call trees, clear the check box.  

The **Profile Report** tab shows reports that correspond to the entries in the legend to the left. To display a report, choose one of the entries.  

- **Execution**  
  The **Execution** report shows the breakdown of the time the application spent in execution.  
  
  To find the line of code in which execution time is spent, expand the call tree and then, on the shortcut menu for the call tree entry, choose **View Source** or **View Call Sites**. **View Source** locates the executed line of code. **View Call Sites** locates the line of code that called the executed line of code. If only one call site exists, its line of code is highlighted. If multiple call sites exist, you can select the one you want in the dialog box that appears and then choose the **Go to source** button to highlight the call site code. It's often most useful to locate the call site that has the most instances, the most time, or both. For more information, see [Execution profile report](../profiling/execution-profile-report.md).  
  
- **Synchronization**  
  The **Synchronization** report shows the calls that are responsible for synchronization blocks, along with the aggregate blocking times of each call stack. For more information, see [Synchronization time](../profiling/synchronization-time.md).  
  
- **I/O**  
  The **I/O** report shows the calls that are responsible for I/O blocks, along with the aggregate blocking times of each call stack. For more information, see [I/O time (Threads view)](../profiling/i-o-time-threads-view.md).  
  
- **Sleep**  
  The **Sleep** report shows the calls that are responsible for sleep blocks, along with the aggregate blocking times of each call stack. For more information, see [Sleep time](../profiling/sleep-time.md).  
  
- **Memory Management**  
  The **Memory Management** report shows the calls where memory management blocks occurred, along with the aggregate blocking times of each call stack. Use this information to identify areas that have excessive paging or garbage collection issues.  For more information, see [Memory management time](../profiling/memory-management-time.md).  
  
- **Preemption**  
  The **Preemption** report shows the instances where processes on the system preempted the current process, and individual threads that replaced threads in the current process. You can use this information to identify the processes and threads that are most responsible for preemption. For more information, see [Preemption time](../profiling/preemption-time.md).  
  
- **UI Pprocessing**  
  The **UI Processing** report shows the calls that are responsible for UI processing blocks, along with the aggregate blocking times of each call stack. For more information, see [UI processing time](../profiling/ui-processing-time.md).  
  
- **Per Thread Summary**  
  Select **Per Thread Summary** to display a graph showing the state of threads for the currently selected time interval. The color-coded columns show the total time each thread spent in run, blocked, I/O and other states. The threads are labeled at the bottom. When you adjust the zoom level in the timeline graph, this tab automatically updates. 
  
  At some zoom levels, some threads might not show in the graph. When this happens, ellipses (**...**) appear at the right. If the thread you want does not appear, you can hide other threads. For more information, see [Per thread summary report](../profiling/per-thread-summary-report.md).  
  
- **Disk Operations**  
  Select *Disk Operations** to show which processes and threads were involved in disk I/O on behalf of the current process, which files they touched (for example, DLLs that were loaded), how many bytes were read, and other information. You can use this report to evaluate time that is spent in accessing files during execution, especially when your process seems to be I/O-bound. For more information, see [Disk operations report](../profiling/disk-operations-report-threads-view.md).  
  
### Current tab  
This tab shows the call stack for a selected point on a thread segment in the timeline graph. The call stacks are trimmed to show only activity that is related to your app.  
  
### Unblocking Stack tab 
This tab shows which thread unblocked the selected thread, and the unblocking call stack.  
  
## See also  
 [Concurrency Visualizer](../profiling/concurrency-visualizer.md)