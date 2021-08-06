---
title: DA0018 - 32-bit Application running at process managed memory limits | Microsoft Docs
description: "System data collected during the profiling run indicates the .NET Framework memory heaps approached the maximum size that the managed heaps can reach in a 32-bit process."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.18
  - vs.performance.DA0018
  - vs.performance.rules.DA0018
ms.assetid: 98eb2d96-f92f-42f9-915c-e5ac2330ffbf
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# DA0018: 32-bit Application running at process-managed memory limits

|Item|Value|
|-|-|
|Rule Id|DA0018|
|Category|Profiling Tools Usage|
|Profiling method|Sampling|
|Message|Managed memory allocations approaching the default limit for a 32-bit process. Your application could be memory-bound.|
|Rule type|Warning|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Cause
 System data collected during the profiling run indicates the .NET Framework memory heaps approached the maximum size that the managed heaps can reach in a 32-bit process. This maximum size is a default value. It is based on the total amount of the process address space that can be allocated for private bytes. The value reported is the maximum observed value of the heaps while the profiled process was active. Consider profiling again using the .NET memory profiling method and optimizing the use of managed resources by the application.

 When the size of the managed Heaps approach the default limit, the automatic garbage collection process might have to be invoked more frequently. This increases the overhead of memory management.

 The Rule only fires for 32-bit applications running on 32-bit machines.

## Rule description
 The Microsoft .NET common language run-time (CLR) provides an automatic memory management mechanism that uses a garbage collector to reclaim memory from objects that the application no longer uses. The garbage collector is generation-oriented, based on the assumption that many allocations are short-lived. Local variables, for example, should be short-lived. Newly created objects start in generation 0 (gen 0), and then they progress to generation 1 when they survive a garbage collection run, and finally transition to generation 2 if the application still uses them.

 Managed objects that are larger than 85 KB are allocated on the Large Object Heap, where they are subject to less frequent garbage collection and compaction than smaller objects. large objects are managed separately because it is assumed that they are more persistent and because mixing persistent and large objects with frequently allocated smaller objects can produce worst-cast fragmentation of the heap.

 As the total size of the managed heaps approach the default limit, the overhead of memory management usually increases to the point where it can start to impact the responsiveness and scalability of the application.

## How to investigate a warning
 Double-click the message in the Error List window to navigate to the [Marks](../profiling/marks-view.md) view. Find the **.NET CLR Memory\\# Bytes in all Heaps** and **# Total committed bytes** columns. Determine if there are specific phases of program execution where managed memory allocation is heavier than other phases. Compare the values of the **# Bytes in all Heaps** column to the rate of garbage collection reported in the **.NET CLR Memory\\# of Gen 0 Collections**, **.NET CLR Memory\\# of Gen 1 Collections**, and **.NET CLR Memory\\# of Gen 2 Collections** columns to determine if the pattern of managed memory allocations is affecting the rate of garbage collection.

 In a .NET Framework application, the common language runtime limits the total size of the managed heaps to slightly less than one-half of the maximum size of the private area portion of a process address space. For a 32-bit processes running on a 32-bit machine, 2 GB represents the upper limit of the private portion of the process address space. As the total size of the managed Heaps begins to approach its default limit, the overhead of managing memory might increase and application performance can decrease.

 If excessive managed memory overhead is a problem, consider either of these options:

- optimizing the application's usage of managed memory resources

   -or-

- taking steps to relieve the architectural constraints on the maximum size of virtual memory for a 32-bit process

  To optimize the application's usage of managed memory resources, gather managed memory allocation data in a .NET Memory Allocation profiling run. Review the [.NET Memory Data Views](../profiling/dotnet-memory-data-views.md) reports to understand the application's pattern of memory allocation.

  Use the [Object Lifetime View](../profiling/object-lifetime-view.md) to determine which of the program's data objects are surviving into generation and then being reclaimed from there.

  Use the [Allocations View](../profiling/dotnet-memory-allocations-view.md) to determine the execution path that resulted in these allocations.

  For more information about how to improve garbage collection performance, see .NET Framework technical article, [Garbage Collector Basics and Performance Hints](/previous-versions/dotnet/articles/ms973837(v=msdn.10)) on the MSDN Web site.

  To gain architectural relief from the virtual memory constraints on the size of the private portion of a process address space, try running this 32-bit process on a 64-bit machine.  A 32-bit process on a 64-bit machine can acquire up to 4 GB of private virtual memory.

  A 64-bit process running on a 64-bit machine can acquire up to 8 TB of virtual memory. Consider recompiling the application to execute as a native 64-bit application. This rule is for information only, and might not require corrective action.
