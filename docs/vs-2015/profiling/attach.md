---
title: "Attach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 79614283-6733-4592-a53a-d428052271ad
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Attach
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Attach** option begins sample profiling of the running process specified by the process ID (PID).  
  
 To use the **Attach** option, you must specify the **Sample** method in the Start option.  
  
> [!NOTE]
> If the **Start** option was specified with the **Crosssession** option, any calls to **VSPerfCmd /Attach** or to **VSPerfCmd /Detach** must also specify **Crosssession**.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Attach:ProcessID [Options]  
```  
  
#### Parameters  
 `ProcessID`  
 The process ID (PID) of the running process. The PID of a running process is listed on the Processes tab of Windows Task Manager.  
  
## Valid Options  
 The following **VSPerfCmd** options can be combined with the **Attach** option on a single command line.  
  
 **Crosssession**  
 Enables profiling applications in sessions other than the logon session. Required if the **Start** option was specified with the **Crosssession** option.  
  
 **Start:** `Method`  
 Initializes the command-line profiler session and sets the specified profiling method.  
  
 **TargetCLR**  
 Specifies the version of the .NET Framework Common Language Runtime (CLR) to profile when more than one version is loaded in a profiling session. By default, the first loaded version is profiled.  
  
 **GlobalOn GlobalOff**  
 Resumes (**GlobalOn**) or pauses (**GlobalOff**) profiling, but does not end the profiling session.  
  
 **ProcessOn:** `PID` **ProcessOff:** `PID`  
 Resumes (**ProcessOn**) or pauses (**ProcessOff**) profiling for the specified process.  
  
## Interval Options  
 One of the following sampling interval options can be specified on the Attach command line. The default sampling interval is 10,000,000 processor clock cycles.  
  
 **Timer**[**:**`Cycles`]**PF**[**:**`Events`]**Sys**[<strong>:</strong>Events]**Counter**[**:**`Name`,`Reload`,`FriendlyName`]  
 Specifies the number and type of the sampling interval.  
  
- **Timer** - Samples every `Cycles` processor clock cycles. If `Cycles` is not specified, 10,000,000 cycles are used.  
  
- **PF** - Samples every `Events` page faults. If `Events` is not specified, 10 page faults are used.  
  
- **Sys** - Samples every `Events` calls to the operating system. If `Events` is not specified, 10 system calls are used.  
  
- **Counter** - Samples every `Reload` number of the CPU performance counter specified by `Name`. Optionally, `FriendlyName` can specify a string to use as the column header in profiler reports.  
  
## Example  
 This example demonstrates how to attach to a running instance of an application with the process ID of 12345.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Attach:12345  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
