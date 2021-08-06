---
title: "Lines View - .NET Memory Sampling Data | Microsoft Docs"
description: Learn how the Lines view for .NET memory allocation profiling data lists the statements that allocated memory during the profiling run.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Lines view"
ms.assetid: 6631ab87-0e62-4c76-a063-4ea7222b07da
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# Lines View - .NET Memory sampling data
The Lines view for .NET memory allocation profiling data that uses the sampling method lists the statements that allocated memory during the profiling run. The columns also include the size and number of allocations.

 In a source file, a statement can span more than one line in a source file, and a single line can include more than one statement.

 A statement is identified by the following:

- The source file that contains the function statement.

- The function that contains the statement.

- The source line at which the statement starts.

- The character in the source line at which the statement starts.

- The source line at which the statement ends.

- The character in the source line at which the statement ends.

  The Line Name column provides a sortable concatenation of the identifier data.

  By definition, a statement does not call other functions. Therefore, only exclusive values are listed.

|Column|Description|
|------------|-----------------|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Module Name**|The name of the module that contains the statement.|
|**Module Path**|The path of the module that contains the statement.|
|**Source File**|The source file that contains the statement.|
|**Function Name**|The name of the function that contains the statement.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Function Address**|The starting address of the function.|
|**Source Line Begin**|The starting line number in the source file at which the allocation occurred.|
|**Source Line End**|The ending line number in the source file at which the allocation occurred.|
|**Source Character Begin**|The offset of the starting character in the source file line at which the allocation occurred.|
|**Source Character End**|The offset of the ending character in the source file line at which the allocation occurred.|
|**Line Name**|A profiler-generated identifier of the line with the following syntax:`Source File`**;[**`Line Number Start`**,**`Character Start`**]->;[**`Line Number Start,Character Start`**]**|
|**Exclusive Allocations**|The total number of objects that were created in this line.|
|**Exclusive Allocations %**|The percentage of all objects that were created in the profiling run that were allocated in this line.|
|**Exclusive Bytes**|The percentage of all bytes of memory that were allocated in the profiling run that were allocated in this line.|
|**Exclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were allocated in this line.|

## See also
- [Lines View](../profiling/lines-view-sampling-data.md)
