---
title: "Sleep Time"
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
  - "vs.cv.threads.timeline.sleep"
helpviewer_keywords: 
  - "Concurrency Visualizer, Sleep Time"
ms.assetid: 3ddb96f9-9bda-4a68-ad4d-ef488a0a68dc
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
# Sleep Time
These segments in the timeline are associated with the blocking time that is categorized as Sleep. The sleep category implies that a thread has voluntarily given up its logical core and is doing no work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as Sleep. APIs such as `Sleep()` and `SwitchToThread()` fall into this group.  
  
## See Also  
 [Threads View](../profiling/threads-view--parallel-performance-.md)