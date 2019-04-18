---
title: "Empty Timeline Segment | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.timeline.empty"
helpviewer_keywords: 
  - "Concurrency Visualizer, empty timeline segment"
ms.assetid: f37b301f-3edc-4e56-8084-feec2dc5a9b1
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Empty Timeline Segment
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the Concurrency Visualizer, the reason that a section of the timeline is empty (has a white background) depends on the kind of channel.  
  
- For a CPU thread channel, it means that the thread did not exist during this part of the timeline. If you're interested in the thread, you can find its executing section by using the zoom control or scrolling horizontally.  
  
- For an I/O channel, it means that no disk access occurred on behalf of the target process at that point in time.  
  
- For a DirectX channel, it means that no GPU work was performed on behalf of the target process during this part of the timeline.  
  
- For a marker channel, it means that no markers were generated.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)   
 [Zoom Control (Threads View)](../profiling/zoom-control-threads-view.md)
