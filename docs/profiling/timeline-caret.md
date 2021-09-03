---
title: "Timeline Caret | Microsoft Docs"
description: Learn how the caret shows the exact location of the call stack, which is the closest call stack to the location that the user selected.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.timeline.caret"
helpviewer_keywords:
  - "Concurrency Visualizer, Timeline Caret"
ms.assetid: cc7d567f-b655-4539-810c-6506e7852121
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Timeline caret
When you select a point on the timeline of an executing thread segment, a Timeline caret appears above it. The call stack that is displayed on the current stack tab is the one that is closest in time to where you clicked the segment. The caret is used to associate the call stack, which is displayed under the **Current** tab, with the instant when it was sampled. The caret shows the exact location of the call stack, which is the closest call stack to the location that the user selected.

## See also
- [Threads View](../profiling/threads-view-parallel-performance.md)