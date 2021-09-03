---
title: "Just My Code (Threads View) | Microsoft Docs"
description: Learn how you will filter the call stack to show only your code plus one level of called functions if you select the Just My Code option.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.jmc"
helpviewer_keywords:
  - "Concurrency Visualizer, Just My Code (Threads View)"
ms.assetid: a9ac8a2c-9d99-4207-8ed4-e87f033f440d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Just My Code (Threads View)
If you select this option, you will filter the call stack to show only your code plus one level of called functions.

 By activating this option, you can significantly reduce the complexity of the call stack and perhaps make it easier to diagnose a particular problem.

 In some cases, selecting this option may filter out the blocking call. If you require full call stack details to make that determination, clear this option to expose the full call stack.

## See also
- [Threads View](../profiling/threads-view-parallel-performance.md)
- [Noise reduction percentage](../profiling/noise-reduction-percentage.md)