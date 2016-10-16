---
title: "PF"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: cdc0a094-a986-4629-bd1c-dd5fdca323dc
caps.latest.revision: 8
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# PF
The VSPerfCmd.exe **PF** option sets the profiling event that is sampled to page faults, and it optionally changes the number of page faults in a sampling interval from the default of 10.  
  
> [!NOTE]
>  PF can not be used on 64 bit systems.  
  
 **Note PF** is not supported on 64 bit computers.**PF** can only be used in a command line that also contains the **Launch** or the **Attach** option.  
  
 By default, the sampling event is set to non-halted processor clock cycles and the sampling interval is set to 10,000,000. The **Timer**, **PF**, **Sys**, and **Counter** options enable you to set the sample event and sampling interval. The **GC** option collects .NET memory data at each allocation and garbage collection event. Only one of these options can be specified on a command line.  
  
 The sampling event and sampling interval can be set only in the first command line that contains a **Launch** or an **Attach** option.  
  
## Syntax  
  
```  
VSPerfCmd.exe {/Launch:AppName|/Attach:PID} /PF[:Events] [Options]  
```  
  
#### Parameters  
 `Events`  
 An integer value that specifies the number of page fault events in a sampling interval. If `Events` is not specified, the interval is set to 10.  
  
## Required Options  
 **PF** can only be specified on a command line that contains one of the following options.  
  
 **Launch:** `AppName`  
 Starts the profiler and the application specified by AppName.  
  
 **Attach:** `PID`  
 Attaches the profiler to the process specified by AppName.  
  
## Invalid Options  
 The following options cannot be specified on the same command line as **PF**.  
  
 **Timer**[**:**`Cycles`]  
 Sets the sampling event to processor clock cycles and optionally sets the sampling interval to `Cycles`. The default Timer interval is 10,000,000.  
  
 **Sys**[**:**`Events`]  
 Sets the sampling event to calls from the profiled application to the operating system kernel (syscalls) and optionally sets the sampling interval to `Events`. The default Sys interval is 10.  
  
 **Counter:** `Name`[`,Reload`[`,FriendlyName`]]  
 Sets the sampling event to the CPU performance counter specified by `Name` and sets the sampling interval to `Reload`.  
  
 **GC**[**:**{**Allocation**&#124;**Lifetime**}]  
 Collects .NET memory data. By default (**Allocation**), data is collected at every memory allocation event. When the **Lifetime** parameter is specified, data is also collected at each garbage collection event.  
  
## Example  
 This example demonstrates how to set the profiling sample event to page faults and set the sampling interval to 20 page faults.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /PF:20  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-asp.net-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)