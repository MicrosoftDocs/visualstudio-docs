---
title: "Call Tree View - Sampling Data | Microsoft Docs"
description: Read how the Call Tree view displays sampling data for the function execution paths that were traversed in the profiled application in Performance Explorer.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "sampling profiling method,Call Tree view"
  - "Call Tree view"
ms.assetid: 5c4e8ec3-d0d3-485a-93bd-9060df4eb739
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Call Tree view - sampling data
The Call Tree view displays the function execution paths that were traversed in the profiled application.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

 The root of the tree is the entry point into the application or the component. Each function node lists all the functions that it called and performance data about those function calls.

 The values in the Call Tree view are for the function instances that were called by the parent function in the call tree. Percentage values are calculated by comparing the function instance value to the total number of samples in the profiling run.

## Highlight the execution hot path
 The Call Tree view can expand and highlight the execution path of the process or function that was sampled most frequently. To display the most active path, right-click the process or function and then click **Expand Hot Path**.

## Set the call tree root node
 Each process in the profiling run is displayed as a root node. To set the start node of the Call Tree view, right-click the node that you want to set as the start node and select **Set Root**.

 When you set the root node, you eliminate all other entries from the view except the subtree of the selected node. To reset the root node back to the original node, right-click in the Call Tree View window and select **Reset Root**.

|Column|Description|
|------------|-----------------|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|
|**Source File**|The source file that contains the definition for this function.|
|**Function Name**|The fully qualified name of the function.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Function Address**|The address of the function.|
|**Level**|The depth of this function in the call tree. Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|
|**Exclusive Samples**|The number of samples that were collected in this function when it was called by the parent function in the call tree. This number does not include samples that were collected in functions that were called by the function.|
|**Exclusive Samples %**|The percentage of all samples in the profiling run that were exclusive samples of this function when it was called by the parent function in the call tree.|
|**Inclusive Samples**|The number of samples that were collected in this function when it was called by the parent function in the call tree. This number includes samples that were collected in functions that were called by the function.|
|**Inclusive Samples %**|The percentage of all samples in the profiling run that were inclusive samples of this function when it was called by the parent function in the call tree.|

## See also
- [How to: Customize report view columns](../profiling/how-to-customize-report-view-columns.md)
- [Call Tree view - profiler sampling data](../profiling/call-Tree-view-sampling-data.md)
- [Call Tree view - sampling](../profiling/call-tree-view-dotnet-memory-sampling-data.md)
- [Call Tree view - instrumentation](../profiling/call-tree-view-dotnet-memory-instrumentation-data.md)
- [Call Tree view](../profiling/call-tree-view-instrumentation-data.md)
