---
title: "Disk Operations Report (Threads View) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.report.diskoperations"
helpviewer_keywords: 
  - "Concurrency Visualizer, File Operations Report (Threads View)"
ms.assetid: e352f4f3-f654-45eb-96ed-417863487ddc
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Disk Operations Report (Threads View)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Disk Operations Report shows disk I/O operations in the disk channels.  
  
 For each disk access that occurs on behalf of the process that's being profiled in the currently visible time window, this information is reported:  
  
- The name and PID of the process that performed the disk access  
  
- The ID of the thread that accessed the disk  
  
- The name of the file that was accessed  
  
- The number of reads per file  
  
- The number of bytes read  
  
- The read latency, in milliseconds  
  
- The number of writes  
  
- The number of bytes written  
  
- The write latency, in milliseconds  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)
