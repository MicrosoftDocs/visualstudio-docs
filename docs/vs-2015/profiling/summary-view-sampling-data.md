---
title: "Summary View - Sampling Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "sampling profiling method, Summary view"
  - "Summary view"
ms.assetid: 79056873-2985-40be-9112-cdbc26a65156
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Summary View - Sampling Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Summary view displays information about the most performance-expensive functions in a profiling run. For more information, including a description of the Notification Links and Report lists, see [Summary View](../profiling/summary-view.md).  
  
> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## Timeline Graph  
 The timeline graph in the Summary view shows the percentage of processor (CPU) utilization of the profiled application over the time that the profiling occurred. You can use the timeline graph to filter the view to a selected time span. For more information, see [How to: Filter Report Views from the Summary Timeline](../profiling/how-to-filter-report-views-from-the-summary-timeline.md).  
  
## Hot Path  
 The **Hot Path** displays the execution path in which most samples were collected. You can click a function to display the Function Details view for the function. To display other views for the function, right-click the function and then click a view from the list.  
  
 The **Hot Path** includes the following data for each function:  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of the function.|  
|**Inclusive Samples %**|The percentage of all samples that occurred when this function or a function called by this function was executing.|  
|**Exclusive Samples %**|The percentage of all samples that occurred when the function was executing code in the function body. Samples collected in functions called by this function are not included.|  
  
## Functions Doing Most Individual Work  
 The **Functions Doing Most Individual Work** list displays the functions that have the greatest number of exclusive samples in the profiling run. An exclusive sample is assigned to a function if the function is executing its own code when the sample was collected. An exclusive sample is not assigned to a function if the function is calling another function when the sample was collected. A large number of exclusive samples indicates that significant time was spent in the function itself.  
  
 You can click a function to display the Function Details view for the function. To display other views for the function right-click the function and then click a view from the list.  
  
 **Functions Doing Most Individual Work** includes the following data for each function:  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of the function.|  
|**Exclusive Samples %**|The percentage of all samples in the profiling run that were collected when the function was executing code in its function body. The percentage excludes samples that were collected when functions that this function called were executing.|  
  
## See Also  
 [Summary View](../profiling/summary-view-dotnet-memory-data.md)   
 [Summary View](../profiling/summary-view-instrumentation-data.md)
