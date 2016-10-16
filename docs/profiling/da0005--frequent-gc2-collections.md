---
title: "DA0005: Frequent GC2 collections"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.DA0005"
  - "vs.performance.rules.DAManyGC2Collections"
  - "vs.performance.5"
  - "vs.performance.rules.DA0005"
ms.assetid: 8d3f267c-8a74-4cf4-91a5-0b06a76dc2bd
caps.latest.revision: 11
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# DA0005: Frequent GC2 collections
|||  
|-|-|  
|RuleId|DA0005|  
|Category|.NET Framework Usage|  
|Profiling method|.NET Memory|  
|Message|Many of your objects are being collected in generation 2 garbage collection.|  
|Message type|Warning|  
  
## Cause  
 A high number of .NET memory objects are being reclaimed in generation 2 garbage collection.  
  
## Rule Description  
 The Microsoft .NET common language runtime (CLR) provides an automatic memory management mechanism that uses a garbage collector to reclaim memory from objects that the application no longer uses. The garbage collector is generation-oriented, based on the assumption that many allocations are short-lived. Local variables, for example, should be short-lived. Newly created objects start in generation 0 (gen 0), and then they progress to generation 1 when they survive a garbage collection run, and finally transition to generation 2 if the application still uses them.  
  
 Objects in generation 0 are collected frequently and usually very efficiently. Objects in generation 1 are collected less frequently and less efficiently. Finally, long-lived objects in generation 2 should be collected even less frequently. Generation 2 collection, which is a full garbage collection run, is also the most expensive operation.  
  
 This rule fires when proportionally too many generation 2 garbage collections have occurred. If too many relatively short-lived objects survive generation 1 collection but are then able to be collected in a generation 2 full collection, the cost of memory management can easily become excessive. For more information, see the [Mid-life crisis](http://go.microsoft.com/fwlink/?LinkId=177835) post on the Rico Mariani's Performance Tidbits on the MSDN Web site.  
  
## How to Investigate a Warning  
 Review the [.NET Memory Data Views](../profiling/.net-memory-data-views.md) reports to understand the application’s pattern of memory allocation. Use the [Object Lifetime View](../profiling/object-lifetime-view.md) to determine which of the program’s data objects are surviving into generation 2 and then being reclaimed from there. Use the [Allocations View](../profiling/.net-memory-allocations-view.md) to determine the execution path that resulted in these allocations.  
  
 For information about how to improve garbage collection performance, see [Garbage Collector Basics and Performance Hints](http://go.microsoft.com/fwlink/?LinkId=148226) on the Microsoft Web site. For information about the overhead of automatic garbage collection, see [Large Object Heap Uncovered](http://go.microsoft.com/fwlink/?LinkId=177836).