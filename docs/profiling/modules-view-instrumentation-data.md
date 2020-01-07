---
title: "Modules View - Instrumentation Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Modules view"
ms.assetid: 895b9589-1987-4160-916f-53b898a69cf0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Modules View - instrumentation data
The Modules view displays performance data that is grouped by the modules that were in the profiling data. The functions of the module are listed below the module node.

## General
 The general columns identify the function in a view row.

|Column|Description|
|------------|-----------------|
|**Name**|The name of the function or module.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Number of Calls**|The total number of calls that were made to this function or module.|
|**Source File**|The source file that contains the definition for this function.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process in which the module or function was executing.|
|**Time Exclusive Probe Overhead**|The time overhead for this function or module because of instrumentation.|
|**Time Inclusive Probe Overhead**|The time overhead for this function or module and its child functions because of instrumentation.|

## Elapsed inclusive values
 Elapsed inclusive values indicate the time that a function was on the call stack. The time includes time that was spent in child functions and in calls to the operating system, such as context switches and input/output operations.

|Column|Description|
|------------|-----------------|
|**Elapsed Inclusive Time**|-   For a function, the time that was spent in the function. This includes time that was spent in child functions and in calls to the operating system, such as context switches and input/output operations.<br />-   For a module, the time in which at least one function in the module was on the call stack.|
|**Elapsed Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the total elapsed inclusive time of this module or function.|
|**Avg Elapsed Inclusive Time**|-   For a function, the average elapsed inclusive time of a call to this function.<br />-   For a module, the average elapsed inclusive time of all calls to functions in the module.|
|**Max Elapsed Inclusive Time**|-   For a function, the maximum elapsed inclusive time of a call to this function.<br />-   For a module, the maximum elapsed inclusive time of all calls to functions in the module.|
|**Min Elapsed Inclusive Time**|-   For a function, the minimum elapsed inclusive time of a call to this module or function.<br />-   For a module, the minimum elapsed inclusive time of all calls to functions in the module.|

## Elapsed exclusive values
 Elapsed exclusive values indicate the time that a function was directly executing at the top of the call stack. The time includes time that was spent in calls to the operating system, such as context switches and input/output operations, but it does not include time that was spent in child functions.

|Column|Description|
|------------|-----------------|
|**Elapsed Exclusive Time**|-   For a function, the time that was spent in the module or function. This includes calls to the operating system, such as context switches and input/output operations, but excludes time that was spent in child functions.<br />-   For a module, the sum of elapsed exclusive times of the functions in the module.|
|**Elapsed Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the total elapsed exclusive time of this module or function.|
|**Avg Elapsed Exclusive Time**|-   For a function, the average elapsed exclusive time of a call to this function.<br />-   For a module, the average elapsed exclusive time of all calls to functions in the module.|
|**Max Elapsed Exclusive Time**|-   For a function, the maximum elapsed exclusive time of a call to this function.<br />-   For a module, the maximum elapsed exclusive time of all calls to functions in the module.|
|**Min Elapsed Exclusive Time**|-   For a function, the minimum elapsed exclusive time of a call to this module or function.<br />-   For a module, the minimum elapsed exclusive time of all calls to functions in the module.|

## Application inclusive values
 Application inclusive values indicate the time that a function was on the call stack. The time does not include time that was spent in calls to the operating system, such as context switches and input/output operations.However, the time does include time that was spent in child functions.

|Column|Description|
|------------|-----------------|
|**Application Inclusive Time**|-   For a function, the time that was spent in calls to the function. This includes time that was spent in child functions, but excludes calls to the operating system, such as context switches and input/output operations.<br />-   For a module, the time in which at least one function in the module was on the call stack. This excludes time that was spent in calls to the operating system.|
|**Application Inclusive Time %**|The percentage of the total elapsed inclusive time of the profiling run that was spent in the application inclusive time of this module or function.|
|**Avg Application Inclusive Time**|-   For a function, the average application inclusive time of a call to this function.<br />-   For a module, the average application inclusive time of all calls to functions in the module.|
|**Max Application Inclusive Time**|-   For a function, the maximum application inclusive time of a call to this function.<br />-   For a module, the maximum application inclusive time of all calls to functions in the module.|
|**Min Application Inclusive Time**|-   For a function, the minimum application inclusive time of a call to this module or function.<br />-   For a module, the minimum application inclusive time of all calls to functions in the module.|

## Application exclusive values
 Application exclusive values indicate the time that was spent in the module or function. This excludes time that was spent in child functions, and also excludes calls to the operating system, such as context switches and input/output operations.

|Column|Description|
|------------|-----------------|
|**Application Exclusive Time**|The total application exclusive time of all calls to this module or function.|
|**Application Exclusive Time %**|The percentage of the total elapsed exclusive time of the profiling run that was spent in the application exclusive time of this module or function.|
|**Avg Application Exclusive Time**|-   For a function, the average application exclusive time of a call to this function.<br />-   For a module, the average application exclusive time of all calls to functions in the module.|
|**Max Application Exclusive Time**|-   For a function, the maximum application exclusive time of a call to this function.<br />-   For a module, the maximum application exclusive time of all calls to functions in the module.|
|**Min Application Exclusive Time**|-   For a function, the minimum application exclusive time of a call to this module or function.<br />-   For a module, the minimum application exclusive time of all calls to functions in the module.|

## See also
- [Modules View](../profiling/modules-view-sampling-data.md)
- [Modules View - instrumentation](../profiling/modules-view-dotnet-memory-instrumentation-data.md)
- [Modules View - sampling](../profiling/modules-view-dotnet-memory-sampling-data.md)
