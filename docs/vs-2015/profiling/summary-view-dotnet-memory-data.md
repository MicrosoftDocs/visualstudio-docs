---
title: "Summary View - .NET Memory Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Summary view"
ms.assetid: 0cb317c3-0ae6-4531-aaa8-447576eec037
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Summary View - .NET Memory Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Summary view displays information about the .NET functions and types that allocated the most memory, and the types that were created the most times in a profiling run. For more information, including a description of the Notification Links and Report lists, see [Summary View](../profiling/summary-view.md).  
  
## Timeline Graph  
 The timeline graph in the Summary view shows the processor (CPU) utilization by the profiled application over the time that the profiling occurred. You can use the timeline graph to filter the view to a selected time span. For more information, see [How to: Filter Report Views from the Summary Timeline](../profiling/how-to-filter-report-views-from-the-summary-timeline.md).  
  
## Functions Allocating Most Memory  
 Lists the functions that allocated the greatest number of bytes of memory in the profiling run.  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of the function.|  
|**Bytes %**|The percentage of all allocated bytes in the profiling run that were allocated by this function or by a child function that was called by this function.|  
  
## Types with Most Memory Allocated  
 Lists the types for which the greatest number of bytes of memory were allocated in the profiling run.  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of the type.|  
|**Bytes %**|The percentage of all allocated bytes in the profiling run that were allocated for this type.|  
  
## Types with Most Instances  
 Lists the types that were created the most times during the profiling run. had  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of the type.|  
|**Instances %**|The percentage of the total number of.NET objects that were created in the profiling run that were instances of this type.|  
  
## See Also  
 [Summary View](../profiling/summary-view-sampling-data.md)   
 [Summary View](../profiling/summary-view-instrumentation-data.md)
