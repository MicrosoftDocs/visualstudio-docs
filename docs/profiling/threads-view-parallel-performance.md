---
title: "Threads view in the Concurrency Visualizer | Microsoft Docs"
description: Learn that in the Threads view, you can identify which threads are executing code during an execution segment.
ms.date: "11/04/2018"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.threadblocking"
  - "vs.cv.threads.report.blocking"
  - "vs.cv.threads.timeline.channelnames"
  - "vs.cv.threads.selection.copy"
  - "vs.cv.threads.reportnav.current"
  - "vs.cv.threads.report.diskoperations"
  - "vs.cv.threads.timeline.empty"
  - "vs.cv.threads.report.execution"
  - "vs.cv.threads.timeline.execution"
  - "vs.cv.threads.export"
  - "vs.cv.threads.timeline.io"
  - "vs.cv.threads.jmc"
  - "vs.cv.threads.tools.managechannels"
  - "vs.cv.threads.report.markers"
  - "vs.cv.threads.tools.measure"
  - "vs.cv.threads.timeline.paging"
  - "vs.cv.threads.filter"
  - "vs.cv.threads.timeline.preemption"
  - "vs.cv.threads.reportnav.profile"
  - "vs.cv.threads.timeline.sleep"
  - "vs.cv.threads.report.executionbreakdown"
  - "vs.cv.threads.timeline.synchronization"
  - "vs.cv.threads.timeline.threadready"
  - "vs.cv.threads.timeline.uiprocessing"
  - "vs.cv.threads.reportnav.unblockedby"
  - "vs.cv.threads.activelegend"
  - "vs.cv.threads.tools.zoom"
helpviewer_keywords:
  - "Concurrency Visualizer, Threads View (Parallel Performance)"
ms.assetid: 2e441103-a266-407b-88c3-fb58716257a3
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Threads view in the Concurrency Visualizer

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

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
 The Synchronization report shows the calls that are responsible for segments that are blocking on synchronization, and the aggregate blocking times of each call stack. For more information, see [Synchronization time](../profiling/synchronization-time.md).

#### Sleep
 The Sleep report shows the calls that are responsible for blocking time that was attributed to time that was spent sleeping, and the aggregate blocking times of each call stack. For more information, see [Sleep time](../profiling/sleep-time.md).

#### I/O
 The I/O report shows the calls that are responsible for segments that are blocking on I/O, and the aggregate blocking times of each call stack. For more information, see [I/O time (threads view)](../profiling/i-o-time-threads-view.md).

#### Memory management
 The Memory Management report shows the calls that are responsible for segments that are blocking on memory management operations, and the aggregate blocking times of each call stack. For more information, see [Memory management time](../profiling/memory-management-time.md).

#### Preemption
 The Preemption report lists the processes that preempted the current process together with the number of instances.  You can expand each process to view the specific threads that replaced threads in the current process and to view a breakdown of preemption instances per thread. This blocking report is less actionable than the others because preemption is typically imposed on your process by the operating system, not by a problem in your code. For more information, see [Preemption time](../profiling/preemption-time.md).

#### UI processing
 The UI Processing report shows the calls that are responsible for blocking segments that are blocking on UI processing blocks, and the aggregate blocking times of each call stack. For more information, see [UI processing time](../profiling/ui-processing-time.md).

## Channels (threads view)

The Concurrency Visualizer shows four kinds of channels: thread channels, disk channels, marker channels, and GPU channels.

### Thread channels
 A thread channel shows thread state, by color, for just one thread. When you pause on the channel name, the start function for the given thread is displayed. The Concurrency Visualizer detects several kinds of threads. The most common kinds are shown in the following table.

|Thread|Description|
|-|-|
|Main thread|The thread that started the app.|
|Worker thread|A thread that was created by the application main thread.|
|CLR Worker Thread|A worker thread that was created by the common language runtime (CLR).|
|Debugger Helper|A worker thread that was created by the Visual Studio debugger.|
|ConcRT Thread|A thread that was created by the Microsoft Concurrency Runtime.|
|GDI Thread|A thread that was created by GDIPlus.|
|OLE/RPC Thread|A thread that was created as an RPC Worker Thread.|
|RPC Thread|A thread that was created as an RPC Thread.|
|Winsock Thread|A thread that was created as a Winsock Thread.|
|Thread Pool|A thread that was created by the CLR Thread Pool.|

### Disk channels
 Disk channels correspond to physical drives in the computer. Because separate channels for Read and Write operations exist for each physical drive on the system, each drive has two channels. The disk numbers correspond to kernel device names. A disk channel is shown only if there was activity on the disk.

### Marker channels
 Marker channels correspond to events generated by the app and the libraries it uses. For example, the Task Parallel Library, Parallel Patterns Library, and C++ AMP generate events that are displayed as markers. Each marker channel is associated with a thread ID, which is displayed next to the description of the channel. The ID identifies the thread that generated the event. The description of the channel includes the name of the Event Tracing for Windows (ETW) provider that generated the events. If the channel displays events from the [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md), the series name is also displayed.

### GPU channels
 GPU channels display information about DirectX 11 activity on the system.  Each DirectX engine that's associated with the graphics card has a separate channel.  The individual segments represent the time that's spent processing a DMA packet.

## Copy selection

To copy the entire call stack from the report tab, click **Copy**. You can then paste the call stack in any program that supports that action.

## Current tab

By clicking the **Current** tab, you can see a call stack (if available) that is closest to the current selection point in the timeline if a CPU thread segment is selected.  In this case, the selection point is represented by a black arrow, or caret, above the timeline. When a blocking segment is selected, the caret is not displayed because there was no execution. However, the segment is still highlighted and a call stack is displayed.

 The **Current** tab also displays information about DirectX activity segments, markers, and I/O access.  For DirectX activity segments, information about the way DMA packets are processed by the hardware queue is displayed.  For markers, information about the description and marker type is displayed.  For I/O access, information about the file and number of bytes read or written is displayed.

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

## Empty timeline segment

In the Concurrency Visualizer, the reason that a section of the timeline is empty (has a white background) depends on the kind of channel.

- For a CPU thread channel, it means that the thread did not exist during this part of the timeline. If you're interested in the thread, you can find its executing section by using the zoom control or scrolling horizontally.

- For an I/O channel, it means that no disk access occurred on behalf of the target process at that point in time.

- For a DirectX channel, it means that no GPU work was performed on behalf of the target process during this part of the timeline.

- For a marker channel, it means that no markers were generated.

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

 This report table can be seen in the [Execution time (Threads View)](../profiling/execution-time-threads-view.md) view.

## Execution time (Threads View)

These segments in the Threads View timeline represent execution time, when the thread is actively doing work on a logical core in the system.

 Changes in thread status are detected through kernel context switch events. Event Tracing for Windows (ETW) captures sample stacks every millisecond. In a very short green segment, it is possible that no sample is taken. Therefore, some short execution segments may show no call stack.

 When you click an execution segment, the Concurrency Visualizer displays the sample stack closest to the location of the click. The location of that sample stack is shown by a black arrow, or caret, above the timeline and the sample stack appears on the **Current** tab.

 To see a traditional sampling profile for all execution segments in the current view, click **Execution** in the Visible Timeline Profile.

## Export button (Concurrency Visualizer)

The **Export** button enables you to export the call stack as a .*csv* file for your own records or for use with another tool such as Microsoft Excel.

## I/O time (Threads View)

These segments in the timeline are associated with blocking times that are categorized as I/O. This means that a thread is waiting for an I/O operation to finish. The thread may have been blocked in an API, or by an I/O-related kernel wait that the Concurrency Visualizer is counting as I/O. APIs such as `CreateFile()`, `ReadFile()`, and `WSARecv()` fall into this group.

## Just My Code (Threads View)

If you select this option, you will filter the call stack to show only your code plus one level of called functions.

 By activating this option, you can significantly reduce the complexity of the call stack and perhaps make it easier to diagnose a particular problem.

 In some cases, selecting this option may filter out the blocking call. If you require full call stack details to make that determination, clear this option to expose the full call stack.

## Manage Channels

In the **Threads View** in the Concurrency Visualizer, you can organize the channels for your process so that you can examine particular patterns. You can sort channels, move them up and down, and hide or show them.

### Sort By
 You can use the Sort By control to sort the threads by different criteria, based on the current zoom level. This is especially useful when you are looking for a particular pattern. You can sort by these criteria:

|Criteria|Definition|
|--------------|----------------|
|Start Time|Sorts threads by their start times. This is the default sort order.|
|End Time|Sorts threads by their end times.|
|Execution|Sorts threads by the percentage of time that's spent in execution.|
|Synchronization|Sorts threads by the percentage of time that's spent in synchronization.|
|I/O|Sorts threads by the percentage of time that's spent in I/O (reading and writing data).|
|Sleep|Sorts threads by the percentage of time that's spent in sleep.|
|Paging|Sorts threads by the percentage of time that's spent in paging.|
|Preemption|Sorts threads by the percentage of time that's spent in preemption.|
|UI Processing|Sorts threads by the percentage of time that's spent in user interface processing.|

### Move selected channel up or down
 You can use these controls to move a channel up or down in the list. For example, you could position related channels next to each other to help you examine a particular pattern or a cross-thread relationship.

### Move selected channel to top or bottom
 You can move selected channels to the top or bottom of the list so that you can examine a particular pattern, or move some channels out of the way when you examine others.

### Hide selected channels
 Choose this control when you want to hide channels. For example, if a thread is 100 percent synchronization for the life of your managed process, you could hide it as you analyze other threads.

> [!NOTE]
> Hiding a thread also removes it from the calculation time, which is shown in the active legend and in the profile reports.

### Show all channels
 This control is active when one or more channels are hidden. If you choose it, all hidden elements are shown and are returned to the calculations of time.

### Move markers to top
 If a trace contains marker events, you can use this command to move the marker channels to the top of the timeline. Their relative order is preserved.

### Group markers by thread
 If a trace contains marker events, you can use this command to group marker channels under the thread that generated the marker events.  The disk channels are moved to the top of the channel list and GPU channels are moved to the bottom.

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

## Measure mode on/off

By using this tool, you can precisely measure a length of time in the timeline. To enable measure mode, click the measure button (which has a ruler icon), and then drag in the timeline. As you drag, notice that the area below the pointer is highlighted in yellow and the time measured appears in the toolbar to the right of the button. This value is calculated dynamically as you drag so that you can immediately see how long a particular event is taking. When you release the mouse button, the time value remains visible.

 You can repeat the measurement process, but only the most recent measurement is shown. Click the measure button again to turn the measure mode off.

## Memory management time

These segments in the timeline are associated with blocking times that are categorized as Memory Management. This scenario implies that a thread is blocked by an event that is associated with a memory management operation such as Paging. During this time, a thread has been blocked in an API or kernel state that the Concurrency Visualizer is counting as memory management. These include events such as paging and memory allocation.

 Examine the associated call stacks and profile reports to better understand the underlying reasons for blocks that are categorized as Memory Management.

## Noise Reduction Percentage

By default, the value of the Noise Reduction Percentage setting is 2. Only entries that have a percentage of inclusive time greater than or equal to this setting are shown in the call tree. By changing the setting, you can control the number of entries that are displayed in the call tree. For example, changing the value to 10 will show only call tree entries that have an inclusive time greater than or equal to 10%. By increasing the value of the setting, you can focus on entries that have larger impacts on the performance of your process.

## Per thread summary report

This bar graph shows the proportion of time each unhidden thread spends in each activity category during the currently visible time range. "Execution" means that the thread is executing; all other categories mean that the thread is waiting for something.

## Preemption time

These segments in the timeline are associated with the blocking time that is categorized as Pre-emption. This category implies that a thread is switched out because of one of these reasons:

- The scheduler replaced it by using a higher priority thread.

- The execution quantum of the thread expired and other threads were ready to execute.

  During this time, a thread has been blocked by a kernel wait reason that the Concurrency Visualizer is counting as Pre-emption. Pre-emption segments start when a thread is pushed out of a logical core, and end when that thread resumes execution.

  The tooltip for a pre-empted segment displays the name of the process or thread that caused the pre-emption. However, this does not imply that the process or thread that took over actually ran throughout the preempted period.

## Report based on visible time range

The Profile view displays reports that are based on the currently visible time range and channels. To see details for different subsets of the data, click items in the legend.

 You can find more information about the data in the tables here.

## Sleep time

These segments in the timeline are associated with the blocking time that is categorized as Sleep. The sleep category implies that a thread has voluntarily given up its logical core and is doing no work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as Sleep. APIs such as `Sleep()` and `SwitchToThread()` fall into this group.

## Synchronization time

These segments in the timeline are associated with blocking times that are categorized as Synchronization. When a thread is marked as blocked on synchronization, one of these things is implied:

- The execution of the thread may have resulted in a call to a well-known thread synchronization API such as `EnterCriticalSection()` or `WaitForSingleObject()`.

- The API matching algorithm cannot be totally comprehensive, and therefore some APIs that could be mapped to other categories may also appear as synchronization because a frame in the call stack eventually reached an underlying kernel blocking primitive that was mapped to this category.

  To understand the underlying cause for a thread blocking event, carefully examine the blocking call stacks and profile reports.

## Thread ready connector

When you click a blocking segment to see a call stack and its unblocking stack, the thread ready connector may also appear. If the unblocking event occurred on another thread in the current process, the thread ready connector visually identifies the thread and execution segment that enabled the blocked thread to resume execution.

## UI processing time

These segments in the timeline are associated with blocking times that are categorized as UI Processing. This implies that a thread is pumping Windows messages or performing other user interface (UI) work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as UI Processing. APIs such as `GetMessage()` and `MsgWaitForMultipleObjects()` fall into this group.

 If no pre-defined blocking API is identified, review the call stacks and profile reports to determine the underlying causes of delay.

 The UI Processing category helps you understand the responsiveness of GUI applications, and is desirable in applications that depend on UI responsiveness. For example, if the UI thread in an application achieves 100% time in UI Processing, it is probably responsive. However, if the UI thread spends considerable time in other categories, look for the root causes and consider options for reducing non-UI categories on that thread.

## Unblock stack

If the currently selected thread element represents a blocked segment that later began to execute after it was unblocked by another thread in the current process, the call stack for the thread that did the unblocking is shown on this tab.

## Visible timeline profile

The Visible Timeline Profile for the Thread Blocking View provides statistical information and links to reports. As you zoom in, zoom out, scroll horizontally, hide channels, or show channels, the numbers in the active legend change to reflect what is currently in view. To view a report about an item in the Legend, click the item.

## Zoom control (threads view)

The zoom control is a slider that helps you to zoom in and out on the timeline so that you can focus on areas of particular interest. Because this control zooms in on the center of the timeline view, center the area of interest before you zoom in.

### Zoom in by dragging in the timeline view
 Zooming in by dragging in the timeline view creates an area that is highlighted in yellow. When you release the mouse button, the timeline view zooms in on the selected range.

### Zoom in and out by using the mouse wheel
 Click on any point on the timeline (to ensure it has mouse focus), and then press **Ctrl** and move the mouse wheel (forward zooms in; backward zooms out).

## See also

- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
