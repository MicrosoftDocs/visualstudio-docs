---
title: "LineOff | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 76082063-20ef-47ae-ad64-81b43b654865
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# LineOff
By default, the profiler collects the source code line number and line number offset data when you are using the sampling profiling method. The VSPerfCmd **LineOff** option disables line number data collection when VSPerfCmd is used to start the application. Profiling data is collected to the function level when **LineOff** is specified.

 You can use **LineOff** only with the **Launch** option, and only when the profiler has been initialized to sampling by using the **Start**:**Sample** option.

## Syntax

```cmd
VSPerfCmd.exe /Launch:AppName /LineOff [Options]
```

#### Parameters
 None

## Required Options
 The **LineOff** option can only be used on a command line that contains the **Launch** option.

 **Launch:** `AppName`
 Starts the specified application and begins profiling with the sampling method.

## Example
 This example starts the application and the profiler, and disables line-level sampling.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
VSPerfCmd.exe /Launch:TestApp.exe /LineOff
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
