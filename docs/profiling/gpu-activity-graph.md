---
title: "GPU Activity Graph | Microsoft Docs"
description: Understand the GPU Activity graph, which displays in Concurrency Visualizer the level of DirectX activity on the system.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.cpu.graph.gpu"
ms.assetid: d7c769af-95fb-49a3-b5ab-deafecee46fa
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# GPU Activity graph
The GPU Activity graph in the Concurrency Visualizer displays the level of DirectX activity on the system as measured by the number of DirectX engines that are in use over time.  The graph doesn't show which specific engines were used.  An engine is considered to be in use if it is processing any GPU work.

## GPU Activity graph colors
 Green indicates the consumption of DirectX Engines by the current process.

 Light gray indicates the consumption of DirectX Engines by other processes on the system. To reduce the consumption of DirectX engines by other processes, reduce the number of other processes running on the system.

 White indicates the availability of unused DirectX engines on the system. Those engines are available for your process if you can find more opportunities to exploit them. Some engines can only be used for specific kinds of tasks.

## See also
- [Utilization View](../profiling/utilization-view.md)