---
title: "QueryCounters"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8059d4b2-af61-4a47-a6c2-8da5c0741c74
caps.latest.revision: 9
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# QueryCounters
The **QueryCounters** option lists the CPU (hardware) performance counters that are available on the computer.  
  
 **QueryCounters** must be the only option on the command line.  
  
## Syntax  
  
```  
VSPerfCmd.exe /QueryCounters  
```  
  
#### Parameters  
 None  
  
## Remarks  
 When you are using the instrumentation method, the profiler can collect the values of one or more CPU performance counters at each data collection event. When you are using the sampling profiling method, you can specify one counter event and the number of event occurrences to be used as the sampling interval.  
  
 Different processors expose different CPU performance counters. The profiler defines a set of generic counters that can be used on almost all processors. The **QueryCounters** option lists both the names of the generic counters and the names of the counters that are specific to the processor.  
  
## See Also  
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)