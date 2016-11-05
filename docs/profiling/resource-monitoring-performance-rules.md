---
title: "Resource Monitoring Performance Rules | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f0f77faf-0a05-4718-a2c5-47934be40868
caps.latest.revision: 7
author: "mikejo5000"
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
# Resource Monitoring Performance Rules
Performance messages in the Resource Monitoring category provide additional data about the performance of your application. You can use this data to analyze performance issues. These rules are informational and reported for every profiling run.  
  
|||  
|-|-|  
|[DA0501: Average CPU consumption by the Process being profiled.](../profiling/da0501-average-cpu-consumption-by-the-process-being-profiled.md)|This message reports the percentage of time that a processor was busy executing instructions from the application. The reported value is the average over all the measurement intervals in which the process being profiled was active.|  
|[DA0502: Maximum CPU consumption by the Process being profiled](../profiling/da0502-maximum-cpu-consumption-by-the-process-being-profiled.md)|This message reports the maximum percentage of time that a processor was busy executing instructions from the application. The reported value is the maximum value reported among all the measurement intervals in which the process being profiled was active.|  
|[DA0503: Average Working Set in Bytes for the Process being profiled](../profiling/da0503-average-working-set-in-bytes-for-the-process-being-profiled.md)|This message reports the average amount of physical memory, in bytes, that the process was using while profiling was active. This measure of physical memory is known as the working set.|  
|[DA0504: Maximum Working Set in Bytes for the Process being profiled](../profiling/da0504-maximum-working-set-in-bytes-for-the-process-being-profiled.md)|This message reports the maximum amount of physical memory, in bytes, that the process was using while profiling was active.|  
|[DA0505: Average Private Bytes allocated for the Process being profiled](../profiling/da0505-average-private-bytes-allocated-for-the-process-being-profiled.md)|This message reports the average amount of virtual memory that the process allocated in bytes while profiling was active. This measure of virtual memory is known as *private bytes*. Private bytes represents virtual memory locations that were allocated by the process that can only be accessed by threads running inside the process.|  
|[DA0506: Maximum Private Bytes allocated for the Process being profiled](../profiling/da0506-maximum-private-bytes-allocated-for-the-process-being-profiled.md)|This message reports the maximum amount of virtual memory that the process allocated in private bytes while profiling was active.|