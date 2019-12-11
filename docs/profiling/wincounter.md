---
title: "WinCounter | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: ff319ffc-f249-4c3f-9eb2-06e392e3ae80
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# WinCounter
The **WinCounter** option specifies a Windows or application performance counter to collect at set intervals during the profile run. Windows and application performance counters are listed as marks in the profiling data file. You can specify multiple performance counters to collect in separate options.

 By default, counters are collected every 500 milliseconds. Use the **AutoMark** option to specify a different collection interval.

 Only one **AutoMark** option is used. If multiple **AutoMark** options are specified, the last one is used.

 The **WinCounter** option can only be used with the **Start** option.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /Wincounter:Path [/WinCounter:Path] [AutoMark:Milliseconds] [Options]
```

#### Parameters
 `Path`
 The Windows performance counter in PDH counter path format.

## Required options
 The **WinCounter** option can only be used with the **Start** option.

 **Start:** `Method`
 The **Start** option initializes the profiler to the specified profiling method.

## Exclusive options
 The **AutoMark** option can only be used with the **WinCounter** option.

 **AutoMark:** `Milliseconds`
 Specifies the number of milliseconds between Windows performance counter data collection.

## Example
 In the following example, two Windows performance counters are specified to be collected at an interval of 1000 milliseconds.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /WinCounter:"\Processor(0)\% Processor Time" /WinCounter:"\System\Context Switches/sec" /AutoMark:1000
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
