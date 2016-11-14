---
title: "QueryCounters | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8059d4b2-af61-4a47-a6c2-8da5c0741c74
caps.latest.revision: 9
author: "mikejo5000"
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
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)