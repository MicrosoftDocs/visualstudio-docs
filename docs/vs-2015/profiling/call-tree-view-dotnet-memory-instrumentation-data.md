---
title: "Call Tree View - .NET Memory Instrumentation Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Call Tree view"
ms.assetid: dd359707-245a-4a36-8305-2e980b9edd53
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Call Tree View - .NET Memory Instrumentation Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Call Tree view of .NET memory allocation profiling data that was collected by using the instrumentation method displays the function execution paths that were traversed in the profiled application. The root of the tree is the entry point into the application or component. Each function node lists all the functions it called, and the .NET memory and timing data for the function.  
  
 The values in the Call Tree view are for the function instances that were called by the parent function in the call tree. Percentage values are calculated by comparing the function instance value to the total number or size of allocations in the profiling run.  
  
## Highlighting the Execution Hot Path  
 The Call Tree view can expand and highlight the execution path of the process or function that created the largest or most memory objects. To display the most active path, right-click the process or function, and then click **Expand Hot Path**.  
  
## Setting the Call Tree Root Node  
 Each process in the profiling run is displayed as a root node. You can set the starting node of the Call Tree view by right-clicking the node you want to set as the start node, and then selecting **Set Root**.  
  
 When you set the root node, you eliminate all other entries from the view except the subtree of the selected node. You can reset the root node back to the node you were viewing; right-click in the Call Tree View window and select **Reset Root**.  
  
## General  
  
|Column|Description|  
|------------|-----------------|  
|**Function Name**|The name of the function.|  
|**Function Address**|The address of the function.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Number of Calls**|The total number of calls made to this function.|  
|**Source File**|The source file that contains the definition for this function.|  
|**Module Name**|The name of the module that contains the function.|  
|**Module Path**|The path of the module that contains the function.|  
|**Process ID**|The process ID (PID) of the profiling run.|  
|**Process Name**|The name that is assigned to the process.|  
|**Time Exclusive Probe Overhead**|The time overhead for this function that is caused by instrumentation. Probe overhead has been subtracted from all exclusive times.|  
|**Time Inclusive Probe Overhead**|The time overhead for this function and its child functions that is caused by instrumentation. Probe overhead has been subtracted from all inclusive times.|  
|**Type**|The context of the function:<br /><br /> -   **0** - the current function<br />-   **1** - a function that calls the current function<br />-   **2** - a function that is called by the current function<br /><br /> Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|  
|**Root Function Name**|The name of the current function. Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|  
  
## .NET Memory Values  
 The inclusive .NET memory values of a function indicate the number (allocations) and size (bytes) of objects that were created by the function and functions that were called by the function.  
  
 The exclusive memory values indicate the number and size of objects that were created by code in the function body and not by functions that were called by the function.  
  
|Column|Description|  
|------------|-----------------|  
|**Inclusive Allocations**|The number of objects that were allocated by the instances of this function that were called by the parent function in the call tree. This number includes allocations that were made by child functions.|  
|**Inclusive Allocations %**|The percentage of all objects that were created in the profiling run that were inclusive allocations of the function instances that were called by the parent function in the call tree.|  
|**Exclusive Allocations**|The number of objects that were allocated by the instances of this function that were called by the parent function in the call tree. This number does not include allocations that were made by child functions.|  
|**Exclusive Allocations %**|The percentage of all objects that were created in the profiling run that were exclusive allocations of the function instances that were called by the parent function in the call tree.|  
  
## Elapsed Inclusive Values  
 Elapsed inclusive values indicate the time that a function was on the call stack. The time includes time that was spent in functions that were called by the function and in calls to the operating system, such as context switches and input/output operations.  
  
|Column|Description|  
|------------|-----------------|  
|**Elapsed Inclusive Time**|The total elapsed inclusive time of all calls to this function when it was called by the parent function in the call tree.|  
|**Elapsed Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total elapsed inclusive time of this function when it was called by the parent function in the call tree.|  
|**Avg Elapsed Inclusive Time**|The average elapsed inclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Max Elapsed Inclusive Time**|The maximum elapsed inclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Min Elapsed Inclusive Time**|The minimum elapsed inclusive time of a call to this function when it was called by the parent function in the call tree.|  
  
## Elapsed Exclusive Values  
 Elapsed exclusive values indicate the time that a function was directly executing at the top of the call stack. The time includes time in calls to the operating system, such as context switches and input/output operations. However, the time does not include time that was spent in functions that were called by the function.  
  
|Column|Description|  
|------------|-----------------|  
|**Elapsed Exclusive Time**|The total elapsed exclusive time of all calls to this function when it was called by the parent function in the call tree.|  
|**Elapsed Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total elapsed exclusive time of this function when it was called by the parent function in the call tree.|  
|**Avg Elapsed Exclusive Time**|The average elapsed exclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Max Elapsed Exclusive Time**|The maximum elapsed exclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Min Elapsed Exclusive Time**|The minimum elapsed exclusive time of a call to this function when it was called by the parent function in the call tree.|  
  
## Application Inclusive Values  
 Application inclusive values indicate the time that a function was on the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations. The time does include time that was spent in child functions that were called by the function.  
  
|Column|Description|  
|------------|-----------------|  
|**Application Inclusive Time**|The total application inclusive time of all calls to this function when it was called by the parent function in the call tree.|  
|**Application Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total application inclusive time of this function when it was called by the parent function in the call tree.|  
|**Avg Application Inclusive Time**|The average application inclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Max Application Inclusive Time**|The maximum application inclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Min Application Inclusive Time**|The minimum application inclusive time of a call to this function when it was called by the parent function in the call tree.|  
  
## Application Exclusive Values  
 Application exclusive values indicate the time that was spent in the function, excluding time that was spent in child functions that were called by the function. The time also excludes calls to the operating system, such as context switches and input/output operations.  
  
|Column|Description|  
|------------|-----------------|  
|**Application Exclusive Time**|The total application exclusive time of all calls to this function when it was called by the parent function in the call tree.|  
|**Application Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total application exclusive time of this function when it was called by the parent function in the call tree.|  
|**Avg Application Exclusive Time**|The average application exclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Max Application Exclusive Time**|The maximum application exclusive time of a call to this function when it was called by the parent function in the call tree.|  
|**Min Application Exclusive Time**|The minimum application exclusive time of a call to this function when it was called by the parent function in the call tree.|
