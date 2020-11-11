---
title: "Summary View - Resource Contention View | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Summary view"
ms.assetid: 6da57b83-7b42-4d7c-9aea-8e0a830faf6b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Summary View - Resource Contention View
The Summary view displays information about the events in your application in which a thread or process was suspended while it waited for access to a resource.

 For more information, including a description of the Notification Links and Report lists, see [Summary View](../profiling/summary-view.md).

## Timeline Graph
 The timeline graph in the Summary view shows the number of contention events of the profiled application over the time that the profiling occurred. You can use the timeline graph to filter the view to a selected time span. For more information, see [How to: Filter Report Views from the Summary Timeline](../profiling/how-to-filter-report-views-from-the-summary-timeline.md).

## Most Contended Resources
 **Most Contended Resources** lists the resources in the application that caused the most contention events. You can click a resource name to display the Contentions view. The Contentions view provides a detailed timeline of the resource contentions by thread.

 **Most Contended Resources** includes the following data for each resource.

|Column|Description|
|------------|-----------------|
|**Name**|The name of the resource.|
|**Contentions %**|The percentage of all contention events in the profiling data that were contentions over this resource.|

## Most Contended Thread
 **Most Contended Threads** lists the threads in the application that had the largest number of contention events. You can click a thread name to display the Contentions view that provides a detailed timeline of the resource contentions by the thread.

 **Most Contended Threads** includes the following data for each thread.

|Column|Description|
|------------|-----------------|
|**ID**|The thread identifier.|
|**Name**|The name of the process that owns the thread.|
|**Contentions %**|The percentage of all contention events in the profiling data that were contentions over this resource.|
