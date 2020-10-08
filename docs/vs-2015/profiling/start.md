---
title: "Start | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: b85d0fe9-f67a-4b7c-8d48-7eecf3f2dfe9
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Start
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Start** option is a VSPerfCmd.exe option that initializes the profiler to the specified profiling method.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Start:Method /Output:FileName [Options]  
```  
  
#### Parameters  
 `Method`  
 Must be one of the following keywords:  
  
- **TRACE** - Specifies the instrumentation method.  
  
- **SAMPLE** - Specifies the sampling method.  
  
- **COVERAGE** - Specifies code coverage.  
  
- **CONCURRENCY** - Specifies the resource contention method.  
  
## Required Options  
 The **Output** option must be specified when **Start** is specified on the command line.  
  
 **Output:** `filename`  
 Specifies the output file name.  
  
## Exclusive Options  
 The following options can only be used with the **Start** option on a command line.  
  
 **CrossSession**&#124;**CS**  
 Enables cross-process profiling. The option names **CrossSession** and **CS** are both supported.  
  
 **User:**[`domain\`]`username`  
 Enables client access to the monitor from the specified account.  
  
 **WinCounter:** `Path` [**Automark**:`n`]  
 **WinCounter** specifies a Windows performance counter to include as a mark in the profiling data file. **AutoMark** specifies the interval in milliseconds between collections of the data file.  
  
## Invalid Options  
 The following options cannot be used with the **Start** option on a command line.  
  
 **Status**  
 **Status** applies to those processes that are profiled. It lists processes and threads and their current profile state (On/Off). For example, if a process is stopped, **Status** will not indicate this in the report. **Status** will show that the process is either profiled or not.  
  
 **Shutdown**[**:**`Timeout`]  
 Turns the profiler off.  
  
## Example  
 The following example demonstrates how to use the VSPerfCmd.exe **Start** option to initialize the profiler.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
