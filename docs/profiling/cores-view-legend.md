---
title: "Cores View Legend | Microsoft Docs"
description: Learn about the Cores View legend, which provides tabular context switch data and thread selection. Also learn about context switches and performance.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.cores.legend"
helpviewer_keywords:
  - "Concurrency Visualizer, Cores View Legend"
ms.assetid: e160384c-fcfe-49b3-86b7-229adb736c51
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Cores View legend
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

## See also
- [Cores View](../profiling/cores-view.md)