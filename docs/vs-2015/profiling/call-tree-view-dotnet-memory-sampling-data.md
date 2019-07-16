---
title: "Call Tree View - .NET Memory Sampling Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Call Tree view"
ms.assetid: fbb6cb60-420b-4ca9-8306-2494f7d321fe
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Call Tree View - .NET Memory Sampling Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Call Tree view displays the function execution paths that were traversed in the profiled application. The root of the tree is the entry point into the application or the component. Each function node lists all the functions that it called and the .NET memory allocation data about those function calls.  
  
 The values in the Call Tree view are for the function instances that were called by the parent function in the call tree. Percentage values are calculated by comparing the function instance value to the total number or size of allocations in the profiling run.  
  
## Highlighting the Execution Hot Path  
 The Call Tree view can expand and highlight the execution path of the process or function that created the largest or most memory objects. To display the most active path, right-click the process or function, and then click **Expand Hot Path**.  
  
## Setting the Call Tree Root Node  
 Each process in the profiling run is displayed as a root node. To set the starting node of the Call Tree view to a different node, right-click the node that you want to set as the start node and select **Set Root**.  
  
 When you set the root node, you eliminate all other entries from the view except the subtree of the selected node. You can reset the root node back to the node that you were viewing; right-click in the Call Tree View window and select **Reset Root**.  
  
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
|**Level**|The depth of the function in the call tree.|  
|**Inclusive Allocations**|The number of objects that were allocated by the instances of this function that were called by the parent function in the call tree. This number includes allocations that were made by child functions.|  
|**Inclusive Allocations %**|The percentage of all objects that were created in the profiling run that were inclusive allocations of this function.|  
|**Exclusive Allocations**|The number of objects that were allocated by the instances of this function that were called by the parent function in the call tree. This number does not include allocations that were made by child functions.|  
|**Exclusive Allocations %**|The percentage of all objects that were created in the profiling run that were exclusive allocations of the function instances that were called by the parent function in the call tree.|  
|**Inclusive Bytes**|The number of bytes in memory that were allocated by the instances of this function that were called by the parent function in the call tree. This number includes allocations that were made by child functions.|  
|**Inclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were inclusive allocations of this function.|  
|**Exclusive Bytes**|The number of bytes in memory that were allocated by the instances of this function that were called by the parent function in the call tree. This number does not include allocations that were made by child functions.|  
|**Exclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were exclusive allocations of this function.|  
  
## See Also  
 [Call Tree View - Instrumentation](../profiling/call-tree-view-dotnet-memory-instrumentation-data.md)   
 [Call Tree View](../profiling/call-tree-view-sampling-data.md)   
 [Call Tree View](../profiling/call-tree-view-instrumentation-data.md)
