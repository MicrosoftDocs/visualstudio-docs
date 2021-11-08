---
title: "Unblocking Stack | Microsoft Docs"
description: Learn how the call stack for the thread that did the unblocking is shown in the tab after it was unblocked by another thread in the current process.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.reportnav.unblockedby"
helpviewer_keywords:
  - "Concurrency Visualizer, Unblocking Stack"
ms.assetid: 1a4dfd9a-e7e2-4aa3-93e2-4f12c7b0970f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Unblock stack
If the currently selected thread element represents a blocked segment that later began to execute after it was unblocked by another thread in the current process, the call stack for the thread that did the unblocking is shown on this tab.

## See also
- [Threads View](../profiling/threads-view-parallel-performance.md)