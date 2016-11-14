---
title: "GPU Activity (Paging) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.cv.threads.timeline.gpuactivity"
  - "vs.cv.threads.timeline.gpupaging"
ms.assetid: 95284ac5-3492-4f7b-a79f-7d2840a07679
caps.latest.revision: 6
author: "mikejo5000"
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
# GPU Activity (Paging)
The **GPU Activity (Paging)** segments on the Threads tab represent times when the GPU was processing paging requests.  The length of a segment represents the duration of time that the GPU was processing a direct memory access (DMA) paging packet. Typically, paging packets are associated with the transfer of memory between the CPU and GPU.  
  
 When you select a GPU paging segment, the report on the **Current** tab displays information about the DMA packet that was processed. This includes the amount of time it waited in the hardware queue that's associated with the DirectX engine, the process that submitted the DMA packet, and the time that's required to process the packet.  
  
## See Also  
 [Utilization View](../profiling/utilization-view.md)