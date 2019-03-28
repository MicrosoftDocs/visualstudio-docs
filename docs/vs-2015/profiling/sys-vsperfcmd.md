---
title: "Sys (VSPerfCmd) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 294a6f9e-b49f-4c83-b322-5ac5411b66fb
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Sys (VSPerfCmd)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Sys** option sets the profiling event that is sampled to system call events (function calls from the profiled application to the operating system), and optionally changes the number of system calls in a sampling interval from the default of 10.  
  
 **Sys** can only be used in a command line that also contains the **Launch** or the **Attach** option.  
  
 By default, the profiler sampling event is set to processor clock cycles and the sampling interval is set to 10,000,000. The **Timer**, **PF**, **Sys**, and **Counter** options enable you to set the sampling event and the sampling interval. The **GC** option collects .NET memory data at each allocation and garbage collection event. Only one of these options can be specified on a command line.  
  
 The sampling event and the sampling interval can be set only in the first command line that contains a **Launch** or an **Attach** option.  
  
## Syntax  
  
```  
VSPerfCmd.exe {/Launch:AppName|Attach:PID} /Sys[:Events] [Options]  
```  
  
#### Parameters  
 `Events`  
 An integer value that specifies the number of system call events in a sampling interval. If `Events` is not specified, the interval is set to 10.  
  
## Required Options  
 **Sys** requires one of the following options.  
  
 **Launch:** `AppName`  
 Starts the profiler and the application specified by `AppName`.  
  
 **Attach:** `PID`  
 Attaches the profiler to the process specified by `PID`.  
  
## Invalid Options  
 The following options cannot be specified on the same command line as **Sys**.  
  
 **PF**[**:**`Events`]  
 Sets the sampling event to page faults and optionally sets the sampling interval to `Events`. The default PF interval is 10.  
  
 **Timer**[**:**`Cycles`]  
 Sets the sampling event to processor clock cycles and optionally sets the sampling interval to `Cycles`. The default Timer interval is 10,000,000.  
  
 **Counter:** `Name`[`,Reload`[`,FriendlyName`]]  
 Sets the sampling event to the CPU performance counter specified by `Name` and sets the sampling interval to `Reload`.  
  
 **GC**[**:**{**Allocation**&#124;**Lifetime**}]  
 Collects .NET memory data. By default (**Allocation**), data is collected at every memory allocation event. When the **Lifetime** parameter is specified, data is also collected at each garbage collection event.  
  
## Example  
 This example demonstrates how to set the profiler sampling event to system calls and how to set the sampling interval to 20 calls per sample.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /Sys:20  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
