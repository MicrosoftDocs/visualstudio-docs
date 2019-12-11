---
title: "DA0026: Excessive kernel CPU time processing | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.rules.DA0026"
  - "vs.performance.DA0026"
  - "vs.performance.26"
ms.assetid: 4cfc8a29-b29b-4a72-b386-03d8856fdf8a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0026: Excessive kernel CPU time processing

|||
|-|-|
|Rule Id|TODO|
|Category|Profiling Tools Usage|
|Profiling method|Sampling|
|Message|Relatively high amount of kernel mode CPU time was measured. Consider investigating the source with SysCall sampling enabled.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Cause
 The proportion CPU time that was executed in kernel mode exceeded the amount of time spent in user mode. Consider profiling again and sampling the number of system calls (syscalls) to determine the cause of the high kernel mode execution times.

## Rule description
 The relatively high proportion of time the application spent in kernel mode execution may warrant further investigation. A user-mode application transitions into kernel mode to perform I/O operations, to wait for thread or process synchronization primitives, or do system calls. You can investigate the kinds of system calls the application  makes and which functions that are responsible for them when you select the option to gather sample call stacks based on System calls.

## How to fix violations
 To investigate the kinds of system calls that your application makes, run the profile again and select the option to gather samples based on system calls. See [How to: Choose Sampling Events](../profiling/how-to-choose-sampling-events.md) if you are running the profiling tools inside the IDE for more information. If you are running the profiling tools from the command line, see the **Sample interval options** section of the [VSPerfCmd](../profiling/vsperfcmd.md) article in the Profiling Tools command line tools reference.
