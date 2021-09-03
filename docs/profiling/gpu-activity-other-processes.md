---
title: "GPU Activity (Other Processes) | Microsoft Docs"
description: Learn about the GPU Activity (Other Processes) segments in the Threads view of the Concurrency Visualizer.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.cv.threads.timeline.gpuother"
  - "vs.cv.threads.timeline.gpuactivity"
ms.assetid: 8a68df65-eb63-452f-9285-fb4ffc92f2b2
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# GPU Activity (Other Processes)
The **GPU Activity (Other Processes)** segments in the Threads view  of the Concurrency Visualizer represent times when the GPU was processing requests on behalf of other processes on the system. These requests are sent the GPU as direct memory access (DMA) packets.  The length of a segment represents the duration of time that the packet was processed by the GPU.

 When you select this kind of segment, the report on the **Current** tab displays information about the packet that was processed.  The information includes the amount of time that the packet waited in the hardware queue that's associated with the DirectX engine, the process that submitted the packet, and the time that was required to process the packet.