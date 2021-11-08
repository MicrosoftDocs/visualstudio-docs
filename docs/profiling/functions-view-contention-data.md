---
title: "Functions View - Contention Data | Microsoft Docs"
description: Get details about the Functions report view of contention data, which lists the functions in the profiling run that were blocked from execution during the profiling run.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Functions view"
ms.assetid: 208773b0-1a54-4b7a-ad37-2b6fd4f731d4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Functions View - contention data
The Functions report view of contention data lists the functions in the profiling run that were blocked from execution during the profiling run.

 The following table explains the values that are displayed in the Functions view of a profiling data file that was collected by using the concurrency method.

|Column|Description|
|------------|-----------------|
|**Exclusive Blocked Time**|The amount of time during which this function was blocked from executing code in the body of the function. Blocked time in functions that were called by the function is not included.|
|**Exclusive Blocked Time %**|The percentage of all blocked time in the profiling run that was the exclusive blocked time of this function.|
|**Exclusive Contentions**|The number of times that this function was blocked from executing code in the body of the function. Contentions in functions that were called by the function are not included.|
|**Exclusive Contentions %**|The percentage of all contentions in the profiling run were exclusive contentions of this function.|
|**Function Address**|The address of the function.|
|**Function Name**|The fully qualified name of the function.|
|**Inclusive Blocked Time**|The time that this function or a function that was called by this function was blocked from executing.|
|**Inclusive Blocked Time %**|The percentage of all blocked time in the profiling run that was inclusive blocked time of this function or module.|
|**Inclusive Contentions**|The number of times that this function or a function that was called by this function was blocked from executing.|
|**Inclusive Contentions %**|The percentage of all contentions in the profiling run that were inclusive contentions of this function or module.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module that contains the function.|
|**Process ID**|The process ID (PID) of the process in which the function was executing.|
|**Process Name**|The name of the process.|
|**Source File**|The source file that contains the definition for this function.|

## See also
- [How to: Customize Report View columns](../profiling/how-to-customize-report-view-columns.md)
- [Functions View](../profiling/functions-view.md)
- [Functions View - instrumentation](../profiling/functions-view-dotnet-memory-instrumentation-data.md)
- [Functions View - sampling](../profiling/functions-view-dotnet-memory-sampling-data.md)
- [Functions View](../profiling/functions-view-instrumentation-data.md)
- [Functions View](../profiling/functions-view-sampling-data.md)
