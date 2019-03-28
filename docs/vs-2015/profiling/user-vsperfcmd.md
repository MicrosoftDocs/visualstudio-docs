---
title: "User (VSPerfCmd) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: ee1a478e-374d-4f30-ae28-d260b9d4723a
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# User (VSPerfCmd)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **User** option specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.  
  
 The **User** option can only be specified on a command line that also contains the **Start** option option.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Start:Method /Output:FileName /User:[Domain\]UserName [Options]  
```  
  
#### Parameters  
 `Domain`  
 The name of the user's domain.  
  
 `UserName`  
 The name of the user.  
  
## Required Options  
 The **User** option can only be used with the **Start** option.  
  
 **Start:** `Method`  
 Initializes the profiler to the specified profiling method.  
  
## Example  
 The following example demonstrates the use of the **User** option.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /User:SYSTEM  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
