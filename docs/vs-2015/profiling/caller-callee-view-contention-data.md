---
title: "Caller - Callee View -  Contention Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Caller/Callee view"
ms.assetid: a18a1b1b-9b39-43c7-b1f3-708fd20376f6
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Caller / Callee View -  Contention Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Caller/Callee view displays contention information for a selected function and its parent and child functions. The Caller/Callee view contains three grids.  
  
 **Current function** is displayed in the middle grid, and it shows contention information for the selected function. The values include all blocking contentions for the function.  
  
 **Functions that called the current function** is displayed in the top grid, and it shows the individual contributions of the caller (parent) functions to the values of the selected (current) function.  
  
 **Functions that were called by the current function** is displayed in the bottom grid, and it shows contention information for the callee (child) functions of the selected function when the child function was called by the current function.  
  
|Column|Description|  
|------------|-----------------|  
|**Type**|The context of the function:<br /><br /> -   **0** - the current function<br />-   **1** - a function that calls the current function<br />-   **2** - a function that is called by the current function<br /><br /> Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|  
|**Exclusive Blocked Time**|-   For the current function, the time that this function was blocked from executing code in the function body. Blocked time in functions called by the function is not included.<br />-   For a caller function, the portion of the exclusive blocked time of the current function that occurred when this function called the current function.<br />-   For a callee function, the time that this function was blocked from executing its own code when this function was called by the current function. Blocked time in child functions called by the callee function is not included.|  
|**Exclusive Blocked Time %**|The percentage of all blocked time in the profiling run that was exclusive blocked time for this function in this context.|  
|**Exclusive Contentions**|-   For the current function, the number of times that this function was blocked from executing code in the function body. Contentions that occurred in functions that were called by the function are not included.<br />-   For a caller function, the number of exclusive contentions of the current function that occurred when this function called the current function.<br />-   For a callee function, the number of times that this function was blocked from executing code in the function body when this function was called by the current function. Contentions that occurred in functions called by the callee function are not included.|  
|**Exclusive Contentions %**|The percentage of all contentions in the profiling run that were exclusive contentions for this function in this context.|  
|**Function Address**|The function address or token.|  
|**Function Name**|The fully qualified name of the function.|  
|**Inclusive Blocked Time**|-   For the current function, the time that this function or one of the functions that were called by this function was blocked from executing. Blocked time in functions that were called by the current function is included.<br />-   For a caller function, the portion of the inclusive blocked time of the current function that occurred when this function called the current function.<br />-   For a callee function, the time that this function or one of the functions that was called by the function was blocked from executing when this function was called by the current function. Blocked time in functions that were called by the callee function is included.|  
|**Inclusive Blocked Time %**|The percentage of all blocked time in the profiling run that was inclusive blocked time for this function in this context.|  
|**Inclusive Contentions**|-   For the current function, the number of times that this function or one of the functions that were called by the function was blocked from executing. Contentions that occurred in functions that were called by the function are included.<br />-   For a caller function, the number of inclusive contentions of the current function that occurred when this function called the current function.<br />-   For a callee function, the number of times that this function or one of the functions that were called by the function was blocked from executing when this function was called by the current function. Contentions that occurred in functions called by the callee function are included.|  
|**Inclusive Contentions %**|The percentage of all contentions in the profiling run that were exclusive contentions for this function in this context.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Module Name**|The name of the module that contains the function.|  
|**Module Path**|The path of the module that contains the function.|  
|**Process ID**|The process ID (PID) of the process in which the contentions occurred.|  
|**Process Name**|The name of the process.|  
|**Root Function Name**|The name of the current function. Only in [VSPerfReport](../profiling/vsperfreport.md) command-line reports.|  
|**Source File**|The source file that contains the definition for this function.|  
  
## See Also  
 [How to: Customize Report View Columns](../profiling/how-to-customize-report-view-columns.md)   
 [Caller/Callee View](../profiling/caller-callee-view.md)   
 [Caller / Callee View - Sampling Data](../profiling/caller-callee-view-sampling-data.md)   
 [Caller/Callee View - NET Memory Instrumentation Data](../profiling/caller-callee-view-net-memory-instrumentation-data.md)   
 [Caller/Callee View - .NET Memory Sampling Data](../profiling/caller-callee-view-dotnet-memory-sampling-data.md)   
 [Caller/Callee View - Instrumentation Data](../profiling/caller-callee-view-instrumentation-data.md)
