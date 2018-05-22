---
title: "Console | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
ms.assetid: e825ba66-1383-46ad-8712-396bc9c14036
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Console
The VSPerfCmd.exe **Console** option starts the specified application in a new command prompt window. **Console** can only be used with the VSPerfCmd **Launch** option. If the application is not a command-line application, **Console** has no effect.  
  
## Syntax  
  
```cmd  
VSPerfCmd.exe /Launch:AppName /Console  
```  
  
#### Parameters  
 None  
  
## Required Options  
 **Console** can only be specified on a command line that also contains the **Launch** option.  
  
 **Launch:** `AppName`  
 Starts the profiler and the application specified by `AppName`.  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)