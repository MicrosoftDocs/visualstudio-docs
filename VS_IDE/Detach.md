---
title: "Detach"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d9d1b52c-7f28-467d-b1e0-512afc4e46c9
caps.latest.revision: 8
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
# Detach
The VSPerfCmd.exe **Detach** option disconnects the profiler fromthe specified processes or all processes if none are specifed. Profiling must have been initialized by using the sampling method.  
  
 Profiling that was started with either the **Launch** or the **Attach** options can be disconnected with **Detach**. The profiler can be reattched by using subsequent **Attach** commands.  
  
 **Detach** does not close the profiling data file. Use the **Shutdown** option to end profiling and close the data file.  
  
> [!NOTE]
>  If the **Start** option was specified with the **Crosssession** option, any calls to **VSPerfCmd /Attach** or to **VSPerfCmd /Detach** must also specify **Crosssession**.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Detach[:PIDs|ProcessNames]  
```  
  
#### Parameters  
 `PIDs|ProcessNames`  
 `PID` - The numeric system identifer of one or more processes.  
  
 `ProcessNames` - the name of the process. If multiple instances of the named process are running, results are unpredictable.  
  
 Separate multiple processes with commas.  
  
 If no process is specified, the profiler is detached from all profiled process.  
  
## Valid options  
 The following **VSPerfCmd** options can be combined with the **Attach** option on a single command line.  
  
 **Crosssession**  
 Enables profiling applications in sessions other than the logon session. Required if the **Start** option was specified with the **Crosssession** option.  
  
## Example  
 In this example, the **Detach** command suspends profiling and the **Shutdown** command closes the profiler data file.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe  
;REM Excercise the application  
VSPerfCmd.exe /Detach  
VSPerfCmd.exe /Shutdown  
```  
  
## See Also  
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)