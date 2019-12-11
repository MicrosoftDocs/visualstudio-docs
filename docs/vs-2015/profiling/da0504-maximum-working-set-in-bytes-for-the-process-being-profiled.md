---
title: "DA0504: Maximum Working Set in Bytes for the Process being profiled | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.DA0504"
  - "vs.performance.504"
  - "vs.performance.rules.DA0504"
ms.assetid: 36e71603-ece7-4000-85fc-9da4eed61bf2
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0504: Maximum Working Set in Bytes for the Process being profiled
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Rule Id|DA0504|  
|Category|Resource Management|  
|Profiling method|All|  
|Message|This information was gathered for information only. The Process Working Set counter measures physical memory usage by the process that you are profiling. The value reported is the maximum observed over all measurement intervals.|  
|Rule type|Information|  
  
 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.  
  
## Rule Description  
 This message reports the maximum amount of physical memory, in bytes, that the process is currently using. The process working set represents pages from the process address space that currently reside in physical memory. This rule reports the maximum value for the process working set while profiling was active.  
  
 The value reported includes resident pages from shared memory segments that the process has referenced. Shared DLLs that the process references are included in the shared memory segments that are counted. The value of the process Working Set can be higher than the amount of virtual memory that the process has allocated because of shared memory segments.  
  
 The size of the process working set reflects how much virtual memory the process is actively using. It is also affected by the amount of physical memory (or RAM) available to run the application and contention for that physical memory from other running processes. For more information about process working sets, see [Working Set](https://go.microsoft.com/fwlink/?LinkId=177830) in the Windows Memory Management documentation of MSDN.  
  
## How to Use Rule Data  
 The rule gathers this measurement data from the Windows performance monitoring facility and reports it for information only. Use it to compare the performance of different versions or builds of the program or to understand the performance of the application under different test scenarios.  
  
 Double-click the message in the Error List window to navigate to the [Marks View](../profiling/marks-view.md) of the profiling data. Find the **Process\Working Set** and **Memory\Pages/sec** counter columns. Then find the maximum value of the **Process\Working Set** and compare it to the **Memory\Pages/sec** value. Frequently, the working set maximum is associated with an interval in which there is decreased paging IO activity, especially if the machine is memory-constrained.
