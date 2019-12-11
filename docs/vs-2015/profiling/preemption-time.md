---
title: "Preemption Time | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.timeline.preemption"
helpviewer_keywords: 
  - "Concurrency Visualizer, Preemption Time"
ms.assetid: 6b78f91e-a006-440c-83fb-e7368040951d
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Preemption Time
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

These segments in the timeline are associated with the blocking time that is categorized as Preemption. This category implies that a thread is switched out because of one of these reasons:  
  
- The scheduler replaced it by using a higher priority thread.  
  
- The execution quantum of the thread expired and other threads were ready to execute.  
  
  During this time, a thread has been blocked by a kernel wait reason that the Concurrency Visualizer is counting as Preemption. Preemption segments start when a thread is pushed out of a logical core, and end when that thread resumes execution.  
  
  The tooltip for a preempted segment displays the name of the process or thread that caused the preemption. However, this does not imply that the process or thread that took over actually ran throughout the preempted period.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)
