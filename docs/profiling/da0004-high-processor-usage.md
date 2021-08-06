---
title: DA0004 - High processor usage | Microsoft Docs
description: "Processor (CPU) utilization was high in profiling data that was collected using the instrumentation method."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.rules.DAHighProcessorUsage
  - vs.performance.rules.DA0004
  - vs.performance.DA0004
  - vs.performance.4
ms.assetid: 2c4fb569-929e-4f1d-8c50-b590ee371351
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0004: High processor usage

|Item|Value|
|-|-|
|Rule Id|DA0004|
|Category|Profiling Tools Usage|
|Profiling methods|Instrumentation<br /><br /> Sampling|
|Message|Your processor usage is consistently above 75%. Consider using Sampling mode for CPU-bound applications.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Cause
 Processor (CPU) utilization was high in profiling data that was collected using the instrumentation method. Consider using the sampling profiling method when profiling a CPU bound application.

## Rule description
 During this profiling run, the processor (or processors) was consistently busy. High CPU utilization can indicate a CPU-bound application. Instrumented profiles are not the most effective way to investigate CPU-usage scenarios. Sampling is more effective when you are profiling applications that spend much of their time executing instructions on the processor.

## How to fix violations
 Consider profiling your application again using the sampling method instead of instrumentation method unless you require function timings or you are more interested in understanding input/output than processor bottlenecks.
