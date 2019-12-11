---
title: "Call Tree View - Contention Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Call Tree view"
ms.assetid: 9bd4bde2-2ca3-446c-9ccc-7421522e03ae
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Call Tree view - contention data
The Call Tree view displays the function execution paths that were traversed in the profiled application. The root of the tree is the entry point into the application or the component. Each function node lists all functions that it called, the number of times that the function was blocked, and the amount of time that the function was blocked because it was contending for a resource with other threads or processes.

 The values in the Call Tree view are for the function instances that were called by the parent function in the call tree. Percentage values are calculated by comparing the function instance value to the total number of contentions in the profiling run.

## Highlight the execution hot path
 The Call Tree view can expand and highlight the execution path of the process or function that created the most contentions.

- To display the most active path, right-click the process or function, and then click **Expand Hot Path**.

## Set the Call Tree root node
 Each process in the profiling run appears as a root node. To set the starting node of the Call Tree view, right-click the node that you want to set as the start node, and then click **Set Root**.

 When you set the root node, you eliminate all other entries from the view except for the subtree of the  node that you selected. To reset the root node back to the original node, right-click in the Call Tree view, and then click **Reset Root**.

|Column|Description|
|------------|-----------------|
|**Exclusive Blocked Time**|The time that instances of this function in this execution path were blocked from executing in the profiling run. The time does not include the blocked time of child functions that were called by the function.|
|**Exclusive Blocked Time %**|The percentage of all blocked time in the profiling run that was exclusive blocked time for this function in this execution path.|
|**Exclusive Contentions**|The number of contentions that occurred in instances of this function in this execution path. The number does not include contentions of child functions called by the function.|
|**Exclusive Contentions %**|The percentage of all contentions in the profiling run that were exclusive contentions of the instances of this function that were called by the parent function in the call tree.|
|**Function Address**|The address of the function.|
|**Function Name**|The fully qualified name of the function.|
|**Inclusive Blocked Time**|The total time that the instances of this function in this execution path were blocked from executing in the profiling run. The time includes the blocked time of child functions called by the function.|
|**Inclusive Blocked Time %**|The percentage of all blocked time in the profiling run that was the inclusive blocked time for the instances of this function in this execution path.|
|**Inclusive Contentions**|The total number of contentions that blocked instances of this function in this execution path. The number includes the contentions of child functions called by the function.|
|**Inclusive Contentions %**|The percentage of all contentions in the profiling run that were inclusive contentions of the instances of this function in this execution path.|
|**Level**|The level of the function in the call tree. Only in VSReport command-line reports. For more information, see in [VSPerfReport](../profiling/vsperfreport.md).|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Source File**|The source file that contains the definition for this function.|

## See also
- [How to: Customize report view columns](../profiling/how-to-customize-report-view-columns.md)
- [Call Tree view](../profiling/call-tree-view.md)
- [Call Tree view - instrumentation](../profiling/call-tree-view-dotnet-memory-instrumentation-data.md)
- [Call Tree view - sampling](../profiling/call-tree-view-dotnet-memory-sampling-data.md)
- [Call Tree view](../profiling/call-tree-view-instrumentation-data.md)
- [Call Tree view](../profiling/call-tree-view-sampling-data.md)
