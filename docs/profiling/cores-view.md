---
title: "Cores View | Microsoft Docs"
description: Learn about the information provided by Cores View. It can help you use thread affinity or thread pool management to optimize cache performance.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.cores"
helpviewer_keywords:
  - "Concurrency Visualizer, Cores View"
ms.assetid: e47af672-9785-4899-bd45-4d9dda3c396f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Cores View
The **Cores View** shows how thread execution was mapped to the logical processor cores (choose **Analyze** > **Concurrency Visualizer** to start the concurrency visualizer). If you're writing server applications, this view can help you optimize cache performance by using thread affinity or thread pool management. It can also help you examine cases where the use of thread affinity may have worsened the problem of cross-core migration. The Cores View has two parts, a graph and a legend.

 The graph shows logical cores on the y-axis and time on the x-axis. Every thread in the graph has a unique color so that you can track its movement across cores over time. You can filter the threads on this graph by selecting them in the legend area.

 The legend area has an entry for each color in the graph. Each entry shows the thread color and name, the number of cross-core context switches, the total number of context switches, and the percentage of context switches that cross cores. The legend is sorted by the number of cross-core context switches, in decreasing order. It lists only the threads that executed during the displayed time range.  The list is updated if you zoom or pan.

## See also
- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
- [Utilization View](../profiling/utilization-view.md)
- [Threads View](../profiling/threads-view-parallel-performance.md)