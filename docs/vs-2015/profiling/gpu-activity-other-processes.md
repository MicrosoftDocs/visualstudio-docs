---
title: "GPU Activity (Other Processes) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.timeline.gpuother"
  - "vs.cv.threads.timeline.gpuactivity"
ms.assetid: 8a68df65-eb63-452f-9285-fb4ffc92f2b2
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# GPU Activity (Other Processes)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **GPU Activity (Other Processes)** segments in the Threads view  of the Concurrency Visualizer represent times when the GPU was processing requests on behalf of other processes on the system. These requests are sent the GPU as direct memory access (DMA) packets.  The length of a segment represents the duration of time that the packet was processed by the GPU.  
  
 When you select this kind of segment, the report on the **Current** tab displays information about the packet that was processed.  The information includes the amount of time that the packet waited in the hardware queue that's associated with the DirectX engine, the process that submitted the packet, and the time that was required to process the packet.
