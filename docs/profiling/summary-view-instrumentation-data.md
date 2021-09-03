---
title: "Summary View - Instrumentation Data | Microsoft Docs"
description: Learn how the Summary view displays information about the most performance-expensive functions and a description of the Notification Links and Report lists.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Summary view"
ms.assetid: 0a3b3a1f-e22b-4ac8-b46e-71694e9b2cf1
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Summary view - instrumentation data
The Summary view displays information about the most performance-expensive functions in a profiling run. For more information, including a description of the Notification Links and Report lists, see [Summary view](../profiling/summary-view.md).

## Timeline Graph
 The timeline graph in the Summary view shows the processor (CPU) utilization by the profiled application over the time that the profiling occurred. You can use the timeline graph to filter the view to a selected time span. For more information, see [How to: Filter report views from the Summary Timeline](../profiling/how-to-filter-report-views-from-the-summary-timeline.md).

## Hot Path
 The **Hot Path** displays the execution path that consumed the most time. You can click a function to display the Function Details view for the function. To display other views for the function right-click the function and then click a view from the list.

 The **Hot Path** includes the following data for each function:

|Column|Description|
|------------|-----------------|
|**Name**|The name of the function.|
|**Elapsed Inclusive Time %**|The percentage of all time in the profiling data that the function spent executing code in its function body and in functions that it called.|
|**Elapsed Exclusive Time %**|The percentage of all time in the profiling data that the function spent executing code in its function body. Time spent in functions that the function called is not included.|

## Functions with Most Individual Work
 A list of the functions that consumed the most time executing code in body of the function and not in functions that it called.

 **Functions with Most Individual Work** includes the following data for each function:

|Column|Description|
|------------|-----------------|
|**Name**|The name of the function.|
|**Exclusive Time %**|The percentage of all time in the profiling data that the function spent executing code in its function body. Time spent in functions that the function called is not included.|

## See also
- [Summary view - sampling data](../profiling/summary-view-sampling-data.md)
- [Summary view - .NET memory data](../profiling/summary-view-dotnet-memory-data.md)
