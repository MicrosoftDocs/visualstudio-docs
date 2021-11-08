---
title: "Understanding Sampling Data Values | Microsoft Docs"
description: Learn how the sampling profiling method of the Visual Studio Profiling Tools interrupts the computer processor at set intervals and collects the function call stack.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "sampling profiling method"
  - "Profiling Tools, sampling"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Understand sampling data values

The *sampling* profiling method of the Visual Studio Profiling Tools interrupts the computer processor at set intervals and collects the function call stack. A *call stack* is a dynamic structure that stores information about the functions that are executing on the processor.

The profiler analysis determines whether the processor is executing code in the target process. If the processor is not executing code in the target process, the sample is discarded.

If the processor is executing the target code, the profiler increments the sample counts for each function on the call stack. At the time that the sample is taken, only one function on the call stack is currently executing code. The other functions on the stack are parents in the hierarchy of function calls that are waiting for their children to return.

For the sample event, the profiler increments the *exclusive* sample count of the function that is currently executing its instructions. Because an exclusive sample is also part of the total (*inclusive*) samples of the function, the inclusive sample count of the currently active function is also incremented.

 The profiler increments the inclusive sample count of all other functions on the call stack.

## Inclusive samples

The total number of samples that are collected during the execution of the target function.

This includes samples that are collected during the direct execution of the function code and samples that are collected during the execution of child functions that are called by the target function.

## Exclusive samples

The number of samples that are collected during the direct execution of the instructions of the target function.

Exclusive samples do not include samples that are collected during the execution of functions that are called by the target function.

## Inclusive percent

The percentage of the total number of inclusive samples in the profiling run that are inclusive samples of the function or data range.

## Exclusive percent

The percentage of the total number of exclusive samples in the profiling run that are exclusive samples of the function or data range.

## See also

[How to: Choose collection methods](../profiling/how-to-choose-collection-methods.md)
[Analyze performance tools data](../profiling/analyzing-performance-tools-data.md)
