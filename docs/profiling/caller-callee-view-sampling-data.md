---
title: "Caller - Callee View - Sampling Data | Microsoft Docs"
description: Read how the Caller/Callee view displays profiling information for a selected function and its parent and child functions in Performance Explorer.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "sampling profiling method,Caller/Callee view"
  - "Caller/Callee view"
ms.assetid: 28e85ed5-1512-4b59-bb84-138a2abca7dd
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Caller/Callee view - sampling data
The Caller/Callee view displays profiling information for a selected function and its parent and child functions. The Caller/Callee view contains three grids.

 **Current function** is displayed in the middle grid, and it shows profiling information for the selected function. The values include all sampled calls to the function.

 **Functions that called the current function** is displayed in the top grid, and it shows the individual contributions of the caller (parent) functions to the values of the selected (current) function.

 **Functions that were called by the current function** is displayed in the bottom grid, and it shows profiling information for the callee (child) functions of the selected function when the child function was called by the current function.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

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
|**Type**|The context of the function:<br /><br /> -   **0** - the current function<br />-   **1** - a function that calls the current function<br />-   **2** - a function that is called by the current function|
|**Root Function Name**|The name of the current function.|
|**Inclusive Samples**|-   For the current function, the number of samples that were collected although this function or one of its child functions was executing.<br />-   For a caller function, the number of inclusive samples of the current function that were collected when this function called the current function.<br />-   For a callee function, the number of inclusive samples of this function that were collected when the current function called this function.|
|**Inclusive Samples %**|The percentage of all samples in the profiling run that were inclusive samples of this function.|
|**Exclusive Samples**|-   For the current function, the number of samples in the profiling run that were collected when this function was directly executing; that is, when this function was at the top of the call stack. Samples that are collected when child functions of this function are executing are not counted in exclusive counts.<br />-   For a caller function, the number of exclusive samples of the current function that were collected when this function called the current function.<br />-   For a callee function, the number of exclusive samples of this function that were collected when the current function called this function.|
|**Exclusive Samples %**|The percentage of all samples in the profiling run that were exclusive samples of this function.|

## See also
- [Caller/Callee view - .NET memory sampling data](../profiling/caller-callee-view-dotnet-memory-sampling-data.md)
- [Caller/Callee view - .NET memory instrumentation data](../profiling/caller-callee-view-net-memory-instrumentation-data.md)
- [Caller/Callee view - instrumentation data](../profiling/caller-callee-view-instrumentation-data.md)
