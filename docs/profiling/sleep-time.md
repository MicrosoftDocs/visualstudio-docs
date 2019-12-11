---
title: "Sleep Time | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.timeline.sleep"
helpviewer_keywords:
  - "Concurrency Visualizer, Sleep Time"
ms.assetid: 3ddb96f9-9bda-4a68-ad4d-ef488a0a68dc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Sleep time
These segments in the timeline are associated with the blocking time that is categorized as Sleep. The sleep category implies that a thread has voluntarily given up its logical core and is doing no work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as Sleep. APIs such as `Sleep()` and `SwitchToThread()` fall into this group.

## See also
- [Threads view](../profiling/threads-view-parallel-performance.md)