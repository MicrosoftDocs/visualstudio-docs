---
title: "Process View - Contention Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Process view"
ms.assetid: 8821d98c-0771-43b2-a38b-e9039a3abd75
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Process View - Contention Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Process view displays contention data for the processes and threads that were executed during the profiling run.  
  
 When symbols are available, processes are listed by name. When symbols are not available, processes are listed by their memory address in hexadecimal format. Threads are listed as children of the process that created them.  
  
 The following table explains the values of the columns in the Process view table.  
  
|Column|Description|  
|------------|-----------------|  
|**Begin Time**|The number of milliseconds or processor cycles from the start of profiling to the start of the process or thread.|  
|**Blocked Time**|The total time during which functions of the process or thread were blocked from executing.|  
|**Blocked Time %**|The percentage of the lifetime of the process or thread in which the functions of the process or thread were blocked from executing.|  
|**Contentions**|The number of times that the functions of the process or thread were blocked from executing.|  
|**Contentions %**|The percentage of all contentions in the profiling run that were contentions of the process or thread.|  
|**End Time**|The number of milliseconds or processor cycles from the start of profiling to the end of the process or thread.|  
|**ID**|The system-generated identifier of the process or thread.|  
|**Life Time**|The number of milliseconds or processor cycles from the start of the process or thread to either the end of the process or thread or the end of profiling.|  
|**Type**|The type of row, either process or thread.<br /><br /> Only in **VSReport** command-line reports. For more information, see [VSPerfReport](../profiling/vsperfreport.md).|  
|**Name**|The name of the process or thread.|  
|**Unique ID**|A profiler-generated identifier that is unique to the process or thread.|  
  
## See Also  
 [How to: Customize Report View Columns](../profiling/how-to-customize-report-view-columns.md)   
 [Process View](../profiling/process-view.md)
