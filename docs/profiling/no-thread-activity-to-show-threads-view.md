---
title: "No Thread Activity to Show (Threads View)"
description: Learn about the Threads view where there is no activity to show in the currently visible time range.
ms.date: "11/04/2016"
ms.topic: "error-reference"
f1_keywords:
  - "vs.cv.threads.nothreadreport"
helpviewer_keywords:
  - "Concurrency Visualizer, No Thread Activity to Show (Threads View)"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# No thread activity to show (Threads View)

This area shows data about the unhidden threads in the currently visible time range.

 If no information is visible, check the following settings:

- Is the zoom level high? Try zooming out or scrolling to bring more thread activity in range.

- Are too many threads hidden? If so, try showing all threads

- If **Just My Code** is selected, you can only view data about your code. Try clearing the setting to ascertain whether there is any system thread activity.

- Make sure that Noise Reduction is set to a low threshold.

## See also
- [Threads View](../profiling/threads-view-parallel-performance.md)