---
title: DA0503 - Average Working Set in Bytes for the Process being profiled | Microsoft Docs
description: "This message reports the average amount of physical memory that the process is currently using in bytes (the working set)."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.503
  - vs.performance.DA0503
  - vs.performance.rules.DA0503
ms.assetid: 9047a494-eaaf-4679-b422-c64e8bde77a4
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0503: Average working set in bytes for the process being profiled

|Item|Value|
|-|-|
|Rule Id|DA0503|
|Category|Resource Monitoring|
|Profiling method|All|
|Message|This information was gathered for information only. The Process Working Set counter measures physical memory usage by the process that you are profiling. The value reported is the average computed over all measurement intervals.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Rule description
 This message reports the average amount of physical memory that the process is currently using in bytes (the working set). The process working set represents pages from the process address space that currently reside in physical memory.

 The reported value includes resident pages from shared memory segments that the process has referenced. Shared DLLs that the process references are included in the shared memory segments that are counted. The value of the process working set can be higher than the amount of virtual memory that the process has allocated because of shared memory segments.

 The reported value is the average over all the measurement intervals in which the process being profiled was active.

 The size of the process working set reflects how much virtual memory the process is actively using. It is also affected by the amount of physical memory (or RAM) available to run the application and contention for that physical memory from other running processes. If physical memory is constrained, the value of the process working set is apt to vary significantly as the operating systems tries to balance memory usage across active processes by periodically trimming fairly inactive pages from process working sets.

 For more information about process working sets, see [Working Set](/windows/win32/memory/working-set) in the Windows Memory Management documentation of MSDN.

## How to use rule data
 Use the rule value to compare the performance of different versions or builds of the program or to understand the performance of the application under different profiling scenarios.

 Double-click the message in the Errors List window to navigate to the [Marks View](../profiling/marks-view.md) view of the profiling data. Find the **Process\Working Set** and the **Memory\Pages/sec** columns. Compare the two columns and determine if there are specific phases of program execution that appear to be associated with increased paging IO activity.
