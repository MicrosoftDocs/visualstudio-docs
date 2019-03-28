---
title: "Output | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 5e286e61-4548-42cf-a635-e608c5edbe2b
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Output
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Output** option specifies the name of the profiling data file for the performance session. **Output** must be used with the **Start** option.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Start:Method /Output:FileName [Options]  
```  
  
#### Parameters  
 `FileName`  
 The name of the data file. Full and partial paths are accepted. If a path is not specified, the file is created in the current directory.  
  
## Required Options  
 The **Output** option must be used with the **Start** option.  
  
 **Start:** `Method`  
 Specifies the output file name.  
  
## Example  
 In the following example, the profiling data file is created in the current directory.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
