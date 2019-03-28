---
title: "Counter | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: aa4b4cdb-e6ea-433a-9579-56f3785e1385
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Counter
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Counter** option collects data from processor (hardware) performance counters.  
  
- When you are using the sampling profiling method, **Counter** specifies the on-chip performance counter and the number of counter events to use as the sampling interval. You can specify only one counter when you are using sampling.  
  
- When you are using the instrumentation profiling method, the number of counter events that occurred in the interval between the previous and current collection events are listed as separate fields in profiler reports. Multiple **Counter** options can be specified when you are using instrumentation.  
  
  Each processor type has its own set of hardware performance counters. The profiler defines a set of generic performance counters that are common to almost all processors. To list the generic and processor-specific counters on your computer, use the VSPerfCmd **QueryCounters** command.  
  
## Syntax  
  
```  
VSPerfCmd.exe {/Launch:AppName | /Attach PID} /Counter:Name[,Reload[,FriendlyName]][Options]  
```  
  
```  
VSPerfCmd.exe /Start:Method /Counter:Name[,Reload[,FriendlyName]][/Counter:Name[,Reload[,FriendlyName]]][Options]  
```  
  
#### Parameters  
 `Name`  
 The name of the counter. Use the VSPerfCmd.exe **/QueryCounters** option to list the names of available counters on the computer.  
  
 `Reload`  
 The number of counter events in the sampling interval. Do not use with the instrumentation method.  
  
 `FriendlyName`  
 (Optional) The string to use in place of `Name` in the column headers of profiler reports and views.  
  
## Required Options  
 The Counter option can only be used with one of the following options:  
  
 **Start:** `Trace`  
 Initializes the profiler to use the instrumentation method.  
  
 **Launch:** `AppName`  
 Starts the specified application and the profiler. The profiler must be initialized to use the sampling method.  
  
 **Attach:** `PID`  
 Starts the profiler and attaches it to the process specified by the process ID. The profiler must be initialized to use the sampling method.  
  
## Example  
 The sampling method example demonstrates how to sample an application at every 1000 occurrences of the generic profiler counter NonHaltedCycles.  
  
 The instrumentation method example demonstrates how to initialize the profiler to collect L2InstructionFetches counter events. The L2InstructionFetches counter name is specific to the processor.  
  
```  
; Sample Method Example  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /Counter:NonHaltedCycles,1000,"Non-Halted Cycles"  
  
;INSTRUMENTATION METHOD EXAMPLE  
VSPerfCmd.exe /Start:Trace /Output:TestApp.exe.vsp /Counter:L2InstructionFetches,,"L2 Cache Instruction Fetches"  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
