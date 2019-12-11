---
title: "Performance Rules Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
ms.assetid: 59fc9424-76ca-4365-ae47-bb14a736c9c2
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Performance Rules Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The performance rules of the Profiling Tools provide additional warnings and information about the performance of your application. Performance rules analyze data in a profiling run that is collected from sources such as Windows and processor performance counters. Rule messages appear in the Error Output window of the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] integrated development environment. Messages are listed with one of the following rule levels:  
  
|||  
|-|-|  
|**Error**|Few rules generate Error messages because most performance problems are not outright errors. An Error message can indicate a failure to collect profiling data.|  
|**Warning**|Warnings indicate an area of your application that can potentially be a source of performance problems or that might benefit from optimizations.|  
|**Information**|Information messages indicate that either the analysis of a rule condition did not reach the threshold to generate an Error message, or that the information in the message is useful but does not reflect a performance problem.|  
  
## In This Section  
 [Performance Rules by ID](../profiling/performance-rules-by-id.md)  
  
 The Profiling Tools performance rules are organized in four categories:  
  
|||  
|-|-|  
|[.NET Framework Usage Performance Rules](../profiling/dotnet-framework-usage-performance-rules.md)|Rules that help you use the .NET Framework efficiently.|  
|[Memory and Paging Performance Rules](../profiling/memory-and-paging-performance-rules.md)|Rules that analyze the managed memory and paging behavior of your application.|  
|[Profiling Tools Usage Rules](../profiling/profiling-tools-usage-rules.md)|Rules that help you use the Profiling Tools efficiently.|  
|[Resource Monitoring Performance Rules](../profiling/resource-monitoring-performance-rules.md)|Information messages about processor and memory utilization in a profiling run.|
