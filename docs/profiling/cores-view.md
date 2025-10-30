---
title: "Cores View"
description: Learn about the information provided by Cores View. It can help you use thread affinity or thread pool management to optimize cache performance.
ms.date: "11/04/2016"
ms.topic: article
f1_keywords:
  - "vs.performance.view.cores"
  - "vs.cv.cores.legend"
  - "vs.cv.cores.timeline.threads"
  - "vs.cv.cores.timeline.logicalcores"
  - "vs.cv.cores.zoom"
helpviewer_keywords:
  - "Concurrency Visualizer, Cores View"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Cores View

The **Cores View** shows how thread execution was mapped to the logical processor cores (choose **Analyze** > **Concurrency Visualizer** to start the concurrency visualizer). If you're writing server applications, this view can help you optimize cache performance by using thread affinity or thread pool management. It can also help you examine cases where the use of thread affinity may have worsened the problem of cross-core migration. The Cores View has two parts, a graph and a legend.

 The graph shows logical cores on the y-axis and time on the x-axis. Every thread in the graph has a unique color so that you can track its movement across cores over time. You can filter the threads on this graph by selecting them in the legend area.

 The legend area has an entry for each color in the graph. Each entry shows the thread color and name, the number of cross-core context switches, the total number of context switches, and the percentage of context switches that cross cores. The legend is sorted by the number of cross-core context switches, in decreasing order. It lists only the threads that executed during the displayed time range.  The list is updated if you zoom or pan.

## Cores View legend

The Cores View legend identifies each thread by color and name. It includes columns that show counts for cross-core context switches, total context switches, and the percent of context switches that cross cores. Rows in the legend are sorted by the number of cross-core context switches, in decreasing order.

 You can select rows in the legend to filter the threads that are displayed in the timeline. Only the selected threads are shown in the timeline. If no rows are selected, all rows are shown in the timeline.

 Cross-core context switches cost more in overhead and performance than switches that remain on the same logical core. During context switches, the processor registers are saved and restored, the operating system kernel code is executed, the translation lookaside buffer entries are reloaded, and the processor pipeline is flushed. Cross-core context switches can be even more expensive than other context switches because the cache data is not valid for this thread on another core. In contrast, if a thread is context-switched onto the core it previously ran on, it's likely that the useful data is still in the cache. When cross-core context switches have been increased by attempts to manage thread affinity and performance is degraded, consider whether to address this issue. Start by eliminating thread affinity, and then observe the resulting cross-core behavior.

 The following table describes the legend elements.

|Element|Definition|
|-------------|----------------|
|Thread Name|Shows the color of the thread in the previous cores timeline, and the name of that thread.|
|Cross-Core Context Switches|The number of context switches for a thread that also switched from one logical core to another. It doesn't differentiate between cross-core context switches that cross from one processor die to another versus those that stay on the same die.|
|Total Context Switches|The total number of context switches for a given thread during the sampling period. Each time a thread changes context (for example, from execution to synchronization) one context switch is counted.|
|Percent of Context Switches that Cross Cores|Computed as a percentage by dividing the number of cross-core context switches by the number of total context switches. The higher this percentage, the greater the overall effect of the overhead of cross-core context switches on the performance of this particular thread.|

## Cores View timeline

Every row in the timeline represents a logical processor core on the profiled system. For each row, the horizontal axis shows which thread was running on a logical core at a given point in time. You can hover over a color of interest in a timeline to return a tooltip that identifies the thread. To help with thread identification, the legend at the bottom of the window shows what each color represents. Use the Zoom tool to zoom in and out, by clicking and dragging or by pressing CTRL and moving the mouse wheel. Zoom consistency is maintained when you switch between Cores View and Threads View.

## Cores View logical cores

Each channel name represents one of the logical cores that exist on the profiled system. The naming counts up from 0 to the total number of logical cores. For example, a four-core system will count from logical core 0 to logical core 3.

## Cores View Zoom tool

The Zoom control is a slider that lets you zoom in and out on the timeline so that you can focus on areas of particular interest. This control zooms on the center of the current view, so adjust the view before you zoom in.

### Other ways to zoom

- Zooming in: Drag to select an area in the timeline view. When you release the mouse button, the timeline view zooms in on the selected range.

- Zooming in and out: Hover over the timeline and then press **Ctrl** while you move the mouse wheel.

## Related content
- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
- [Utilization View](../profiling/utilization-view.md)
- [Threads View](../profiling/threads-view-parallel-performance.md)
