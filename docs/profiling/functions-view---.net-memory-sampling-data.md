---
title: "Functions View - .NET Memory Sampling Data"
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
  - "Functions view"
ms.assetid: 5d9c6302-2ffd-430e-9535-13ce795f9f7c
caps.latest.revision: 9
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Functions View - .NET Memory Sampling Data
The Functions view of .NET memory allocation profiling data that was collected by using the sampling method lists the functions that allocated memory during the profiling run and reports the size and number of allocations.  
  
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
|**Inclusive Allocations**|The total number of objects that were allocated in this function and its child functions.|  
|**Inclusive Allocations %**|The percentage of all objects that were allocated in the profiling run that were inclusive allocations of this function.|  
|**Exclusive Allocations**|The number of objects that were created when the function was directly executing at the top of the call stack. This number does not include objects that were created in child functions.|  
|**Exclusive Allocations %**|The percentage of all objects that were allocated in the profiling run that were exclusive allocations of this function.|  
|**Inclusive Bytes**|The number of bytes of memory that were allocated by this function and its child functions.|  
|**Inclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were inclusive bytes of this function.|  
|**Exclusive Bytes**|The number of bytes of memory that were allocated by this function but not by its child functions.|  
|**Exclusive Bytes %**|The percentage of all bytes of memory that were allocated in the profiling run that were exclusive bytes of this function.|  
  
## See Also  
 [Functions View - Instrumentation](../profiling/functions-view---.net-memory-instrumentation-data.md)   
 [Functions View](../profiling/functions-view---sampling-data.md)   
 [Functions View](../profiling/functions-view---instrumentation-data.md)