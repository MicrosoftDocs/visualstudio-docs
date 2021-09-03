---
title: "Understanding Instrumentation Data Values | Microsoft Docs"
description: Learn how the instrumentation profiling method records detailed timing information for the function calls, lines, and instructions in the profiled application.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiling Tools,instrumentation"
  - "instrumentation profiling method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Understand instrumentation data values

The *instrumentation* profiling method of Visual Studio records detailed timing information for the function calls, lines, and instructions in the profiled application

The instrumentation method injects code at the start and end of target functions in the profiled binary, and before and after each call by those functions to other functions. The injected code records the following information:

- The interval between this collection event and the previous one.

- Whether the operating system has performed an operation during the interval. For example, the operating system might read or write to disk, or switch between the target thread and another thread in another process.

For each interval, the profiler analysis reconstructs the call stack that was present at the end of the interval. A call stack is the list of functions that are active on a processor at a point in time. Only one function (the current function) is executing code; the other functions are the chain of function calls that resulted in the call to the current function (the call stack).

For each function on the call stack when the interval was recorded, the profiler analysis adds the interval to one or more of four data values for the function. The analysis adds the interval to a data value for a function based on two criteria:

- Whether the interval occurred in the code of the function or in a *child function* (a function that was called by the function).

- Whether an operating system event occurred in the interval.

The data values for an interval of a function or data range are named *Elapsed Inclusive*, *Elapsed Exclusive*, *Application Inclusive*, and *Application Exclusive*:

- All intervals of a function are added to the Elapsed Inclusive data value.

- If the interval occurred in the code of the function and not in a child function, the interval is added to the Elapsed Exclusive data value of the function.

- If an operating system event did not occur in the interval, the interval is added to the Application Inclusive data value.

- If an operating system event did not occur in the interval, and the interval occurred in the direct execution of the function code (that is, it did not occur in a child function), the interval is added to the Application Exclusive data value.

Profiling Tools reports aggregate the total values of the functions in the profiling session itself, and the processes, threads, and binaries of the session.

## Elapsed Inclusive values

The total time that was spent executing a function and its child functions.

Elapsed Inclusive values include the intervals that were spent directly executing the function code and the intervals that were spent executing the child functions of the target function. Intervals of the function or its child functions that include waiting for the operating system are also included in Elapsed Inclusive values.

## Elapsed Exclusive values

The time that was spent executing a function, excluding time that was spent in child functions.

Elapsed Exclusive values include the intervals that were spent directly executing the function code, regardless of whether an operating system event occurred in the interval. All intervals spent in child functions that were called by the target function are not included in Elapsed Exclusive values.

## Application Inclusive values

The time that was spent executing a function and its child functions, excluding time that was spent in operating system events.

Application Inclusive values do not include intervals that contain operating system events. Application Inclusive values include all other intervals that were spent executing a function, regardless of whether the interval was spent directly executing the function code or was spent in child functions of the target function.

## Application Exclusive values

The time that was spent executing a function, excluding the time that was spent in child functions and the time that was spent in operating system events.

Application Exclusive values do not include intervals that contain operating system events or intervals that were spent executing functions that were called by the function. Application Exclusive values include only those intervals that were spent directly executing the function code and that did not contain an operating system event.

## Elapsed Inclusive percent

The percentage of the total Elapsed Inclusive values of the profiling session that were Elapsed Inclusive values of the function, module, thread, or process.

100 * Function Elapsed Inclusive / Session Elapsed Inclusive

## Elapsed Exclusive percent

The percentage of the total Elapsed Inclusive values of the profiling session that were Elapsed Exclusive values of the function, module, thread, or process.

100 * Function Elapsed Exclusive / Session Elapsed Inclusive

## Application Inclusive percent

The percentage of the total Application Inclusive values of the profiling session that were Application Inclusive values of the function, module, thread, or process.

100 * Function Application Inclusive / Session Application Inclusive

## Application Exclusive percent

The percentage of the total Application Inclusive values of the profiling session that were Application Exclusive intervals of the function, module, thread, or process.

100 * Function Application Exclusive / Session Application Inclusive

## See also

[Analyze performance tools data](../profiling/analyzing-performance-tools-data.md)
[How to: Choose collection methods](../profiling/how-to-choose-collection-methods.md)
