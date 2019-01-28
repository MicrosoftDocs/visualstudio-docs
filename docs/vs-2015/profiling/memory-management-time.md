---
title: "Memory Management Time | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.timeline.paging"
helpviewer_keywords: 
  - "Concurrency Visualizer, Paging Time"
ms.assetid: 67af3509-3a7d-435d-bc37-5262448da915
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Memory Management Time
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

These segments in the timeline are associated with blocking times that are categorized as Memory Management. This implies that a thread is blocked by an event that is associated with a memory management operation such as Paging. During this time, a thread has been blocked in an API or kernel state that the Concurrency Visualizer is counting as memory management. These include events such as paging and memory allocation.  
  
 Examine the associated call stacks and profile reports to better understand the underlying reasons for blocks that are categorized as Memory Management.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)
