---
title: "AutoMark | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: c4de965e-0364-4f78-9936-1f509e85df74
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# AutoMark
The **AutoMark** option specifies the number of milliseconds between the collection of Windows software performance counter events. Windows performance counters are specified in the **WinCounter** option.

 Only one **AutoMark** option can be specified on the command line. Note that the **WinCounter** sampling interval specified by **AutoMark** is independent of the main sampling interval.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /WinCounter:Path /AutoMark:Milliseconds
```

#### Parameters
 `Milliseconds`
 Specifies the number of milliseconds between collections of Windows performance counter events.

## Required options
 **WinCounter:** `Path`
 Specifies the Windows performance counter to collect. When you are using the instrumentation method, multiple Windows counters can be specified. When you are using the sampling method, only one software counter can be specified. The **WinCounter** option must be specified in a command line that contains the **Start** option.

## Example
 In this example, a sampling interval of 1000 milliseconds is set for two Windows performance counters.

```cmd
VSPerfCmd.exe /Start:Trace /Output:TestApp.exe.vsp /WinCounter:"\Process(*)\% Processor Time" /WinCounter:"\ASP.NET\Pages/sec" /AutoMark:1000
VSPerfCmd.exe /Launch:TestApp.exe
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
