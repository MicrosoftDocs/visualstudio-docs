---
title: "Manage Channels | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.tools.managechannels"
helpviewer_keywords: 
  - "Concurrency Visualizer, Manage Channels"
ms.assetid: 507b06e9-bb56-4a72-8fd5-f91f958da6fc
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Manage Channels
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the **Threads View** in the Concurrency Visualizer, you can organize the channels for your process so that you can examine particular patterns. You can sort channels, move them up and down, and hide or show them.  
  
## Sort By  
 You can use the Sort By control to sort the threads by different criteria, based on the current zoom level. This is especially useful when you are looking for a particular pattern. You can sort by these criteria:  
  
|Criteria|Definition|  
|--------------|----------------|  
|Start Time|Sorts threads by their start times. This is the default sort order.|  
|End Time|Sorts threads by their end times.|  
|Execution|Sorts threads by the percentage of time that's spent in execution.|  
|Synchronization|Sorts threads by the percentage of time that's spent in synchronization.|  
|I/O|Sorts threads by the percentage of time that's spent in I/O (reading and writing data).|  
|Sleep|Sorts threads by the percentage of time that's spent in sleep.|  
|Paging|Sorts threads by the percentage of time that's spent in paging.|  
|Preemption|Sorts threads by the percentage of time that's spent in preemption.|  
|UI Processing|Sorts threads by the percentage of time that's spent in user interface processing.|  
  
## Move Selected Channel Up or Down  
 You can use these controls to move a channel up or down in the list. For example, you could position related channels next to each other to help you examine a particular pattern or a cross-thread relationship.  
  
## Move Selected Channel to Top or Bottom  
 You can move selected channels to the top or bottom of the list so that you can examine a particular pattern, or move some channels out of the way when you examine others.  
  
## Hide Selected Channels  
 Choose this control when you want to hide channels. For example, if a thread is 100 percent synchronization for the life of your managed process, you could hide it as you analyze other threads.  
  
> [!NOTE]
> Hiding a thread also removes it from the calculation time, which is shown in the active legend and in the profile reports.  
  
## Show All Channels  
 This control is active when one or more channels are hidden. If you choose it, all hidden elements are shown and are returned to the calculations of time.  
  
## Move Markers to Top  
 If a trace contains marker events, you can use this command to move the marker channels to the top of the timeline. Their relative order is preserved.  
  
## Group Markers by Thread  
 If a trace contains marker events, you can use this command to group marker channels under the thread that generated the marker events.  The disk channels are moved to the top of the channel list and GPU channels are moved to the bottom.  
  
## See Also  
 [Zoom Control (Threads View)](../profiling/zoom-control-threads-view.md)   
 [Measure Mode On/Off](../profiling/measure-mode-on-off.md)   
 [Threads View](../profiling/threads-view-parallel-performance.md)
