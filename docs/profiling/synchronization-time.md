---
title: "Synchronization Time | Microsoft Docs"
description: Learn how segments in the timeline are associated with blocking times that are categorized as Synchronization. 
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.timeline.synchronization"
helpviewer_keywords:
  - "Concurrency Visualizer, Synchronization Time"
ms.assetid: affa04cc-8bba-4848-9301-b19846d3c2cb
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Synchronization time
These segments in the timeline are associated with blocking times that are categorized as Synchronization. When a thread is marked as blocked on synchronization, one of these things is implied:

- The execution of the thread may have resulted in a call to a well-known thread synchronization API such as `EnterCriticalSection()` or `WaitForSingleObject()`.

- The API matching algorithm cannot be totally comprehensive, and therefore some APIs that could be mapped to other categories may also appear as synchronization because a frame in the call stack eventually reached an underlying kernel blocking primitive that was mapped to this category.

  To understand the underlying cause for a thread blocking event, carefully examine the blocking call stacks and profile reports.

## See also
- [Threads view](../profiling/threads-view-parallel-performance.md)