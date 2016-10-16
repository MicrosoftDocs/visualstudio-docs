---
title: "Synchronization Time"
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
  - "vs.cv.threads.timeline.synchronization"
helpviewer_keywords: 
  - "Concurrency Visualizer, Synchronization Time"
ms.assetid: affa04cc-8bba-4848-9301-b19846d3c2cb
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
# Synchronization Time
These segments in the timeline are associated with blocking times that are categorized as Synchronization. When a thread is marked as blocked on synchronization, one of these things is implied:  
  
-   The execution of the thread may have resulted in a call to a well-known thread synchronization API such as `EnterCriticalSection()` or `WaitForSingleObject()`.  
  
-   The API matching algorithm cannot be totally comprehensive, and therefore some APIs that could be mapped to other categories may also appear as synchronization because a frame in the call stack eventually reached an underlying kernel blocking primitive that was mapped to this category.  
  
 To understand the underlying cause for a thread blocking event, carefully examine the blocking call stacks and profile reports.  
  
## See Also  
 [Threads View](../profiling/threads-view--parallel-performance-.md)