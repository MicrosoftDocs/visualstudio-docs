---
title: "Modules View - Contention Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Modules view"
ms.assetid: 1a9aa122-2d8f-4a09-b503-92975aa6b648
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Modules View - Contention Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Modules view of contention data displays concurrency data grouped by the modules that were sampled in the profiling data. Each module is the root of a hierarchical tree. The functions of the module in which contention events occurred are listed under the module node.  
  
 If the function was executing its own code when a contention event occurred, that is, the function was at the top of the call stack, the source lines and instruction addresses that were executing are listed under the function node. Because data is collected for a source line or an instruction pointer when the line or instruction is executing, inclusive and exclusive values are always the same for both line data and instruction data.  
  
 The following table describes the values of the columns in the Modules view of contention data.  
  
|Column|Description|  
|------------|-----------------|  
|**Exclusive Blocked Time**|-   For a function, the time that this function was blocked from executing code in the body of the function. Blocked time in functions that were called by the function is not included.<br />-   For a module, the sum of exclusive blocked time of the functions in the module.<br />-   For a line or an instruction, the time that this line or instruction was blocked from executing.|  
|**Exclusive Blocked Time %**|-   For a function or a module, the percentage of all blocked time in the profiling run that was the exclusive blocked time of this function or module.<br />-   For a line or an instruction, the percentage of all blocked time in the profiling run in which this line or instruction was blocked from executing.|  
|**Exclusive Contentions**|-   For a function, the number of times that this function was blocked from executing code in the body of the function. Contentions in functions that were called by the function are not included.<br />-   For a module, the sum of the exclusive contentions of the functions in the module.<br />-   For a line or an instruction, the number of times that this line or instruction was blocked from executing.|  
|**Exclusive Contentions %**|-   For a function or a module, the percentage of all contentions in the profiling run that were exclusive contentions of this function or module.<br />-   For a line or an instruction, the percentage of all contentions in the profiling run that were contentions that blocked this line or instruction from executing.|  
|**Inclusive Blocked Time**|-   For a function, the time that this function or a function that was called by this function was blocked from executing.<br />-   For a module, the sum of the blocked time in which at least one function from this module was on the stack.<br />-   For a line or an instruction, the time that this line or instruction was blocked from executing.|  
|**Inclusive Blocked Time %**|-   For a function or a module, the percentage of all blocked time in the profiling run that was inclusive blocked time of this function or module.<br />-   For a line or an instruction, the percentage of all blocked time in the profiling run in which this line or instruction was executing.|  
|**Inclusive Contentions**|-   For a function, the number of times that this function or a function that was called by this function was blocked from executing.<br />-   For a module, the number of contentions in which at least one function from this module was on the stack.<br />-   For a line or an instruction, the number of times that this line or instruction was blocked from executing.|  
|**Inclusive Contentions %**|-   For a function or a module, the percentage of all contentions in the profiling run that were inclusive contentions of this function or module.<br />-   For a line or an instruction, the percentage of all blocked time in the profiling run in which this line or instruction was executing.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Module Name**|The name of the module that contains the function, line, or instruction pointer.|  
|**Module Path**|The path of the module that contains the module, function, line, or instruction pointer.|  
|**Name**|The name of the module or function.|  
|**Process ID**|The process ID (PID) of the profiling run.|  
|**Process Name**|The name of the process.|  
|**Source File**|The source file that contains the definition for this function.|  
  
## See Also  
 [How to: Customize Report View Columns](../profiling/how-to-customize-report-view-columns.md)   
 [Modules View](../profiling/modules-view.md)   
 [Modules View - Instrumentation](../profiling/modules-view-dotnet-memory-instrumentation-data.md)   
 [Modules View - Sampling](../profiling/modules-view-dotnet-memory-sampling-data.md)   
 [Modules View](../profiling/modules-view-instrumentation-data.md)   
 [Modules View](../profiling/modules-view-sampling-data.md)
