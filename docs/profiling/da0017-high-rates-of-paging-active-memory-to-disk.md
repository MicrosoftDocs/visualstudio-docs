---
title: "DA0017: High rates of paging active memory to disk | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.17"
  - "vs.performance.rules.DA0017"
  - "vs.performance.DA0017"
ms.assetid: 01011eec-5930-43b3-980d-2cb01e2ca7f6
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0017: High rates of paging active memory to disk

|||
|-|-|
|Rule Id|DA0017|
|Category|Memory and Paging|
|Profiling method|All|
|Message|A high rate of paging active memory to disk is occurring. Your application may be memory-bound.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Cause
 System performance data that was collected in the profiling run indicates that an high rate of paging active memory to and from the disk occurred throughout the profiling run. Paging rates at this level normally will impact application performance and responsiveness. Consider reducing memory allocations by revising algorithms. You might also have to consider the memory requirements of your application.

## Rule description

> [!NOTE]
> This informational rule fires when levels of paging of active memory reach a significant amount. When an extremely high level of paging occurs, the warning rule [DA0014: Extremely high rates of paging active memory to disk](../profiling/da0014-extremely-high-rates-of-paging-active-memory-to-disk.md) fires instead.

 Excessive paging to disk can be caused by a shortage of physical memory. If paging operations dominate use of the physical disk where the paging file resides, they can slow down other application-oriented disk operations to the same disk.

 Pages are often read from the disk or written to the disk in bulk paging operations. The number of Pages Output/sec is often much larger than the number of Page Writes/sec, for example. Because Pages Output/sec also includes changed data pages from the system file cache. However, it is not always easy to determine which process is directly responsible for the paging or why.

## How to fix violations
 Double-click the message in the Error List window to navigate to the [Marks](../profiling/marks-view.md) view. Find the **Memory\Pages/sec** column. Determine if there are specific phases of program execution where paging IO activity is heavier than others.

 If you are gathering profile data for an ASP.NET application in a load testing scenario, try running the load test again on a machine configured with additional physical memory (or RAM).

 Consider reducing memory allocations by revising algorithms and avoiding memory-intensive APIs such as String.Concat and String.Substring.
