---
title: "Functions View - Instrumentation Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Function view"
ms.assetid: 595d91c8-a42b-4644-85b8-39e8140a5dfe
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Functions View - instrumentation data
The Functions report view lists profiling data by function name.

## General
 The general columns identify the function in a view row.

|Column|Description|
|------------|-----------------|
|**Function Name**|The name of the function.|
|**Function Address**|The address of the function.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Number of Calls**|The total number of calls that are made to this function.|
|**Source File**|The source file that contains the definition for this function.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Time Exclusive Probe Overhead**|The time overhead for this function that is caused by instrumentation. It does not include overhead in functions that were called by the function. Probe overhead has been subtracted from all exclusive times.|
|**Time Inclusive Probe Overhead**|The time overhead for this function and its child functions that is caused by instrumentation. It does include overhead in functions that were called by the function. Probe overhead has been subtracted from all inclusive times.|

## Elapsed inclusive values
 Elapsed inclusive values indicate the time that a function was on the call stack. The time does include time that was spent in functions that were called by the function and time that was spent in calls to the operating system, such as context switches and input/output operations.

|Column|Description|
|------------|-----------------|
|**Elapsed Inclusive Time**|The total elapsed inclusive time of all calls to this function.|
|**Elapsed Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the elapsed inclusive time of this function.|
|**Avg Elapsed Inclusive Time**|The average elapsed inclusive time of a call to this function.|
|**Max Elapsed Inclusive Time**|The maximum elapsed inclusive time of a call to this function.|
|**Min Elapsed Inclusive Time**|The minimum elapsed inclusive time of a call to this function.|

## Elapsed exclusive values
 Elapsed exclusive values indicate the time that a function was executing code in the body of the function, that is, when the function was at the top of the call stack. The time does include time that was spent in calls to the operating system, such as context switches and input/output operations, but it does not include time that was spent in functions that were called by the function.

|Column|Description|
|------------|-----------------|
|**Elapsed Exclusive Time**|The total elapsed exclusive time of all calls to this function.|
|**Elapsed Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total elapsed exclusive time of this function.|
|**Avg Elapsed Exclusive Time**|The average elapsed exclusive time of a call to this function.|
|**Max Elapsed Exclusive Time**|The maximum elapsed exclusive time of a call to this function.|
|**Min Elapsed Exclusive Time**|The minimum elapsed exclusive time of a call to this function.|

## Application inclusive values
 Application inclusive values indicate the time that a function was on the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations, but it does include time that was spent in functions that were called by the function.

|Column|Description|
|------------|-----------------|
|**Application Inclusive Time**|The total application inclusive time of all calls to this function.|
|**Application Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total application inclusive time of this function.|
|**Avg Application Inclusive Time**|The average application inclusive time of a call to this function.|
|**Max Application Inclusive Time**|The maximum application inclusive time of a call to this function.|
|**Min Application Inclusive Time**|The minimum application inclusive time of a call to this function.|

## Application exclusive values
 Application exclusive values indicate the time that a function was directly executing at the top of the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations, and it does not include time that was spent in functions that were called by the function.

|Column|Description|
|------------|-----------------|
|**Application Exclusive Time**|The total application exclusive time of all calls to this function.|
|**Application Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total application exclusive time of this function.|
|**Avg Application Exclusive Time**|The average application exclusive time of a call to this function.|
|**Max Application Exclusive Time**|The maximum application exclusive time of a call to this function.|
|**Min Application Exclusive Time**|The minimum application exclusive time of a call to this function.|

## See also
- [How to: Customize Report View columns](../profiling/how-to-customize-report-view-columns.md)
- [Functions View](../profiling/functions-view-sampling-data.md)
- [Functions View - sampling](../profiling/functions-view-dotnet-memory-sampling-data.md)
- [Functions View - instrumentation](../profiling/functions-view-dotnet-memory-instrumentation-data.md)
