---
title: DA0003 - Many kernel samples | Microsoft Docs
description: "A significant proportion of the call stack samples that were collected for the application were executing in kernel mode."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.rules.DA0003
  - vs.performance.DA0003
  - vs.performance.3
  - vs.performance.rules.DAManyKernelSamples
ms.assetid: c1f46f77-eb95-42e5-b340-d86bc9de41b4
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0003: Many kernel samples

|Item|Value|
|-|-|
|Rule Id|DA0003|
|Category|Profiling Tools Usage|
|Profiling methods|Sampling|
|Message|You have a high proportion of samples in Kernel Mode. This might indicate a high volume of I/O activity or a high rate of context switching. Consider profiling your application again using Instrumentation Mode.|
|Rule type|Information|

## Cause
 A significant proportion of the call stack samples that were collected for the application were executing in kernel mode. Consider profiling your application using a different profiling method.

## Rule description
 In Windows, code can be executed in either kernel mode or user mode. (Kernel mode is also called privileged mode.) Only low-level system code, such as a device driver, runs in kernel mode. A user-mode application can transition into kernel mode to perform I/O operations, to wait for thread or process synchronization primitives, or do system calls.

 Sampling is most effective when you are profiling applications that spend most of their time doing work in user mode. The number of samples that were gathered when the application was executing in kernel mode can indicate frequent I/O operations or can indicate that context switches are occurring. Neither of these operations can be investigated using the sampling method. If too many kernel mode samples are taken, the sampling data may not contain enough user mode samples to be statistically significant.

## How to fix violations
 Consider profiling your application again using one of the following options:

- Profile by using the instrumentation method.

- Increase the sampling rate to try to collect more samples in user mode.
