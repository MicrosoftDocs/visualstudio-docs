---
title: "Threads view in the Concurrency Visualizer"
description: Explore the Threads view in the Concurrency Visualizer, where you can identify which threads are executing code during an execution segment.
ms.date: "05/06/2022"
ms.topic: article
f1_keywords:
  - "vs.performance.view.threadblocking"
  - "vs.cv.threads.timeline.channelnames"
  - "vs.cv.threads.selection.copy"
  - "vs.cv.threads.reportnav.current"
  - "vs.cv.threads.timeline.empty"
  - "vs.cv.threads.export"
  - "vs.cv.threads.jmc"
  - "vs.cv.threads.tools.managechannels"
  - "vs.cv.threads.tools.measure"
  - "vs.cv.threads.filter"
  - "vs.cv.threads.reportnav.profile"
  - "vs.cv.threads.timeline.threadready"
  - "vs.cv.threads.timeline.caret"
  - "vs.cv.threads.reportnav.unblockedby"
  - "vs.cv.threads.activelegend"
  - "vs.cv.threads.tools.zoom"
helpviewer_keywords:
  - "Concurrency Visualizer, Threads View (Parallel Performance)"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Threads view in the Concurrency Visualizer

**Threads** view is the most detailed and feature-rich view in the Concurrency Visualizer. In the **Threads** view, you can identify which threads are executing code during an execution segment, and analyze whether threads are executing or blocking because of synchronization, I/O, or other reasons. **Threads** view reports also profile call-stack tree execution and unblocking threads.

While threads are executing, the Concurrency Visualizer collects samples. When a thread has stopped executing, the visualizer examines all operating system context-switch events for the thread. Context switches can occur because:

- A thread is blocked on a synchronization primitive.
- The quantum of a thread expires.
- A thread makes a blocking I/O request.

Concurrency Visualizer categorizes thread and context-switch events, and searches the call stacks of threads for well-known blocking APIs. It displays the thread categories in the active legend at lower-left in the **Threads** view. In most cases, you can identify the root cause of a blocking event by examining the call stacks that correspond to context-switch events.

If there's no call stack match, Concurrency Visualizer uses the wait reason provided by Windows. However, the Windows category may be based on an implementation detail, and may not reflect user intent. For example, Windows reports the wait reason for blocking on a native slim reader-writer lock as I/O instead of Synchronization.

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

  To find the line of code in which execution time is spent, expand the call tree and on the shortcut menu for the call tree entry, select **View Source** or **View Call Sites**. **View Source** locates the executed line of code. **View Call Sites** locates the line of code that called the executed line. If only one call site line exists, its code is highlighted. If several call sites exist, select the one you want in the dialog box, and then select **Go to source**. It's often most useful to locate the call site that has the most instances, the most time, or both. For more information, see [Execution profile report](../profiling/threads-view-timeline-reports.md#execution-time-threads-view).

- **Synchronization**
  The **Synchronization** report shows the calls that are responsible for synchronization blocks, along with the total blocking times of each call stack. For more information, see [Synchronization time](../profiling/threads-view-timeline-reports.md#synchronization-time).

- **I/O**
  The **I/O** report shows the calls that are responsible for I/O blocks, along with the total blocking times of each call stack. For more information, see [I/O time (Threads view)](../profiling/threads-view-timeline-reports.md#io-time-threads-view).

- **Sleep**
  The **Sleep** report shows the calls that are responsible for sleep blocks, along with the total blocking times of each call stack. For more information, see [Sleep time](../profiling/threads-view-timeline-reports.md#sleep-time).

- **Memory Management**
  The **Memory Management** report shows the calls where memory management blocks occurred, along with the total blocking times of each call stack. Use this information to identify areas that have excessive paging or garbage collection issues.  For more information, see [Memory management time](../profiling/threads-view-timeline-reports.md#memory-management-time).

- **Preemption**
  The **Preemption** report shows where processes on the system preempted the current process, and individual threads that replaced threads in the current process. You can use this information to identify the processes and threads that are most responsible for preemption. For more information, see [Preemption time](../profiling/threads-view-timeline-reports.md#preemption-time).

- **UI Processing**
  The **UI Processing** report shows the calls that are responsible for UI processing blocks, along with the total blocking times of each call stack. For more information, see [UI processing time](../profiling/threads-view-timeline-reports.md#ui-processing-time).

- **Per Thread Summary**
  Select **Per Thread Summary** to display a graph showing the state of threads for the currently selected time interval. The color-coded columns show the total time each thread spent in run, blocked, I/O and other states. The threads are labeled at the bottom. When you adjust the zoom level in the timeline graph, this graph automatically updates.

  At some zoom levels, some threads might not show in the graph. When this happens, ellipses (**...**) appear at the right. If the thread you want does not appear, you can hide other threads. For more information, see [Per thread summary report](../profiling/threads-view-reports.md#per-thread-summary-report).

- **Disk Operations**
  Select **Disk Operations** to show processes and threads involved in disk I/O for the current process, files they touched (for example, DLLs they loaded), how many bytes they read, and other information. You can use this report to evaluate time spent accessing files during execution, especially when your process seems to be I/O-bound. For more information, see [Disk operations report](../profiling/threads-view-reports.md#disk-operations-report-threads-view).

### Current tab
This tab shows the call stack for a selected point on a thread segment in the timeline graph. The call stacks are trimmed to show only activity that is related to your app.

### Unblocking Stack tab
This tab shows which thread unblocked the selected thread, and the unblocking call stack.

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

## Empty timeline segment

In the Concurrency Visualizer, the reason that a section of the timeline is empty (has a white background) depends on the kind of channel.

- For a CPU thread channel, it means that the thread did not exist during this part of the timeline. If you're interested in the thread, you can find its executing section by using the zoom control or scrolling horizontally.

- For an I/O channel, it means that no disk access occurred on behalf of the target process at that point in time.

- For a DirectX channel, it means that no GPU work was performed on behalf of the target process during this part of the timeline.

- For a marker channel, it means that no markers were generated.

## Export button (Concurrency Visualizer)

The **Export** button enables you to export the call stack as a .*csv* file for your own records or for use with another tool such as Microsoft Excel.

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

## Measure mode on/off

By using this tool, you can precisely measure a length of time in the timeline. To enable measure mode, click the measure button (which has a ruler icon), and then drag in the timeline. As you drag, notice that the area below the pointer is highlighted in yellow and the time measured appears in the toolbar to the right of the button. This value is calculated dynamically as you drag so that you can immediately see how long a particular event is taking. When you release the mouse button, the time value remains visible.

 You can repeat the measurement process, but only the most recent measurement is shown. Click the measure button again to turn the measure mode off.

## Noise Reduction Percentage

By default, the value of the Noise Reduction Percentage setting is 2. Only entries that have a percentage of inclusive time greater than or equal to this setting are shown in the call tree. By changing the setting, you can control the number of entries that are displayed in the call tree. For example, changing the value to 10 will show only call tree entries that have an inclusive time greater than or equal to 10%. By increasing the value of the setting, you can focus on entries that have larger impacts on the performance of your process.

## Report based on visible time range

The Profile view displays reports that are based on the currently visible time range and channels. To see details for different subsets of the data, click items in the legend.

 You can find more information about the data in the [Threads View reports](../profiling/threads-view-reports.md).

## Thread ready connector

When you click a blocking segment to see a call stack and its unblocking stack, the thread ready connector may also appear. If the unblocking event occurred on another thread in the current process, the thread ready connector visually identifies the thread and execution segment that enabled the blocked thread to resume execution.

## Timeline caret

When you select a point on the timeline of an executing thread segment, a Timeline caret appears above it. The call stack that is displayed on the current stack tab is the one that is closest in time to where you clicked the segment. The caret is used to associate the call stack, which is displayed under the Current tab, with the instant when it was sampled. The caret shows the exact location of the call stack, which is the closest call stack to the location that the user selected.

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

## Related content

- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
