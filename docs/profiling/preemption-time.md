---
title: "Preemption Time"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.cv.threads.timeline.preemption"
helpviewer_keywords: 
  - "Concurrency Visualizer, Preemption Time"
ms.assetid: 6b78f91e-a006-440c-83fb-e7368040951d
caps.latest.revision: 6
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Preemption Time
These segments in the timeline are associated with the blocking time that is categorized as Preemption. This category implies that a thread is switched out because of one of these reasons:  
  
-   The scheduler replaced it by using a higher priority thread.  
  
-   The execution quantum of the thread expired and other threads were ready to execute.  
  
 During this time, a thread has been blocked by a kernel wait reason that the Concurrency Visualizer is counting as Preemption. Preemption segments start when a thread is pushed out of a logical core, and end when that thread resumes execution.  
  
 The tooltip for a preempted segment displays the name of the process or thread that caused the preemption. However, this does not imply that the process or thread that took over actually ran throughout the preempted period.  
  
## See Also  
 [Threads View](../profiling/threads-view--parallel-performance-.md)