---
title: "Functions View - Sampling Data | Microsoft Docs"
description: Read about the Functions report view for the sampling profile method, which lists the functions that were sampled during the profiling run.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "sampling profiling method,Functions View"
  - "Functions view"
ms.assetid: 029d5ebb-e551-46b0-b64e-2c553d9dbb8e
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Functions View - sampling data
The Functions report view for the sampling profile method lists the functions that were sampled during the profiling run.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

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
|**Inclusive Samples**|The total number of samples that were collected when this function was executing; that is, the number of samples that were collected when this function was on the call stack. The number includes samples that were collected when functions that were called by this function were executing.|
|**Inclusive Samples %**|The percentage of all samples in the profiling run that were inclusive samples of this function.|
|**Exclusive Samples**|The total number of samples that were collected when code in the body of this function was executing; that is, when this function was on the top of the call stack. Samples that were collected in functions that were called by this function are not included.|
|**Exclusive Samples %**|The percentage of all samples in the profiling run that were exclusive samples of this function.|

## See also
- [How to: Customize Report View columns](../profiling/how-to-customize-report-view-columns.md)
- [Functions View - instrumentation](../profiling/functions-view-dotnet-memory-instrumentation-data.md)
- [Functions View - sampling](../profiling/functions-view-dotnet-memory-sampling-data.md)
- [Functions View](../profiling/functions-view-instrumentation-data.md)
