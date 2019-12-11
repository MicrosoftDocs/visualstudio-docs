---
title: "DA0024: Excessive GC CPU Time | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.DA0024"
  - "vs.performance.24"
  - "vs.performance.rules.DA0024"
ms.assetid: 228872da-77d0-4da5-b455-ac57fb1867c9
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0024: Excessive GC CPU time

|||
|-|-|
|Rule Id|DA0024|
|Category|.NET Framework Usage|
|Profiling method|All|
|Message|% Time in GC is very high. There is an excessive amount of garbage collection overhead.|
|Rule type|Warning|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Cause
 System performance data that was collected during profiling indicates that the amount of time spent in garbage collection is excessively high compared with the total application processing time.

## Rule description
 The Microsoft .NET common language run-time (CLR) provides an automatic memory management mechanism that uses a garbage collector to reclaim memory from objects that the application no longer uses. The garbage collector is generation-oriented, based on the assumption that many allocations are short-lived. Local variables, for example, should be short-lived. Newly created objects start in generation 0 (gen 0), and then they progress to generation 1 when they survive a garbage collection run, and finally transition to generation 2 if the application still uses them.

 Objects in generation 0 are collected frequently and usually very efficiently. Objects in generation 1 are collected less frequently and less efficiently. Finally, long-lived objects in generation 2 should be collected even less frequently. Generation 2 collection, which is a full garbage collection run, is also the most expensive operation.

 This rule fires when the amount of time spent in garbage collection is excessively high compared with the total application processing time.

> [!NOTE]
> When the proportion of time spent in garbage collection is significant but not excessive compared with the total application processing time, the [DA0023: High GC CPU time](../profiling/da0023-high-gc-cpu-time.md) warning fires instead of this rule.

## How to investigate a warning
 Double-click the message in the Errors List window to navigate to the [Marks View](../profiling/marks-view.md) of the profiling data. Find the **.NET CLR Memory\\% Time in GC** column. Determine if there are specific phases of program execution where the overhead of managed memory garbage collection is heavier than other phases. Compare the values of the % Time in GC value to the rate of garbage collection reported in the **# of Gen 0 Collections**, **# of Gen 1 Collections**, **# of Gen 2 Collections** values.

 The % Time in GC value tries to report the amount of time that an application spends performing garbage collection proportional to the total amount of processing. Be aware that there are circumstances when the % Time in GC value can report a high value, but it is not because of excessive garbage collection. For more information about the way the % Time in GC value is calculated, see the [Difference Between Perf Data Reported by Different Tools - 4](https://devblogs.microsoft.com/maoni/archive/difference-between-perf-data-reported-by-different-tools-4.aspx) entry of **Maoni's Weblog** on MSDN. If page faults are occurring or the application is pre-empted by other higher priority work on the machine during garbage collection, the % Time in GC counter will reflect those additional delays.
