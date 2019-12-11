---
title: "Current Tab | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.reportnav.current"
helpviewer_keywords: 
  - "Concurrency Visualizer, Callstack at Selection Point"
ms.assetid: 2c7b1ae5-3756-4795-bc59-f6bb113f2ba5
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Current Tab
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By clicking the **Current** tab, you can see a call stack (if available) that is closest to the current selection point in the timeline if a CPU thread segment is selected.  In this case, the selection point is represented by a black arrow, or caret, above the timeline. When a blocking segment is selected, the caret is not displayed because there was no execution. However, the segment is still highlighted and a call stack is displayed.  
  
 The **Current** tab also displays information about DirectX activity segments, markers, and I/O access.  For DirectX activity segments, information about the way DMA packets are processed by the hardware queue is displayed.  For markers, information about the description and marker type is displayed.  For I/O access, information about the file and number of bytes read or written is displayed.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)
