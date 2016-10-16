---
title: "Modules View - Sampling Data"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Modules view"
  - "sampling profiling method,Modules view"
ms.assetid: 816f5633-65d7-41e5-aee1-033628d4e2df
caps.latest.revision: 13
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Modules View - Sampling Data
The Modules view of sampling data displays performance data that is grouped by the modules that were sampled in the profiling data. Each module is the root of a hierarchical tree. The sampled functions of the module are listed underneath the module node.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
 If the function was executing when samples were collected (that is, the function was at the top of the call stack), the source lines and instruction addresses that were executing are listed underneath the function node. Because data is collected for a source line or an instruction pointer when the line or instruction is executing, inclusive and exclusive values are always the same for both line data and instruction data.  
  
|Column|Description|  
|------------|-----------------|  
|**Name**|The name of the module, function, line number, or instruction pointer address.|  
|**Process ID**|The process ID (PID) of the profiling run.|  
|**Process Name**|The name of the process.|  
|**Module Name**|The name of the module that contains the function, line, or instruction pointer.|  
|**Module Path**|The path of the module that contains the module, function, line, or instruction pointer.|  
|**Source File**|The source file that contains the definition for this function.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Inclusive Samples**|-   For a function, the number of samples in which this function or a function that was called by this function was executing; that is, the number of call stack samples that contained this function.<br />-   For a module, the number of samples in which at least one function from the module was executing.<br />-   For a line or instruction, the number of samples in which this line or instruction was executing.|  
|**Inclusive Samples %**|-   For a function or module, the percentage of all samples in the profiling run that were inclusive samples of this function or module.<br />-   For a line or instruction, the percentage of all samples in the profiling run in which this line or instruction was executing.|  
|**Exclusive Samples**|-   For a function, the number of call stack samples in which this function was directly executing; that is, the number of samples in which this function was at the top of the call stack.<br />-   For a module, the sum of exclusive samples of the functions in the module.<br />-   For a line or instruction, the number of samples in which this line or instruction was executing.|  
|**Exclusive Samples %**|-   For a function or module, the percentage of all samples in the profiling run that were exclusive samples of this function or module.<br />-   For a line or instruction, the percentage of all samples in the profiling run in which this line or instruction was executing.|  
  
## See Also  
 [Modules View - Sampling](../profiling/modules-view---.net-memory-sampling-data.md)   
 [Modules View - Instrumentation](../profiling/modules-view---.net-memory-instrumentation-data.md)   
 [Modules View](../profiling/modules-view---instrumentation-data.md)