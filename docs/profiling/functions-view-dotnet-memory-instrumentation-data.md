---
title: "Functions View - .NET Memory Instrumentation Data | Microsoft Docs"
description: Get information about the Functions view of .NET memory allocation profiling data that was collected by using the instrumentation method.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Functions view"
ms.assetid: cd45b379-394b-4b71-828c-92cd89e46ae0
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# Functions View - .NET memory instrumentation data
The Functions view of .NET memory allocation profiling data that was collected by using the instrumentation method lists the functions that allocated memory during the profiling run. A function row reports the size and number of allocations, and the timing data for the function.

## General

|Column|Description|
|------------|-----------------|
|**Function Name**|The name of the function.|
|**Function Address**|The address of the function.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Number of Calls**|The total number of calls that are made to this function.|
|**Source File**|The source file that contains the definition of this function.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Time Exclusive Probe Overhead**|The time overhead for this function because of instrumentation. Probe overhead has been subtracted from all exclusive times.|
|**Time Inclusive Probe Overhead**|The time overhead for this function and its child functions because of instrumentation. Probe overhead has been subtracted from all inclusive times.|

## .NET memory values
 The inclusive .NET memory values of a function indicate the number (allocations) and size (bytes) of objects that were created by the function and its child functions.

 The exclusive memory values indicate the number and size of objects that were created by the function and not by its child functions.

|Column|Description|
|------------|-----------------|
|**Inclusive Allocations**|The total number of objects that were created in this function and in functions that were called by this function.|
|**Inclusive Allocations %**|The percentage of all objects that were allocated in the profiling run that were inclusive allocations of this function.|
|**Exclusive Allocations**|The total number of objects that were created when the function was executing code in the function body. This number does not include objects that were created in functions that were called by this function.|
|**Exclusive Allocations %**|The percentage of all objects that were created in the profiling run that were exclusive allocations of this function.|
|**Inclusive Bytes**|The number of bytes of memory that were allocated in this function and in functions that were called by this function.|
|**Inclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were inclusive bytes of this function.|
|**Exclusive Bytes**|The number of bytes of memory that were allocated by this function but not by functions that were called by this function.|
|**Exclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were exclusive bytes of this function.|

## Elapsed inclusive values
 Elapsed inclusive values indicate the time that a function was on the call stack. The time includes time that was spent in child functions and in calls to the operating system, such as context switches and input/output operations.

|Column|Description|
|------------|-----------------|
|**Elapsed Inclusive Time**|The total elapsed inclusive time of all calls to this function.|
|**Elapsed Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the elapsed inclusive time of this function.|
|**Avg Elapsed Inclusive Time**|The average elapsed inclusive time of a call to this function.|
|**Max Elapsed Inclusive Time**|The maximum elapsed inclusive time of a call to this function.|
|**Min Elapsed Inclusive Time**|The minimum elapsed inclusive time of a call to this function.|

## Elapsed exclusive values
 Elapsed exclusive values indicate the time that a function was directly executing at the top of the call stack. The time includes time in calls to the operating system, such as context switches and input/output operations, but it does not include time that was spent in child functions.

|Column|Description|
|------------|-----------------|
|**Elapsed Exclusive Time**|The total elapsed exclusive time of all calls to this function.|
|**Elapsed Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total elapsed exclusive time of this function.|
|**Avg Elapsed Exclusive Time**|The average elapsed exclusive time of a call to this function.|
|**Max Elapsed Exclusive Time**|The maximum elapsed exclusive time of a call to this function.|
|**Min Elapsed Exclusive Time**|The minimum elapsed exclusive time of a call to this function.|

## Application inclusive values
 Application inclusive values indicate the time that a function was on the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations, but it does include time that was spent in child functions.

|Column|Description|
|------------|-----------------|
|**Application Inclusive Time**|The total application inclusive time of all calls to this function.|
|**Application Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total application inclusive time of this function.|
|**Avg Application Inclusive Time**|The average application inclusive time of a call to this function.|
|**Max Application Inclusive Time**|The maximum application inclusive time of a call to this function.|
|**Min Application Inclusive Time**|The minimum application inclusive time of a call to this function.|

## Application exclusive values
 Application exclusive values indicate the time that a function was directly executing at the top of the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations, nor does it include time that was spent in child functions.

|Column|Description|
|------------|-----------------|
|**Application Exclusive Time**|The total application exclusive time of all calls to this function.|
|**Application Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total application exclusive time of this function.|
|**Avg Application Exclusive Time**|The average application exclusive time of a call to this function.|
|**Max Application Exclusive Time**|The maximum application exclusive time of a call to this function.|
|**Min Application Exclusive Time**|The minimum application exclusive time of a call to this function.|

## See also
- [How to: Customize Report View columns](../profiling/how-to-customize-report-view-columns.md)
- [Functions View - sampling](../profiling/functions-view-dotnet-memory-sampling-data.md)
- [Functions View](../profiling/functions-view-instrumentation-data.md)
- [Functions View](../profiling/functions-view-sampling-data.md)
