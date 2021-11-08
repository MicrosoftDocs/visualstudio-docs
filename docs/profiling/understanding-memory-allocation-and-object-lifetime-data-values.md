---
title: "Memory allocation & object lifetime data values"
description: Learn how the .NET memory allocation profiling method collects information about the size and number of objects that were created in an allocation. 
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - ".NET memory profiling method"
  - "Profiling Tools, .NET memory method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Understand memory allocation and object lifetime data values

The *.NET memory allocation* profiling method of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools collects information about the size and number of objects that were created in an allocation or destroyed in a garbage collection and additional information about the function *call stack* when the event occurred. A *call stack* is a dynamic structure that stores information about the functions that are executing on the processor.

The memory profiler interrupts the computer processor at each allocation of a .NET Framework object in a profiled application. When object lifetime data is also collected, the profiler interrupts the processor after each .NET Framework garbage collection. The data is aggregated for each profiled function and for each type of object.

## Allocation data

When a .memory event occurs, the total counts and sizes of the allocated or destroyed memory objects are incremented.

When a .memory allocation event occurs, the profiler increments the sample counts for each function on the call stack. When the data is collected, only one function on the call stack is currently executing the code in its function body. The other functions on the stack are parents in the hierarchy of function calls that are waiting for the functions that they called  to return.

- For the allocation event, the profiler increments the *exclusive* sample count of the function that is currently executing its instructions. Because an exclusive sample is also part of the total (*inclusive*) samples of the function, the inclusive sample count of the currently active function is also incremented.

- The profiler increments the inclusive sample count of all other functions on the call stack.

## Lifetime data

The garbage collector of the .NET Framework manages the allocation and release of memory for your application. To optimize the performance of the garbage collector, the managed heap is divided into three generations: 0, 1, and 2. The run-time's garbage collector stores new objects in generation 0. Objects that survive collections are promoted and stored in generations 1 and 2.

The garbage collector reclaims memory by deallocating a whole generation of objects. For objects that the profiled application created, the Object Lifetime view displays the number and size of the objects and the generation when they are reclaimed.
