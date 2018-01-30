---
title: "Shutdown | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a1e37500-4ad1-4670-9737-3d9a20536386
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Shutdown
The **Shutdown** option waits for any currently profiled process to end or detach, and then it turns the profiler off and closes the profiling data file. The **Shutdown** option must be the last command of a profiling run.  
  
 If a time-out parameter is not specified, the **Shutdown** option will wait indefinitely. If a time-out parameter is specified, the option returns after the specified number of seconds without turning the profiler off or closing the data file.  
  
 The **Shutdown** option must be the only option specified on the command line.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Shutdown[:Timeout]  
```  
  
#### Parameters  
 `Timeout`  
 -   (Optional) If specified, the option returns after the specified number of seconds without turning the profiler off or closing the profiling data file.  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)