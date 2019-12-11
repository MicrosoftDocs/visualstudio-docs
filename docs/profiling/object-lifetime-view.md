---
title: "Object Lifetime View | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.objectlifetime"
helpviewer_keywords:
  - "lifetime, objects"
  - "Objects Lifetime view"
  - "profiling tools reports, Lifetime view"
  - "performance reports, objects lifetime view"
  - "profiling tools, Lifetime view"
ms.assetid: d0501fdd-4b3a-4e74-b6ac-51d950a2e15b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Object Lifetime View
The Object Lifetime view is available when **Also collect .NET object lifetime data** is checked on the **Performance Session** property pages.

 The garbage collector of the .NET Framework manages the allocation and release of memory for your application. To optimize the performance of the garbage collector, the managed heap is divided into three generations: 0, 1, and 2. The  garbage collector of the runtime stores new objects in generation 0. Objects that survive collections are promoted and stored in generations 1 and 2.

 The garbage collector reclaims memory by deallocating a whole generation of objects. For objects that were created by the profiled application, the Object Lifetime view displays the number and size of the objects and the generation in which they are reclaimed.

## General

|Column|Description|
|------------|-----------------|
|**Class Name**|The class name of the allocated type.|
|**Process ID**|The process ID of the profiling run.|
|**Process Name**|The name of the process.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|

## Instance data
 Instance data indicates the number of objects of the type that were created in the profiling run, and the generation in which the objects were deallocated by the garbage collector.

|Column|Description|
|------------|-----------------|
|**Instances**|The number of allocations of objects of this type.|
|**Total Instances %**|The percentage of the total number of allocations that were made in the profiling run.|
|**Gen 0 Instances Collected**|The number of instances of the type that were deallocated in generation 0 of the garbage collection algorithm.|
|**Gen 1 Instances Collected**|The number of instances of the type that were deallocated in generation 1 of the garbage collection algorithm.|
|**Gen 2 Instances Collected**|The number of instances of the type that were deallocated in generation 2 of the garbage collection algorithm.|
|**Instances Alive At End**|The number of instances of the type that were not deallocated until the end of the profiling run.|

## Size (byte) data
 Size (byte) data indicates the size of objects of the type that were created in the profiling run, and the amount of memory that was reclaimed in each generation in which the objects were deallocated.

|Column|Description|
|------------|-----------------|
|**Total Bytes Allocated**|The total number of bytes for all instances of the type.|
|**Total Bytes %**|The percentage of the total number of allocated bytes in the profiling run that were allocated for the instances of this type.|
|**Gen 0 Bytes Collected**|The size of the instances of the type that were deallocated in generation 0 of the garbage collection algorithm.|
|**Gen 1 Bytes Collected**|The size of the instances of the type that were deallocated in generation 1 of the garbage collection algorithm.|
|**Gen 2 Bytes Collected**|The size of the instances of the type that were deallocated in generation 2 of the garbage collection algorithm.|

## Large object heap data
 The .NET memory allocator manages very large objects in a location that is separate from the standard managed heap. Large object heap data indicates the number and size of objects of the type that were managed in this location.

|Column|Description|
|------------|-----------------|
|**Large Object Heap Instances Collected**|The number of instances of this type that were located in the large object heap and that were collected in the profiling run.|
|**Large Object Heap Bytes Collected**|The size, in bytes, of the instances of this type that were located in the large object heap and that were collected in the profiling run.|

## See also
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
