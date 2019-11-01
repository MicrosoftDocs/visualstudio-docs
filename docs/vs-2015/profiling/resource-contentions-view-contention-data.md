---
title: "Resource Contentions View - Contention Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.view.resourcecontention"
helpviewer_keywords: 
  - "Resource Contentions view"
ms.assetid: 14a7f774-211f-4ef8-af05-94d1c8f65d2f
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Resource Contentions View - Contention Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Resource Contention view lists contention data for the resources that were the source of contention events. A contention event occurs when a function in a thread is forced to wait for access to the resource because a function in another thread has acquired exclusive access to the resource. Each resource is the root node of a call tree that displays the function execution paths that resulted in the contention events.  
  
## Data Values  
  
### Resource values  
 The data in a resource row displays the total time that access to the resource was blocked in the profiling data and the total number of contention events that occurred because of access conflict to this resource. Inclusive and exclusive values for a resource are always the same.  
  
### Function values  
 Function values are based on the instances of the function that occurred in the execution path represented in the call tree.  
  
- Exclusive values are based on the events that occurred when the function was executing statements in its function body. Events that occurred in functions that were called by the function are not included in exclusive values.  
  
- Inclusive values are based on the events that occurred when the function or a function called by the function was executing.  
  
### Percentage values  
 Percentage values are based on the total time or contention events in the profiling data. If the report or view of the profiling run is filtered, only the blocked time and contentions in the filtered data are used as the total value.  
  
## Navigating the Resource Allocation View  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of resource or function.|  
|**Exclusive Blocked Time**|-   For a resource, the total time that access to the resource was blocked and caused a thread to wait.<br />-   For a function, the time that these instances of the function were blocked from accessing the parent resource when the function was executing code in the function body. Blocked time in functions that were called by the function is not included.|  
|**Exclusive Blocked Time %**|-   For a resource, the percentage of all blocked time in the profiling data that was blocked time of this resource<br />-   For a function, the percentage of all blocked time in the profiling data that was exclusive blocked time of these function instances.|  
|**Exclusive Contentions**|-   For a resource, the total number of times that access to the resource was blocked and caused a thread to wait.<br />-   For a function, the number of times that these instances of the function were blocked from accessing the parent resource when the function was executing code in the function body. Blocking events in functions that were called by the function are not included.|  
|**Exclusive Contentions %**|-   For a resource, the percentage of all contention events in the profiling data that were contention events for access to this resource.<br />-   For a function, the percentage of all contention events in the profiling data that were exclusive contention events of these function instances for the parent resource.|  
|**Inclusive Blocked Time**|-   For a resource, the total time that access to the resource was blocked and caused a thread to wait.<br />-   For a function, the time that these instances of the function or any functions called by the instances were blocked from accessing the parent resource when the function was executing code in the function body.|  
|**Inclusive Blocked Time %**|-   For a resource, the percentage of all blocked time in the profiling data that was blocked time of this resource<br />-   For a function, the percentage of all blocked time in the profiling run that was inclusive blocked time of these function instances.|  
|**Inclusive Contentions**|-   For a resource, the total number of times that access to the resource was blocked and caused a thread to wait.<br />-   For a function, the percentage of all contention events in the profiling run that were inclusive contention events of these function instances for the parent resource.|  
|**Inclusive Contentions %**|-   For a resource, the percentage of all contention events in the profiling run that were contention events for access to this resource.<br />-   For a function, the number of times that these instances of the function were blocked from accessing the parent resource when the function was executing code in the function body. Blocking events in functions that were called by the function are not included.|  
|**Level**|The depth of this function in the call tree. Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Module Name**|The name of the module that contains the function.|  
|**Module Path**|The path of the module that contains the function.|  
|**Process ID**|The process ID (PID) of the process in which the function was executing.|  
|**Process Name**|The name of the process.|  
|**Source File**|The source file that contains the definition for this function.|
