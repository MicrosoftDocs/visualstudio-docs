---
title: "CPU Utilization Graph | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.cpu.graph"
helpviewer_keywords: 
  - "CPU Utilization GraphConcurrency Visualizer, CPU Utilization Graph"
ms.assetid: 5332fd38-622d-47a3-874f-8c2fd7a30f95
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CPU Utilization Graph
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The CPU Utilization graph shows the level of utilization in an app over time. The X-axis represents the duration of the trace, and the y-axis represents the number of logical cores on the system. The graph doesn't show which specific core is active at any given time. For example, if two cores are each running at 50 percent capacity for a given time period, then this view shows one logical core being utilized.  
  
## CPU Utilization graph colors  
  
- Green indicates the utilization of the logical cores in the system by the current process.  
  
- Light gray indicates the utilization of logical cores by other processes on the system. A high percentage of light gray in the CPU graph indicates that the system is heavily loaded by other processes and that your process is likely to be pre-empted by them. To reduce the consumption of logical cores by other processes, reduce the number of them running on the system.  
  
- Dark gray indicates the consumption of logical cores by the system process. You can't directly control this, but it's useful to know when it's occurring because it can affect the availability of logical cores for your process.  
  
- White indicates the availability of unused logical cores on the system. Those cores are available for your process if you can find more opportunities for parallelism.  
  
## See Also  
 [Utilization View](../profiling/utilization-view.md)   
 [Average CPU Utilization](../profiling/average-cpu-utilization.md)
