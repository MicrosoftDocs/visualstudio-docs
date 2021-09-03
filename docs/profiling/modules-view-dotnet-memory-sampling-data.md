---
title: "Modules View - .NET Memory Sampling Data | Microsoft Docs"
description: Learn about the Modules view of .NET memory allocation data that is collected by using the sampling method.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Modules view"
ms.assetid: 9c05b51a-8382-44cf-a8f7-3fabdd2e8f1b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# Modules View - .NET memory sampling data
The Modules view of .NET memory allocation data that is collected by using the sampling method groups the memory data by the modules that were executed in the profiling run. Each module is the root of a hierarchical tree. The functions of the module are listed underneath the module node.

 The source file line numbers of statements that allocate memory are listed underneath the function node, and the addresses of the instructions that do the allocation are listed underneath the line node. Inclusive and exclusive values are always the same for line data and instruction data.

|Column|Description|
|------------|-----------------|
|**Name**|The name of the module, function, line number, or instruction address.|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Module Name**|The name of the module that contains the function.|
|**Module Path**|The path of the module.|
|**Source File**|The source file that contains the definition for this function.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Inclusive Allocations**|-   For a function, the total number of objects that were created by the function. The number includes objects that were created in functions that were called by this function.<br />-   For a module, the number of objects in a profiling run that were allocated while at least one function from the module was executing. The number includes objects that were created in functions that were called by the module functions.<br />-   For a line or instruction, the total number of objects that were allocated by the line or instruction.|
|**Inclusive Allocations %**|The percentage of all objects that were allocated in the profiling run that were inclusive allocations of the module, function, line, or instruction.|
|**Exclusive Allocations**|-   For the current function, the number of objects that were created when the function was executing code of the function body (that is, when the function was at the top of the call stack). The number does not include objects that were created in functions that were called by this function.<br />-   For a module, the sum of the exclusive allocations of the functions in the module.<br />-   For a line or instruction, the total number of objects that were created by this line or instruction.|
|**Exclusive Allocations %**|The percentage of all objects that were allocated in the profiling run that were exclusive allocations of the module, function, line, or instruction.|
|**Inclusive Bytes**|-   For a function, the number of bytes that were allocated by the function. The number includes bytes that were allocated in functions that were called by this function.<br />-   For a module, the number of bytes that were allocated in a profiling run that were allocated while at least one function from the module was executing. The number includes objects that were created in all functions that were called by the module functions.<br />-   For a line or instruction, the total number of objects that were created by the line or instruction.|
|**Inclusive Bytes %**|The percentage of all bytes that were allocated in the profiling run that were inclusive bytes of the module, function, line, or instruction.|
|**Exclusive Bytes**|-   For a function, the total number of bytes that were allocated by the function. The number does not include bytes that were allocated in functions that were called by this function.<br />-   For a module, the sum of the exclusive bytes that were allocated by the functions in the module.<br />-   For a line or instruction, the total number of objects that were allocated by this line or instruction.|
|**Exclusive Bytes %**|The percentage of all bytes that were allocated in the profiling run that were exclusive bytes of the module, function, line, or instruction.|

## See also
- [How to: Customize Report View columns](../profiling/how-to-customize-report-view-columns.md)
- [Modules View - instrumentation](../profiling/modules-view-dotnet-memory-instrumentation-data.md)
- [Modules View](../profiling/modules-view-sampling-data.md)
- [Modules View](../profiling/modules-view-instrumentation-data.md)
