---
title: "QueryCounters | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 8059d4b2-af61-4a47-a6c2-8da5c0741c74
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# QueryCounters
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
