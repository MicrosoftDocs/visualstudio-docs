---
title: "DA0022: High rate of Gen 2 garbage collections | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.DA0022"
  - "vs.performance.rules.DA0022"
  - "vs.performance.22"
ms.assetid: f871a547-0e6f-4b11-b2d7-174d30fc2ed8
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0022: High rate of Gen 2 garbage collections
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Rule Id|DA0022|  
|Category|.NET Framework Usage|  
|Profiling method|All|  
|Message|There is a fairly high rate of Gen 2 garbage collections occurring. If, by design, most of your program's data structures are allocated and persisted for a long time, this is not ordinarily a problem. However, if this behavior is unintended, your application may be pinning objects. If you are not sure, you can gather .NET memory allocation data and object lifetime information to understand the pattern of memory allocation your application uses.|  
|Rule type|Warning|  
  
 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.  
  
## Cause  
 System performance data that was collected during profiling indicate that a significant proportion of the memory for.NET Framework objects was reclaimed in generation 2 of garbage collection compared to generation 0 and generation 1 garbage collections.  
  
## Rule Description  
 The Microsoft .NET common language run-time (CLR) provides an automatic memory management mechanism that uses a garbage collector to reclaim memory from objects that the application no longer uses. The garbage collector is generation-oriented, based on the assumption that many allocations are short-lived. Local variables, for example, should be short-lived. Newly created objects start in generation 0 (gen 0), and then they progress to generation 1 when they survive a garbage collection run, and finally transition to generation 2 if the application still uses them.  
  
 Objects in generation 0 are collected frequently and usually very efficiently. Objects in generation 1 are collected less frequently and less efficiently. Finally, long-lived objects in generation 2 should be collected even less frequently. Generation 2 collection, which is a full garbage collection run, is also the most expensive operation.  
  
 This rule fires when proportionally too many generation 2 garbage collections are occurring. Well-behaved .NET Framework applications will have more than 5 times as many generation 1 garbage collections as generation 2 collections. (A 10x factor is probably ideal.)  
  
## How to Investigate a Warning  
 Double-click the message in the Errors List window to navigate to the [Marks View](../profiling/marks-view.md) of the profiling data. Find the **.NET CLR Memory\\# of Gen 0 Collections** and **.NET CLR Memory\\# of Gen 1 Collections** columns. Determine if there are specific phases of program execution where garbage collection is occurring more frequently. Compare these values to the **% Time in GC** column to see if the pattern of managed memory allocations is causing excessive memory management overhead.  
  
 A high proportion of Generation 2 garbage collections is not always a problem. It might be by design. An application that allocates large data structures that must remain active for long periods during execution may trigger this rule. When such an application is under memory pressure, it may be forced to perform frequent garbage collections. If the less expensive Generation 0 and Generation 1 garbage collections can reclaim only a small amount managed memory, more frequent Generation 2 garbage collections will be scheduled.  
  
 There are additional .NET CLR Memory columns in the Marks View that can help you identify garbage collection issues. The **% Time in GC** column helps you understand how much memory management overhead is occurring. If your application typically uses a fairly small number of large but persistent objects, then frequent Generation 2 collections should not consume excessive amounts of CPU time. If the application is under memory pressure because more Physical Memory (RAM) is required, related rules that evaluate the **Memory\Pages/sec** column values may also fire.  
  
 To understand the application’s pattern of managed memory usage, profile it again running a.NET Memory allocation profile and select the Object Lifetime profiling option.  
  
 For information about how to improve garbage collection performance, see [Garbage Collector Basics and Performance Hints](https://go.microsoft.com/fwlink/?LinkId=148226) on the Microsoft Web site. For information about the overhead of automatic garbage collection, see [Large Object Heap Uncovered](https://go.microsoft.com/fwlink/?LinkId=177836).
