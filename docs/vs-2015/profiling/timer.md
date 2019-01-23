---
title: "Timer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 1971868e-89fa-4452-8ee7-76e4daf31b66
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Timer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Timer** option sets the profiling event that is sampled to processor clock cycles and optionally changes the number of cycles in a sampling interval from the default of 10,000,000. On a 1GH (one gigahertz) processor, 10,000,000 clock cycles is approximately 100 samples per second. The minimum number of cycles that can be specified is 50,000.  
  
 **Timer** can only be used when you use the sampling profiling method, and it can only be used in a command line that also contains the **Launch** or the **Attach** option.  
  
 By default, the profiler sampling event is set to processor clock cycles and the sampling interval is set to 10,000,000. The **Timer**, **PF**, **Sys**, and **Counter** options enable you to set the sampling event and the sampling interval. The **GC** option collects .NET memory data at each allocation and garbage collection event. Only one of these options can be specified on a command line.  
  
 The sampling event and the sampling interval can be set only in the first command line that contains a **Launch** or an **Attach** option.  
  
## Syntax  
  
```  
VSPerfCmd.exe {/Launch:AppName|/Attach:PID} /Timer[:Cycles] [Options]  
```  
  
#### Parameters  
 `Cycles`  
 An integer value that specifies the number of processor clock cycles in a sampling interval. If `Cycles` is not specified, the interval is set to 10,000,000. Specify the value without commas.  
  
## Required Options  
 **Timer** can only be specified on a command line that contains one of the following options.  
  
 **Launch:** `AppName`  
 Starts the profiler and the application specified by `AppName`.  
  
 **Attach:** `PID`  
 Attaches the profiler to the process specified by the process ID (`PID`).  
  
## Invalid Options  
 The following options cannot be specified on the same command line as **Timer**.  
  
 **PF**[**:**`Events`]  
 Sets the sampling event to page faults and optionally sets the sampling interval to `Events`. The default PF interval is 10.  
  
 **Sys**[**:**`Events`]  
 Sets the sampling event to operating system calls and optionally sets the sampling interval to `Events`. The default Sys interval is 10.  
  
 **Counter**[**:**`Name,Reload,FriendlyName`]  
 Sets the sampling event to the CPU performance counter specified by `Name` and sets the sampling interval to `Reload`.  
  
 **GC**[**:**{**Allocation**&#124;**Lifetime**}]  
 Collects .NET memory data. By default (**Allocation**), data is collected at every memory allocation event. When the **Lifetime** parameter is specified, data is also collected at each garbage collection event.  
  
## Example  
 This example demonstrates how to set the profiler sampling interval to 1,000,000 processor cycles.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /Timer:1000000  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
