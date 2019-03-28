---
title: "Call Tree View - Instrumentation Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Call Tree view"
ms.assetid: 306bd176-0ce9-4a10-89ca-20b043d37d4e
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Call Tree View - Instrumentation Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The values for a function in the call tree indicate the time for the function instances that were called by the parent function in the call tree. Percentage values are calculated by comparing the value of the function instances to the total elapsed inclusive time of all functions in the profiling run.  
  
## General  
 The general columns identify the function in a view row.  
  
|Column|Description|  
|------------|-----------------|  
|**Function Name**|The name of the function.|  
|**Function Address**|The address of the function.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Number of Calls**|The total number of calls that were made to this function.|  
|**Source File**|The source file that contains the definition for this function.|  
|**Module Name**|The name of the module that contains the function.|  
|**Module Path**|The path of the module that contains the function.|  
|**Process ID**|The process ID (PID) of the profiling run.|  
|**Process Name**|The name that is assigned to the process.|  
|**Time Exclusive Probe Overhead**|The time overhead for this function that was caused by instrumentation. Probe overhead has been subtracted from all exclusive times.|  
|**Time Inclusive Probe Overhead**|The time overhead for this function and its child functions that was caused by instrumentation. Probe overhead has been subtracted from all inclusive times.|  
|**Level**|The depth of the function in the call tree. Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|  
  
## Elapsed Inclusive Values  
 Elapsed inclusive values indicate the time on the call stack of those instances of the function that were called by the parent function in the call tree. The time includes time that was spent in child functions that were called by the function and in calls to the operating system, such as context switches and input/output operations.  
  
|Column|Description|  
|------------|-----------------|  
|**Elapsed Inclusive Time**|The total elapsed inclusive time of all calls to this function in this context.|  
|**Elapsed Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total elapsed inclusive time of this function in this context.|  
|**Avg Elapsed Inclusive Time**|The average elapsed inclusive time of a call to this function in this context.|  
|**Max Elapsed Inclusive Time**|The maximum elapsed inclusive time of a call to this function in this context.|  
|**Min Elapsed Inclusive Time**|The minimum elapsed inclusive time of a call to this function in this context.|  
  
## Elapsed Exclusive Values  
 Elapsed exclusive values indicate the time that those instances of a function that were called by the parent function in the call tree were executing code in the function body; that is, when the function was at the top of the call stack. The time includes time in calls to the operating system, such as context switches and input/output operations. However, the time does not include time that was spent in child functions that were called by the function.  
  
|Column|Description|  
|------------|-----------------|  
|**Elapsed Exclusive Time**|The total elapsed exclusive time of all calls to this function in this context.|  
|**Elapsed Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total elapsed exclusive time of this function in this context.|  
|**Avg Elapsed Exclusive Time**|The average elapsed exclusive time of a call to this function in this context.|  
|**Max Elapsed Exclusive Time**|The maximum elapsed exclusive time of a call to this function in this context.|  
|**Min Elapsed Exclusive Time**|The minimum elapsed exclusive time of a call to this function in this context.|  
  
## Application Inclusive Values  
 Application inclusive values indicate the time that instances of a function that were called by the parent function in the call tree were on the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations, However, the time does include time that was spent in child functions that were called by the function.  
  
|Column|Description|  
|------------|-----------------|  
|**Application Inclusive Time**|The total application inclusive time of all calls to this function in this context.|  
|**Application Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total application inclusive time of this function in this context.|  
|**Avg Application Inclusive Time**|The average application inclusive time of a call to this function in this context.|  
|**Max Application Inclusive Time**|The maximum application inclusive time of a call to this function in this context.|  
|**Min Application Inclusive Time**|The minimum application inclusive time of a call to this function in this context.|  
  
## Application Exclusive Values  
 Application exclusive values indicate the time that those instances of a function that were called by the parent function in the call tree were directly executing code in the function body; that is, when the function was at the top of the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations. It also does not include time that was spent in child functions that were called by the function.  
  
|Column|Description|  
|------------|-----------------|  
|**Application Exclusive Time**|The total application exclusive time of all calls to this function in this context.|  
|**Application Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total application exclusive time of this function in this context.|  
|**Avg Application Exclusive Time**|The average application exclusive time of a call to this function in this context.|  
|**Max Application Exclusive Time**|The maximum application exclusive time of a call to this function in this context.|  
|**Min Application Exclusive Time**|The minimum application exclusive time of a call to this function in this context.|  
  
## See Also  
 [How to: Customize Report View Columns](../profiling/how-to-customize-report-view-columns.md)   
 [Call Tree View](../profiling/call-tree-view-sampling-data.md)   
 [Call Tree View - Instrumentation](../profiling/call-tree-view-dotnet-memory-instrumentation-data.md)   
 [Call Tree View - Sampling](../profiling/call-tree-view-dotnet-memory-sampling-data.md)
