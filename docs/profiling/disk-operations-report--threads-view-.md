---
title: "Disk Operations Report (Threads View)"
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
  - "vs.cv.threads.report.diskoperations"
helpviewer_keywords: 
  - "Concurrency Visualizer, File Operations Report (Threads View)"
ms.assetid: e352f4f3-f654-45eb-96ed-417863487ddc
caps.latest.revision: 11
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Disk Operations Report (Threads View)
The Disk Operations Report shows disk I/O operations in the disk channels.  
  
 For each disk access that occurs on behalf of the process that's being profiled in the currently visible time window, this information is reported:  
  
-   The name and PID of the process that performed the disk access  
  
-   The ID of the thread that accessed the disk  
  
-   The name of the file that was accessed  
  
-   The number of reads per file  
  
-   The number of bytes read  
  
-   The read latency, in milliseconds  
  
-   The number of writes  
  
-   The number of bytes written  
  
-   The write latency, in milliseconds  
  
## See Also  
 [Threads View](../profiling/threads-view--parallel-performance-.md)