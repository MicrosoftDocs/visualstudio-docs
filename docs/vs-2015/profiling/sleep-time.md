---
title: "Sleep Time | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.cv.threads.timeline.sleep"
helpviewer_keywords: 
  - "Concurrency Visualizer, Sleep Time"
ms.assetid: 3ddb96f9-9bda-4a68-ad4d-ef488a0a68dc
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Sleep Time
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [Sleep Time](https://docs.microsoft.com/visualstudio/profiling/sleep-time).  
  
These segments in the timeline are associated with the blocking time that is categorized as Sleep. The sleep category implies that a thread has voluntarily given up its logical core and is doing no work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as Sleep. APIs such as `Sleep()` and `SwitchToThread()` fall into this group.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)



