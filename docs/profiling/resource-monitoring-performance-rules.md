---
title: "Resource Monitoring Performance Rules | Microsoft Docs"
description: Learn how performance messages in the Resource Monitoring category provide additional data about the performance of your application. 
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: f0f77faf-0a05-4718-a2c5-47934be40868
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Resource Monitoring Performance Rules
Performance messages in the Resource Monitoring category provide additional data about the performance of your application. You can use this data to analyze performance issues. These rules are informational and reported for every profiling run.

|Rule|Description|
|-|-|
|[DA0501: Average CPU consumption by the Process being profiled.](../profiling/da0501-average-cpu-consumption-by-the-process-being-profiled.md)|This message reports the percentage of time that a processor was busy executing instructions from the application. The reported value is the average over all the measurement intervals in which the process being profiled was active.|
|[DA0502: Maximum CPU consumption by the Process being profiled](../profiling/da0502-maximum-cpu-consumption-by-the-process-being-profiled.md)|This message reports the maximum percentage of time that a processor was busy executing instructions from the application. The reported value is the maximum value reported among all the measurement intervals in which the process being profiled was active.|
|[DA0503: Average Working Set in Bytes for the Process being profiled](../profiling/da0503-average-working-set-in-bytes-for-the-process-being-profiled.md)|This message reports the average amount of physical memory, in bytes, that the process was using while profiling was active. This measure of physical memory is known as the working set.|
|[DA0504: Maximum Working Set in Bytes for the Process being profiled](../profiling/da0504-maximum-working-set-in-bytes-for-the-process-being-profiled.md)|This message reports the maximum amount of physical memory, in bytes, that the process was using while profiling was active.|
|[DA0505: Average Private Bytes allocated for the Process being profiled](../profiling/da0505-average-private-bytes-allocated-for-the-process-being-profiled.md)|This message reports the average amount of virtual memory that the process allocated in bytes while profiling was active. This measure of virtual memory is known as *private bytes*. Private bytes represents virtual memory locations that were allocated by the process that can only be accessed by threads running inside the process.|
|[DA0506: Maximum Private Bytes allocated for the Process being profiled](../profiling/da0506-maximum-private-bytes-allocated-for-the-process-being-profiled.md)|This message reports the maximum amount of virtual memory that the process allocated in private bytes while profiling was active.|
