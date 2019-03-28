---
title: "I-O Time (Threads View) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.timeline.io"
helpviewer_keywords: 
  - "Concurrency Visualizer, I/O time (Threads View)"
ms.assetid: 0c4ec14d-d8dd-49c1-999c-dcbf4e8e1dc8
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# I/O Time (Threads View)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

These segments in the timeline are associated with blocking times that are categorized as I/O. This means that a thread is waiting for an I/O operation to finish. The thread may have been blocked in an API, or by an I/O-related kernel wait that the Concurrency Visualizer is counting as I/O. APIs such as `CreateFile()`, `ReadFile()`, and `WSARecv()` fall into this group.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)
