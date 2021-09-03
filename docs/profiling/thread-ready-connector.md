---
title: "Thread Ready Connector | Microsoft Docs"
description: Learn that when you click a blocking segment to see a call stack and its unblocking stack, the thread ready connector may also appear.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.timeline.threadready"
helpviewer_keywords:
  - "Concurrency Visualizer, Thread Ready"
ms.assetid: 68e1ec38-4b10-4b01-b32f-6c9a00b2443c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Thread ready connector
When you click a blocking segment to see a call stack and its unblocking stack, the thread ready connector may also appear. If the unblocking event occurred on another thread in the current process, the thread ready connector visually identifies the thread and execution segment that enabled the blocked thread to resume execution.