---
title: "DA0021: High rate of Gen 1 garbage collections | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.21"
  - "vs.performance.DA0021"
  - "vs.performance.rules.DA0021"
ms.assetid: ebf5d9b3-a1ac-4688-8f0f-39a85f4dd15f
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0021: High rate of Gen 1 garbage collections

|||
|-|-|
|Rule Id|DA0021|
|Category|.NET Framework Usage|
|Profiling methods|All|
|Message|There is a fairly high rate of Gen 1 garbage collections occurring. If, by design, most of your program's data structures are allocated and persisted for a long time, this is not ordinarily a problem. However, if this behavior is unintended, your application may be pinning objects. If you are not sure, you can gather .NET memory allocation data and object lifetime information to understand the pattern of memory allocation your application uses.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Cause
 System performance data that was collected during profiling indicate that a significant proportion of the memory for.NET Framework objects was reclaimed in generation 1 of garbage collection compared to generation 0 data collection.

## Rule description
 The Microsoft .NET common language run-time (CLR) provides an automatic memory management mechanism that uses a garbage collector to reclaim memory from objects that the application no longer uses. The garbage collector is generation-oriented, based on the assumption that many allocations are short-lived. Local variables, for example, should be short-lived. Newly created objects start in generation 0 (gen 0), and then they progress to generation 1 when they survive a garbage collection run, and finally transition to generation 2 if the application still uses them.

 Objects in generation 0 are collected frequently and usually very efficiently. Objects in generation 1 are collected less frequently and less efficiently. Finally, long-lived objects in generation 2 should be collected even less frequently. Generation 2 collection, which is a full garbage collection run, is also the most expensive operation.

 This rule fires when proportionally too many generation 1 garbage collections have occurred. If too many fairly short-lived objects survive generation 0 collection but are then able to be collected in a generation 1 collection, the cost of memory management can become excessive. For more information, see the [Mid-life crisis](https://blogs.msdn.microsoft.com/ricom/2003/12/04/mid-life-crisis/) post on the Rico Mariani's Performance Tidbits on the MSDN Web site.

## How to investigate a warning
 Double-click the message in the Errors List window to navigate to the [Marks View](../profiling/marks-view.md) of the profiling data. Find the **.NET CLR Memory\\# of Gen 0 Collections** and **.NET CLR Memory\\# of Gen 1 Collections** columns. Determine if there are specific phases of program execution where garbage collection is occurring more frequently. Compare these values to the **% Time in GC** column to see if the pattern of managed memory allocations is causing excessive memory management overhead.

 To understand the application's pattern of managed memory usage, profile it again running a.NET Memory allocation profile and request Object Lifetime measurements.

 For information about how to improve garbage collection performance, see [Garbage Collector Basics and Performance Hints](/previous-versions/dotnet/articles/ms973837(v=msdn.10)) on the Microsoft Web site. For information about the overhead of automatic garbage collection, see [Large Object Heap Uncovered](https://msdn.microsoft.com/magazine/cc534993.aspx).
