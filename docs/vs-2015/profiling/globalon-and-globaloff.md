---
title: "GlobalOn and GlobalOff | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 24b0ed68-d19e-473e-9af3-252c11d82bcf
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# GlobalOn and GlobalOff
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **GlobalOff** and **GlobalOn** options pause and resume profiling for all processes and threads in a command-line profiling session.  
  
 You can specify **GlobalOn** and **GlobalOff** as the only options in a VSPerfCmd.exe command line, or you can include them in command lines that also contain the **Start**, **Launch**, or **Attach** options.  
  
 **GlobalOn** and **GlobalOff** can also be combined with the **ProcessOn**, **ProcessOff**, **ThreadOn**, and **ThreadOff** options.  
  
 The **GlobalOn** and **GlobalOff** options interact with the **ProcessOn** and **ProcessOff** options that control data collection for a specified process, and with the **ThreadOn** and **ThreadOff** options that control data collection for a specified thread.  
  
 The **GlobalOff** and **GlobalOn** options also affect the Global Start/Stop count that is manipulated by the profiler's API functions.  
  
- **GlobalOff** immediately sets the Global Start/Stop Count to 0 and therefore pauses profiling.  
  
- **GlobalOn** immediately sets the Global Start/Stop Count to 1 and therefore resumes profiling.  
  
  For more information, see [Profiling Tools APIs](../profiling/profiling-tools-apis.md).  
  
## Syntax  
  
```  
VSPerfCmd.exe /{GlobalOff|GlobalOn}  
  
VSPerfCmd.exe /Start:Method /{GlobalOff|GlobalOn} [Options]  
  
VSPerfCmd.exe {Launch:AppName|Attach:PID} /{GlobalOff|GlobalOn}[Options]  
```  
  
#### Parameters  
 None  
  
## Valid Options  
 **GlobalOn** and **GlobalOff** can be specified on command lines that also contain the following options.  
  
 **Start:** `Method`  
 Initializes the command-line profiler session and sets the specified profiling method.  
  
 **Launch:** `AppName`  
 Starts the specified application and begins profiling with the sampling method.  
  
 **Attach:** `PID`  
 Begins profiling the specified process.  
  
 {**ProcessOff**&#124;**ProcessOn**}**:**`PID`  
 Stops or starts profiling for the specified process.  
  
 {**ThreadOff**&#124;**ThreadOn**}**:**`TID`  
 Stops or starts profiling for the specified process (instrumentation method only).  
  
## Example  
 In this example, the **GlobalOff** and **GlobalOn** options are used to avoid collecting profiling data for application startup and shutdown.  
  
```  
; Initialize the profiler with profiling stopped.  
VSPerfCmd.exe /Start:Trace /Output:Instrument.vsp /GlobalOff  
; Start an instrumented application and wait for it to warm up.  
; Start profiling.  
VSPerfCmd.exe /GlobalOn  
; Exercise the application functionality that you want to profile.  
; Stop profiling.  
VSPerfCmd.exe /GlobalOff  
; Shut down the target application.  
; Close the profiler.  
VSPerfCmd /Shutdown  
  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
