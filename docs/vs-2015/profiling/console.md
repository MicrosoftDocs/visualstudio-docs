---
title: "Console | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: e825ba66-1383-46ad-8712-396bc9c14036
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Console
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Console** option starts the specified application in a new command prompt window. **Console** can only be used with the VSPerfCmd **Launch** option. If the application is not a command-line application, **Console** has no effect.  
  
## Syntax  
  
```  
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
