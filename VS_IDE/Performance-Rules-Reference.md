---
title: "Performance Rules Reference"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 59fc9424-76ca-4365-ae47-bb14a736c9c2
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Performance Rules Reference
The performance rules of the Profiling Tools provide additional warnings and information about the performance of your application. Performance rules analyze data in a profiling run that is collected from sources such as Windows and processor performance counters. Rule messages appear in the Error Output window of the Visual Studio integrated development environment. Messages are listed with one of the following rule levels:  
  
|||  
|-|-|  
|**Error**|Few rules generate Error messages because most performance problems are not outright errors. An Error message can indicate a failure to collect profiling data.|  
|**Warning**|Warnings indicate an area of your application that can potentially be a source of performance problems or that might benefit from optimizations.|  
|**Information**|Information messages indicate that either the analysis of a rule condition did not reach the threshold to generate an Error message, or that the information in the message is useful but does not reflect a performance problem.|  
  
## In This Section  
 [Performance Rules by ID](../VS_IDE/Performance-Rules-by-ID.md)  
  
 The Profiling Tools performance rules are organized in four categories:  
  
|||  
|-|-|  
|[.NET Framework Usage Performance Rules](../VS_IDE/.NET-Framework-Usage-Performance-Rules.md)|Rules that help you use the .NET Framework efficiently.|  
|[Memory and Paging Performance Rules](../VS_IDE/Memory-and-Paging-Performance-Rules.md)|Rules that analyze the managed memory and paging behavior of your application.|  
|[Profiling Tools Usage Rules](../VS_IDE/Profiling-Tools-Usage-Rules.md)|Rules that help you use the Profiling Tools efficiently.|  
|[Resource Monitoring Performance Rules](../VS_IDE/Resource-Monitoring-Performance-Rules.md)|Information messages about processor and memory utilization in a profiling run.|