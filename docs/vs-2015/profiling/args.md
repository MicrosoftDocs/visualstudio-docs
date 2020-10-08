---
title: "Args | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 20c35949-1f29-4282-ac75-4e6c237d71bc
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Args
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Args** option specifies a list of arguments that are passed to the target application of the **Launch** subcommand.  
  
 **Args** can only be used when **Launch** is also specified on the command line. **Args** is optional when **Launch** is specified.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Launch:AppName /Args:Arguments [Options]  
```  
  
#### Parameters  
 `Arguments`  
 A list of arguments to the target application of the **Launch** command.  
  
## Required Options  
 **Launch:** `AppName`  
 Starts the specified application and begins profiling with the sampling method.  
  
## Example  
 The following example uses the **Args** option to pass arguments to TestApp.exe.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /Args:"123, 'Hello World'"  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
